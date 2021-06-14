using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.Common.DTO.Post;

namespace Thread_.NET.Common.DTO.Post
{
    public sealed class SharePostMailDTO
    {
        public UserDTO User { get; set; }
        public PostDTO Post { get; set; }
        public string Email { get; set; }
    }
}
