using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _commentService;
        private readonly LikeService _likeService;
        private readonly DislikeService _dislikeService;

        public CommentsController(CommentService commentService, LikeService likeService, DislikeService dislikeService)
        {
            _commentService = commentService;
            _likeService = likeService;
            _dislikeService = dislikeService;
        }

        [HttpPost]
        public async Task<ActionResult<CommentDTO>> CreatePost([FromBody] NewCommentDTO comment)
        {
            comment.AuthorId = this.GetUserIdFromToken();
            return Ok(await _commentService.CreateComment(comment));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CommentDTO>> UpdateComment([FromBody] CommentUpdateDTO dto, [FromRoute] int id)
        {
            int userId = this.GetUserIdFromToken();

            return Ok(await _commentService.UpdateComment(dto, id, userId));
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikeComment(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.LikeComment(reaction);
            return Ok();
        }
        [HttpPost("dislike")]
        public async Task<IActionResult> DislikeComment(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _dislikeService.DislikeComment(reaction);
            return Ok();
        }
    }
}