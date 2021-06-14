using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MailKit.Net.Smtp;
using MimeKit;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public sealed class EmailService : BaseService
    {
        public EmailService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task SharePost(SharePostMailDTO dto)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Thread.NET", "somebusinessmail57@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", dto.Email));
            emailMessage.Subject = $"{dto.User?.UserName ?? "Someone"} shares with you a post!";

            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = $"<div><img alt=\"Avatar\" style=\"border-radius: 100px; width: 40px; height: 40px\" src=\"{dto.Post.Author.Avatar}\"><b>{dto.Post.Author.UserName}</b></div><p>{dto.Post.Body}</p><img alt=\"Image\" src=\"{dto.Post.PreviewImage}\">"
            };


            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("somebusinessmail57@gmail.com", "403138138403");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
