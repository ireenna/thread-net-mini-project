using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public sealed class DislikeService : BaseService
    {
        public DislikeService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task DislikePost(NewReactionDTO reaction)
        {
            var dislikes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId && x.IsDislike);

            if (dislikes.Any())
            {
                _context.PostReactions.RemoveRange(dislikes);
                await _context.SaveChangesAsync();

                return;
            }

            var likes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId && x.IsLike);

            if (likes.Any())
            {
                _context.PostReactions.RemoveRange(likes);
            }

            _context.PostReactions.Add(new DAL.Entities.PostReaction
            {
                PostId = reaction.EntityId,
                IsLike = reaction.IsLike,
                IsDislike = reaction.IsDislike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }
        public async Task DislikeComment(NewReactionDTO reaction)
        {
            var dislikes = _context.CommentReactions.Where(x => x.UserId == reaction.UserId && x.CommentId == reaction.EntityId && x.IsDislike);

            if (dislikes.Any())
            {
                _context.CommentReactions.RemoveRange(dislikes);
                await _context.SaveChangesAsync();

                return;
            }

            var likes = _context.CommentReactions.Where(x => x.UserId == reaction.UserId && x.CommentId == reaction.EntityId && x.IsLike);

            if (likes.Any())
            {
                _context.CommentReactions.RemoveRange(likes);
            }

            _context.CommentReactions.Add(new DAL.Entities.CommentReaction
            {
                CommentId = reaction.EntityId,
                IsLike = reaction.IsLike,
                IsDislike = reaction.IsDislike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }
    }
}
