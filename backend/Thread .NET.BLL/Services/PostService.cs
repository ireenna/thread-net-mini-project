using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class PostService : BaseService
    {
        private readonly IHubContext<PostHub> _postHub;

        public PostService(ThreadContext context, IMapper mapper, IHubContext<PostHub> postHub) : base(context, mapper)
        {
            _postHub = postHub;
        }

        public async Task<ICollection<PostDTO>> GetAllPosts()
        {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .OrderByDescending(post => post.CreatedAt)
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<ICollection<PostDTO>> GetAllPosts(int userId)
        {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .Where(p => p.AuthorId == userId) // Filter here
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<ICollection<PostDTO>> GetAllLikedPosts(int userId)
        {
            var posts = await _context.PostReactions                
                .Where(p => p.UserId == userId && p.IsLike)
                .Join(_context.Posts, pr=>pr.PostId, p=>p.Id, (pr,p)=>new{p})
                .Select(x=>x.p)
                .Include(post => post.Author)
                .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                .ThenInclude(comment => comment.Author)
                .Include(post => post.Comments)
                .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Reactions)
                .ThenInclude(reactions => reactions.User)
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<PostDTO> CreatePost(PostCreateDTO postDto)
        {
            var postEntity = _mapper.Map<Post>(postDto);

            _context.Posts.Add(postEntity);
            await _context.SaveChangesAsync();

            var createdPost = await _context.Posts
                .Include(post => post.Author)
					.ThenInclude(author => author.Avatar)
                .FirstAsync(post => post.Id == postEntity.Id);

            var createdPostDTO = _mapper.Map<PostDTO>(createdPost);
            await _postHub.Clients.All.SendAsync("NewPost", createdPostDTO);

            return createdPostDTO;
        }
        public async Task<PostDTO> UpdatePost(PostUpdateDTO postUpdateDto, int postId, int userId)
        {

            var findedPost = await _context.Posts.Where(x => x.Id == postId).FirstOrDefaultAsync();

            if (findedPost != null && findedPost.AuthorId == userId)
            {
                
                findedPost.Body = postUpdateDto.Body;
                findedPost.UpdatedAt = System.DateTime.Now;
                if (!string.IsNullOrEmpty(postUpdateDto.PreviewImage))
                {
                    if (findedPost.Preview == null)
                    {
                        findedPost.Preview = new Image
                        {
                            URL = postUpdateDto.PreviewImage
                        };
                    }
                    else
                    {
                        findedPost.Preview.URL = postUpdateDto.PreviewImage;
                        findedPost.Preview.UpdatedAt = System.DateTime.Now;
                    }
                }
                else
                {
                    if (findedPost.Preview != null)
                    {
                        _context.Images.Remove(findedPost.Preview);
                    }
                }
                _context.Posts.Update(findedPost);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new NotFoundException(nameof(User), postId);
            }

            var updatedPost = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Reactions)
                .FirstAsync(post => post.Id == findedPost.Id);

            var updatedPostDTO = _mapper.Map<PostDTO>(updatedPost);
            await _postHub.Clients.All.SendAsync("UpdatedPost", updatedPostDTO);
                
            return updatedPostDTO;
        }

        public async Task<PostDTO> DeletePost(int postId, int userId)
        {
            var post = await _context.Posts.Where(x => x.Id == postId).FirstOrDefaultAsync();
            
            if (post is null)
                throw new NotFoundException("Post", postId);

            var postReactions = await _context.PostReactions.Where(x => x.PostId == postId).ToListAsync();
            var comments = await _context.Comments.Where(x => x.PostId == postId).ToListAsync();

            if (userId == post.AuthorId)
            {
                post.IsDeleted = true;

                foreach (var pr in postReactions)
                    pr.IsDeleted = true;

                foreach (var c in comments)
                    c.IsDeleted = true;

                await _context.SaveChangesAsync();

                var deletedPostDTO = _mapper.Map<PostDTO>(post);
                await _postHub.Clients.All.SendAsync("DeletePost", deletedPostDTO);
                return deletedPostDTO;
            }

            throw new System.Exception();
        }
    }
}
