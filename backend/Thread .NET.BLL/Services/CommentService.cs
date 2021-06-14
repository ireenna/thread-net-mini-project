using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class CommentService : BaseService
    {
        public CommentService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<CommentDTO> CreateComment(NewCommentDTO newComment)
        {
            var commentEntity = _mapper.Map<Comment>(newComment);

            _context.Comments.Add(commentEntity);
            await _context.SaveChangesAsync();

            var createdComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(user => user.Avatar)
                .FirstAsync(comment => comment.Id == commentEntity.Id);

            return _mapper.Map<CommentDTO>(createdComment);
        }

        public async Task<CommentDTO> UpdateComment(CommentUpdateDTO commentUpdateDto, int commentId, int userId)
        {
            var findedComment = await _context.Comments.Where(x => x.Id == commentId).FirstOrDefaultAsync();
            
            if (findedComment != null && findedComment.AuthorId == userId)
            {
                findedComment.Body = commentUpdateDto.Body;
                await _context.SaveChangesAsync();
            }

            var updatedComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(comment => comment.Reactions)
                    .ThenInclude(reactions => reactions.User)
                .FirstAsync(comment => comment.Id == findedComment.Id);

            var updatedCommentDTO = _mapper.Map<CommentDTO>(updatedComment);

            return updatedCommentDTO;
        }
        public async Task<CommentDTO> DeleteComment(int commentId, int userId)
        {
            var comment = await _context.Comments.Where(x => x.Id == commentId).FirstOrDefaultAsync();

            if (comment is null)
                throw new NotFoundException("Comment", commentId);

            var commentReactions = await _context.CommentReactions.Where(x => x.CommentId == commentId).ToListAsync();

            if (userId == comment.AuthorId)
            {
                comment.IsDeleted = true;

                foreach (var pr in commentReactions)
                    pr.IsDeleted = true;

                await _context.SaveChangesAsync();

                var deletedCommentDTO = _mapper.Map<CommentDTO>(comment);
                return deletedCommentDTO;
            }

            throw new System.Exception();
        }
    }
}
