﻿using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.BLL.Services.Abstract;
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
            //var posts = await _context.PostReactions
            //        .Join(_context.Posts, 
            //        pr => pr.PostId, 
            //        p=> p.Id,
            //        (pr,p)=>new {pr,p})
            //        .Where(x => x.pr.UserId == userId && x.pr.IsLike) // Filter here
            //        .Select(x => x.p)
            //    .ToListAsync();
            var posts = await _context.PostReactions
                
                .Where(p => p.UserId == userId && p.IsLike)
                .Join(_context.Posts, pr=>pr.PostId, p=>p.Id, (pr,p)=>new{p})
                .Select(x=>x.p)
                .Include(post => post.Author)
                .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                .ThenInclude(comment => comment.Author)
                .Include(post => post.Reactions)
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
        public async Task<PostDTO> UpdatePost(PostDTO postDto)
        {
            //if (findedpost!=null)
            //{
            //    findedpost.Body = postDto.Body;
            //    findedpost.UpdatedAt = System.DateTime.Now;
            //    await _context.Posts.Update(findedpost);
            //}
            var findedpost = await _context.Posts.Where(x => x.Id == postDto.Id).FirstOrDefaultAsync();
            if (findedpost != null)
            {
                findedpost.Body = postDto.Body;
                findedpost.UpdatedAt = System.DateTime.Now;
                var updatedPost = await _context.Posts
                .Include(post => post.Author)
                .ThenInclude(author => author.Avatar)
                .FirstAsync(post => post.Id == findedpost.Id);

                var updatedPostDTO = _mapper.Map<PostDTO>(updatedPost);
                await _postHub.Clients.All.SendAsync("ChangedPost", updatedPostDTO);

                return updatedPostDTO;
            }
            throw new System.Exception();
        }
    }
}
