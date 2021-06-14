using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class IsDeleted20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PostReactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CommentReactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsDeleted", "IsDislike", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2021, 6, 12, 16, 16, 25, 861, DateTimeKind.Local).AddTicks(9600), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(750), 4 },
                    { 18, 14, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(4206), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(4226), 8 },
                    { 17, 17, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3967), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3981), 10 },
                    { 15, 11, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3760), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3776), 3 },
                    { 14, 2, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3601), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3656), 1 },
                    { 13, 14, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3496), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3509), 15 },
                    { 12, 18, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3403), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3415), 1 },
                    { 11, 9, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3308), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3321), 13 },
                    { 19, 13, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(4323), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(4337), 17 },
                    { 10, 19, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3203), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3220), 20 },
                    { 8, 12, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2994), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3007), 12 },
                    { 7, 2, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2895), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2908), 7 },
                    { 6, 10, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2797), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2813), 19 },
                    { 5, 3, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2702), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2715), 18 },
                    { 4, 17, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2605), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2619), 18 },
                    { 3, 1, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2489), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2505), 5 },
                    { 2, 19, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2221), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(2273), 2 },
                    { 9, 13, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3089), false, false, false, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3104), 15 },
                    { 20, 8, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(4420), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(4432), 10 },
                    { 16, 17, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3862), false, false, true, new DateTime(2021, 6, 12, 16, 16, 25, 862, DateTimeKind.Local).AddTicks(3876), 15 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Hic aut nihil tempora.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(998), 17, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Suscipit facere voluptatem dolorem deleniti quisquam dolore ut at.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3080), 11, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Dolorem officiis aut inventore deleniti soluta cupiditate eos ratione.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3255), 10, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Ea dolor eaque eos provident est ipsa.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3584), 10, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Autem consequatur magnam explicabo.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3714), 5, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Quidem saepe voluptas provident ipsa id quis qui.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3907), 19, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Quas nobis impedit corrupti ullam nihil nihil.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4105), 14, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Illum vitae et eum voluptas voluptatem.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4222), 17, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Eum omnis ullam blanditiis molestias tenetur laborum veritatis ea.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4351), 16, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 18, "In eum dolores est consequatur iusto nemo impedit.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4597), new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Ut exercitationem qui vel recusandae voluptatem porro.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4734), 5, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Ratione natus dolor sed tempora.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4842), 11, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Ea veritatis eos non libero labore magnam voluptate.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4961), 11, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Assumenda explicabo voluptatibus impedit qui omnis neque.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5074), 3, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Repudiandae facilis est perspiciatis autem et ut porro.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5344), 12, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Omnis voluptatem totam laborum.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5464), 13, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Qui natus cupiditate esse velit consequuntur iusto dolore.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5581), 18, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Dignissimos et excepturi iure consequatur ducimus esse dolores.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5703), 6, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Voluptatibus eligendi quis itaque aliquid asperiores quasi sint explicabo.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5831), 4, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Aut qui voluptatem dolores dignissimos animi odit.", new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5943), 6, new DateTime(2021, 6, 12, 16, 16, 25, 814, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 348, DateTimeKind.Local).AddTicks(3358), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/779.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(3942), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1168.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4006), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/837.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4047), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1221.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4086), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/406.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4125), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4405), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/762.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4449), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1107.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4490), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/102.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4529), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/752.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4568), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1155.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4607), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/175.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4646), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/480.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4685), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/871.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4724), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/229.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4763), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1227.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4802), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1187.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4841), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/388.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4880), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/182.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4919), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/114.jpg", new DateTime(2021, 6, 12, 16, 16, 25, 349, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(8958), "https://picsum.photos/640/480/?image=142", new DateTime(2021, 6, 12, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(385), "https://picsum.photos/640/480/?image=432", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(435), "https://picsum.photos/640/480/?image=675", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(477), "https://picsum.photos/640/480/?image=1044", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(519), "https://picsum.photos/640/480/?image=716", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(559), "https://picsum.photos/640/480/?image=544", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(599), "https://picsum.photos/640/480/?image=862", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(639), "https://picsum.photos/640/480/?image=450", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(678), "https://picsum.photos/640/480/?image=34", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(939), "https://picsum.photos/640/480/?image=667", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(983), "https://picsum.photos/640/480/?image=253", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1025), "https://picsum.photos/640/480/?image=731", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1067), "https://picsum.photos/640/480/?image=286", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1109), "https://picsum.photos/640/480/?image=577", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1150), "https://picsum.photos/640/480/?image=656", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1191), "https://picsum.photos/640/480/?image=568", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1232), "https://picsum.photos/640/480/?image=806", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1272), "https://picsum.photos/640/480/?image=1032", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1313), "https://picsum.photos/640/480/?image=183", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1355), "https://picsum.photos/640/480/?image=477", new DateTime(2021, 6, 12, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(2068), false, false, false, 7, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(2077), 21 },
                    { 1, new DateTime(2021, 6, 12, 16, 16, 25, 851, DateTimeKind.Local).AddTicks(8901), false, false, true, 1, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(26), 2 },
                    { 19, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(2016), false, false, false, 17, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(2023), 14 },
                    { 18, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1964), false, false, false, 20, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1972), 14 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1909), false, false, true, 4, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1918), 8 },
                    { 16, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1857), false, false, true, 1, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1864), 7 },
                    { 14, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1721), false, false, false, 10, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1729), 2 },
                    { 13, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1669), false, false, true, 13, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1676), 9 },
                    { 12, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1616), false, false, false, 13, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1625), 12 },
                    { 11, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1562), false, false, false, 4, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1570), 6 },
                    { 15, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1801), false, false, false, 19, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1809), 16 },
                    { 9, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1456), false, false, false, 17, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1463), 9 },
                    { 8, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1403), false, false, false, 6, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1411), 6 },
                    { 7, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1350), false, false, true, 14, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1357), 4 },
                    { 6, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1295), false, false, true, 16, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1303), 6 },
                    { 10, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1511), false, false, false, 20, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1518), 20 },
                    { 5, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1238), false, false, false, 17, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1245), 13 },
                    { 4, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1181), false, false, false, 7, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1188), 5 },
                    { 3, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1123), false, false, true, 4, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1131), 1 },
                    { 2, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1043), false, false, false, 8, new DateTime(2021, 6, 12, 16, 16, 25, 852, DateTimeKind.Local).AddTicks(1059), 16 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Ducimus voluptate consequuntur officiis quia.\nSequi ipsa soluta rem rem exercitationem reiciendis fuga provident.\nLaudantium tempora ipsum sint cum sunt dolor ipsum.\nAmet non quo fugiat nisi qui molestiae.", new DateTime(2021, 6, 12, 16, 16, 25, 797, DateTimeKind.Local).AddTicks(4413), 32, new DateTime(2021, 6, 12, 16, 16, 25, 797, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Quidem vero nam voluptatum omnis soluta voluptatem facere et.\nEt qui qui nostrum rerum quos qui.\nEa et a nemo eos distinctio dignissimos quia.\nVoluptas ipsa quo vel aperiam.", new DateTime(2021, 6, 12, 16, 16, 25, 797, DateTimeKind.Local).AddTicks(9168), 22, new DateTime(2021, 6, 12, 16, 16, 25, 797, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Dignissimos repudiandae velit harum quam et et. Necessitatibus eum illo aliquam itaque repellat dolores incidunt. Et sit quisquam consequatur doloremque omnis nisi qui impedit. Quisquam totam maxime totam laudantium sint maiores eos facere.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(2356), 40, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Rerum omnis dolorem veniam architecto odit.\nVoluptatem aut aliquam sit dolores et et esse.\nEt consequatur impedit ad recusandae.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(2925), 25, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Tenetur eos quod minima eum voluptatem sunt ut. Voluptatum est veritatis. Id architecto ea distinctio corrupti veniam ut et. Est reprehenderit aut amet eum delectus. Cumque voluptate repudiandae eligendi suscipit sequi at.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(3762), 32, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Voluptate esse odio itaque harum consequatur veritatis aut velit provident.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(5528), 32, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Laudantium dolores ut qui rerum et consequuntur nobis ea.\nVel consequatur esse.\nModi dolorem dolores veritatis commodi error.\nQuae temporibus possimus debitis consequuntur est.\nSit sed placeat veniam architecto praesentium est porro tempora.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(6473), 23, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Qui vitae et qui rerum.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(6757), 33, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Mollitia ut inventore quam quam ut. Occaecati excepturi impedit ea libero labore voluptatem. Nostrum tenetur voluptas molestias animi alias ad. Minima quisquam delectus et itaque ut deleniti quasi temporibus enim. Sequi sit sit ipsa enim consequatur quidem laborum.", new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(9780), 26, new DateTime(2021, 6, 12, 16, 16, 25, 798, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Unde quis aliquid optio necessitatibus totam odit ducimus voluptatem. Omnis cumque qui molestiae et veniam. Quidem sunt ex.", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(284), 32, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Dolores eos sapiente iure repellat aspernatur ea distinctio consequuntur quis.\nRerum repellendus sit voluptatem quia eius quo et.\nLaboriosam illum earum maiores.", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(595), 27, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "ut", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(1618), 35, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Vitae repellendus qui voluptas qui inventore voluptatem quis esse.", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(1891), 21, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "alias", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(1974), 28, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Ratione ex voluptas rerum accusantium.", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2087), 32, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "reiciendis", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2167), 22, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Vero doloribus officiis et alias temporibus doloribus et nesciunt sint. Eum corporis dolores rerum voluptatibus. Repellat est sunt natus repudiandae inventore necessitatibus illo numquam porro.", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2541), 23, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "error", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2651), 27, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "totam", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2725), 22, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Voluptatem vitae adipisci consequatur perspiciatis velit ut sit.\nRepellat consequuntur possimus enim et.\nEarum non voluptatibus placeat temporibus quasi.", new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(3019), 38, new DateTime(2021, 6, 12, 16, 16, 25, 799, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2021, 6, 12, 16, 16, 25, 442, DateTimeKind.Local).AddTicks(1971), "Sunny70@hotmail.com", "+HezI89i00p1jfZYAcqicc2hbsn8gWpdjXeQiA7O4tg=", "14Wx6TCxqRBk9455JEGtVwXpkUMIH86vEjgwYlBqX3g=", new DateTime(2021, 6, 12, 16, 16, 25, 442, DateTimeKind.Local).AddTicks(3282), "Ericka.Goyette" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 12, 16, 16, 25, 461, DateTimeKind.Local).AddTicks(1336), "Zoie_Connelly85@gmail.com", "wlPlYY9puRh2GjB/cADlr5dOTYmXHHj8rzFjB+aFWJ8=", "aIzZBl0b+wt6OIKKJqV6e3CK8bKNxtfAQNPgy8aBV04=", new DateTime(2021, 6, 12, 16, 16, 25, 461, DateTimeKind.Local).AddTicks(1480), "Selmer65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2021, 6, 12, 16, 16, 25, 474, DateTimeKind.Local).AddTicks(138), "Hermann_Cartwright@gmail.com", "MRXZJKyt1TGC7SxmvIJIVMZ+r2aHhY/tD9EostnafSQ=", "9Ca69VL0Zy9Kj7+pv63xL6xdsF7jTrSvRSTDKvtAQ3o=", new DateTime(2021, 6, 12, 16, 16, 25, 474, DateTimeKind.Local).AddTicks(270), "Alfred.Nader" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2021, 6, 12, 16, 16, 25, 486, DateTimeKind.Local).AddTicks(6505), "Isadore_Douglas@hotmail.com", "SJ3BPE/8SvS74QABXfsn4pU9Hb5ozOuS4VQuRGkeM9o=", "zM/XGfXcBAxQPjWLi+4TBHqsII/uaE9ndXQc89UY58Q=", new DateTime(2021, 6, 12, 16, 16, 25, 486, DateTimeKind.Local).AddTicks(6647), "Yvette_Adams" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 12, 16, 16, 25, 501, DateTimeKind.Local).AddTicks(1149), "Mallory_Mitchell@yahoo.com", "TwLsTYc8Fdrcj9g9HdzsDtIizPqVjCg7SYX26C94WP0=", "9Ph7J0UP8gQJMfJ94JJe0sD+3ElpTqG+gRCzW2XjyAY=", new DateTime(2021, 6, 12, 16, 16, 25, 501, DateTimeKind.Local).AddTicks(1288), "John_Wisoky" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2021, 6, 12, 16, 16, 25, 516, DateTimeKind.Local).AddTicks(2100), "Oliver38@hotmail.com", "oq4I4TLCDIU8G6AFpgA38crvj+fkduFz/6an9DTB2/Q=", "HsIeL1P5tzbwWnZrcgK+Hyw5uzncMz8VFyOrdX4JdFE=", new DateTime(2021, 6, 12, 16, 16, 25, 516, DateTimeKind.Local).AddTicks(2229), "Erna_Kuhn74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 12, 16, 16, 25, 528, DateTimeKind.Local).AddTicks(3588), "Gunnar_Abernathy@yahoo.com", "9wsSy+ecn6uukACZyeaKuJ2chREzgRdCJIqtBg77IjI=", "glHOB9tN5VeVJrhasOKa1E9SWQuhtZu/fw4O+aLrSUg=", new DateTime(2021, 6, 12, 16, 16, 25, 528, DateTimeKind.Local).AddTicks(3755), "Betty54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 6, 12, 16, 16, 25, 542, DateTimeKind.Local).AddTicks(5754), "Samanta_Padberg27@gmail.com", "fgUdr4+BmplVEAc1UXagi/dPwZjeR7YJdMQHOuolryU=", "W7y6GkBC5pLs8WIoBM7oaztHiIlJiJLmtqV/KurIe50=", new DateTime(2021, 6, 12, 16, 16, 25, 542, DateTimeKind.Local).AddTicks(5902), "Jadyn10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 6, 12, 16, 16, 25, 556, DateTimeKind.Local).AddTicks(5394), "Kelley_Koepp@hotmail.com", "Yq68QJobKL6+Y86eeoBoPX5NazAuKrn+MYnDL88aTJs=", "+dK/KcNLJpGKUynKu3pC+3ImvPlE6loKagKgg985Hnk=", new DateTime(2021, 6, 12, 16, 16, 25, 556, DateTimeKind.Local).AddTicks(5525), "Ubaldo.Hegmann76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 6, 12, 16, 16, 25, 573, DateTimeKind.Local).AddTicks(348), "Amira55@yahoo.com", "P2lOENxVM6VnnzJRm7jIxydvqqmHRU9ntHsKSkOD3Og=", "Y6M+k/rAZf1EFi8kW6QM7d6LcktTnlKcXvgao9k/tok=", new DateTime(2021, 6, 12, 16, 16, 25, 573, DateTimeKind.Local).AddTicks(497), "Zita_Dibbert0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2021, 6, 12, 16, 16, 25, 586, DateTimeKind.Local).AddTicks(8290), "Carolanne59@gmail.com", "kyLpUjwPC9Ij8DcZk4PQf2VOK2ocsqj886qLPCyIPwo=", "JAqr8KVDOlx4Omu1NUZxJKvKcgzOySk0f9LD40haUBE=", new DateTime(2021, 6, 12, 16, 16, 25, 586, DateTimeKind.Local).AddTicks(8522), "Tianna.Kuhlman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2021, 6, 12, 16, 16, 25, 598, DateTimeKind.Local).AddTicks(8421), "Sigurd.Lang@hotmail.com", "vm158B66IEjzE5EhtAKLlAtaW5fxXLvxQSkFg6vIjt4=", "JM3TfJ40kqr7Ta3v8GymVpna92rpdw4IubH6JG1FXts=", new DateTime(2021, 6, 12, 16, 16, 25, 598, DateTimeKind.Local).AddTicks(8558), "Jaime_Osinski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2021, 6, 12, 16, 16, 25, 618, DateTimeKind.Local).AddTicks(476), "Maximillian_Wilkinson46@gmail.com", "VIzB/+h2P8F3ANGGFyHfE06qEPhIpzOyII3RMWKOpF8=", "YQDD1H0erMEtbHyZ2QzhHJYVrjiMAvcG8xD+NnLvTIs=", new DateTime(2021, 6, 12, 16, 16, 25, 618, DateTimeKind.Local).AddTicks(619), "Adella.Zboncak" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2021, 6, 12, 16, 16, 25, 638, DateTimeKind.Local).AddTicks(739), "Elwin14@yahoo.com", "5F82wRvE0kYAMAfteu+WAhPyX7PAQUA1ZCyiJdAdZFc=", "UQi48bY8ozmrUIpXGhFOn0ZNDU3xrXuop4+Cp/gp8IE=", new DateTime(2021, 6, 12, 16, 16, 25, 638, DateTimeKind.Local).AddTicks(891), "Reba92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 6, 12, 16, 16, 25, 658, DateTimeKind.Local).AddTicks(634), "Elisha13@gmail.com", "9oVPRpa73YI39IOdaNoj0HMu9RWswYgjrC88UmZOqQc=", "2vA8sF8hddmdrh1mO36+oGN0EK0It+Q5Tmn7KYB9I+k=", new DateTime(2021, 6, 12, 16, 16, 25, 658, DateTimeKind.Local).AddTicks(815), "Keagan.Swaniawski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 6, 12, 16, 16, 25, 677, DateTimeKind.Local).AddTicks(209), "Armando_Torp85@hotmail.com", "2i7/v2Fj/OrqI4FWlor6cUVchykInYTOVfoP7nq5gBI=", "Tk5mkBfBjcBqOHwR2syJLduNtc6mRneovTW1CmTQGcc=", new DateTime(2021, 6, 12, 16, 16, 25, 677, DateTimeKind.Local).AddTicks(411), "Herbert51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2021, 6, 12, 16, 16, 25, 697, DateTimeKind.Local).AddTicks(811), "Joe_Bartell@yahoo.com", "L5NxMUNOOpUJnybzPbFsuZ22hT7XlQPgUbrm9zqH+4U=", "UlhLGiiopkFvp0sMTt9r0y3NhXReIihF6KuIZhkup7s=", new DateTime(2021, 6, 12, 16, 16, 25, 697, DateTimeKind.Local).AddTicks(989), "Mia89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2021, 6, 12, 16, 16, 25, 716, DateTimeKind.Local).AddTicks(9990), "Marcus.Jakubowski74@hotmail.com", "PNqQFw3G5YjJ6zDUwROk5db9MEsTfKIjofc8AL/3nfw=", "PBlQcWkNRZVbqd2kZX/SBUk9kY6Wgw3mE/VhXwI6zIQ=", new DateTime(2021, 6, 12, 16, 16, 25, 717, DateTimeKind.Local).AddTicks(159), "Orval32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2021, 6, 12, 16, 16, 25, 737, DateTimeKind.Local).AddTicks(9616), "Damian_Beier56@gmail.com", "aTeTOVBx3LAQgNQPzlPWESQbbCgQbOevkY0MLdB2XjI=", "+xIWBO/1I+BrubVGoX3GGds0bfJyKskcaGLrWNfP49A=", new DateTime(2021, 6, 12, 16, 16, 25, 737, DateTimeKind.Local).AddTicks(9861), "Randal2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 760, DateTimeKind.Local).AddTicks(7705), "Ashlee85@gmail.com", "80f1atewhQ0aVfdUVaiJaSpm9X4UOb/vKlLfrTXWWqU=", "9J9QICcQwMBmVGA0wPmQFhgRNfMlgWkbVbYHWKO8IDI=", new DateTime(2021, 6, 12, 16, 16, 25, 760, DateTimeKind.Local).AddTicks(7902), "Annabel25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 12, 16, 16, 25, 774, DateTimeKind.Local).AddTicks(5900), "mAjoIwmDI0k6VZYhNtisMyD7pxsInhxdEWsVxcWfPyA=", "EMEdLVHZL8YbhczTnaWk+SBVKJk6ngOruUk6J5lFTII=", new DateTime(2021, 6, 12, 16, 16, 25, 774, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_IsDeleted",
                table: "PostReactions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IsDeleted",
                table: "Comments",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_IsDeleted",
                table: "CommentReactions",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostReactions_IsDeleted",
                table: "PostReactions");

            migrationBuilder.DropIndex(
                name: "IX_Comments_IsDeleted",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_CommentReactions_IsDeleted",
                table: "CommentReactions");

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PostReactions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CommentReactions");

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsDislike", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 16, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(7285), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(8498), 6 },
                    { 18, 16, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1274), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1289), 21 },
                    { 17, 13, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1173), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1187), 3 },
                    { 15, 15, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(965), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(981), 8 },
                    { 14, 15, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(863), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(877), 20 },
                    { 13, 2, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(758), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(773), 12 },
                    { 12, 17, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(657), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(672), 15 },
                    { 11, 10, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(547), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(563), 21 },
                    { 19, 15, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1378), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1392), 16 },
                    { 10, 1, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(435), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(454), 9 },
                    { 8, 20, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(183), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(198), 12 },
                    { 7, 17, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(76), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(93), 12 },
                    { 6, 19, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9941), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9956), 3 },
                    { 5, 20, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9840), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9854), 14 },
                    { 4, 16, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9732), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9747), 3 },
                    { 3, 7, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9625), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9641), 18 },
                    { 2, 17, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9489), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 541, DateTimeKind.Local).AddTicks(9514), 7 },
                    { 9, 14, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(289), false, true, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(303), 17 },
                    { 20, 10, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1479), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1492), 19 },
                    { 16, 13, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1071), false, false, new DateTime(2021, 6, 11, 23, 26, 37, 542, DateTimeKind.Local).AddTicks(1086), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Assumenda laborum dolorem eum pariatur repellat quia.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(1337), 7, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quae dolorem expedita dolores consequatur qui eum incidunt.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(3647), 10, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Modi vel alias.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(3774), 3, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Eum amet porro voluptates est ut consectetur.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(3903), 5, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Similique iure voluptates esse temporibus beatae maiores.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4024), 10, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Iure enim voluptatum eum.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4256), 12, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Iste unde ut.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4460), 12, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Voluptate autem excepturi et autem quia ut laudantium.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4600), 12, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Voluptatem voluptas omnis illo minima ratione reprehenderit ipsa voluptas saepe.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4742), 11, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 21, "Necessitatibus similique ratione debitis harum repellendus perferendis in.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4864), new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Ipsa ad qui adipisci rerum numquam facere.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4975), 15, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Error et qui ut minima in voluptas.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5152), 6, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sed vero et id modi quia reprehenderit fugiat vel.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5293), 10, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Consectetur quaerat perferendis alias optio.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5396), 9, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Qui voluptatibus est.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5487), 7, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Voluptas et ex.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5581), 4, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Id vel ullam amet voluptatum.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5681), 20, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Dolorem et nulla adipisci aut quis.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5788), 12, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Minima nihil rerum est qui cumque eius vitae soluta velit.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5976), 18, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Deleniti asperiores vel quia ut vel.", new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(6095), 17, new DateTime(2021, 6, 11, 23, 26, 37, 501, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(1709), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/684.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9425), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/929.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9615), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1189.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9667), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1120.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9706), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1015.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9745), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/644.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9783), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/487.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9823), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/112.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9861), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1005.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9900), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/362.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9941), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/81.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9979), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/994.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 68, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(19), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/514.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(63), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/485.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(104), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/895.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(145), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/19.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(186), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/150.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(227), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/171.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(268), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/123.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(309), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/482.jpg", new DateTime(2021, 6, 11, 23, 26, 37, 69, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(6284), "https://picsum.photos/640/480/?image=198", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(7951), "https://picsum.photos/640/480/?image=743", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8000), "https://picsum.photos/640/480/?image=538", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8042), "https://picsum.photos/640/480/?image=542", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8083), "https://picsum.photos/640/480/?image=413", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8126), "https://picsum.photos/640/480/?image=394", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8170), "https://picsum.photos/640/480/?image=405", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8211), "https://picsum.photos/640/480/?image=788", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8252), "https://picsum.photos/640/480/?image=828", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8294), "https://picsum.photos/640/480/?image=745", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8334), "https://picsum.photos/640/480/?image=1069", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8374), "https://picsum.photos/640/480/?image=231", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8502), "https://picsum.photos/640/480/?image=2", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8555), "https://picsum.photos/640/480/?image=302", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8600), "https://picsum.photos/640/480/?image=29", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8643), "https://picsum.photos/640/480/?image=77", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8683), "https://picsum.photos/640/480/?image=893", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8725), "https://picsum.photos/640/480/?image=345", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8766), "https://picsum.photos/640/480/?image=883", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8806), "https://picsum.photos/640/480/?image=1008", new DateTime(2021, 6, 11, 23, 26, 37, 79, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7850), false, true, 19, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7864), 7 },
                    { 1, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(3205), false, false, 5, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(4545), 21 },
                    { 19, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7765), false, false, 14, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7779), 16 },
                    { 18, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7676), false, false, 18, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7688), 6 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7589), false, true, 14, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7603), 18 },
                    { 16, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7497), false, true, 9, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7511), 12 },
                    { 14, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7314), false, true, 11, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7328), 2 },
                    { 13, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7223), false, true, 18, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7237), 17 },
                    { 12, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7128), false, true, 15, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7142), 16 },
                    { 11, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7037), false, false, 13, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7052), 20 },
                    { 15, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7408), false, false, 8, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(7421), 8 },
                    { 9, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6851), false, false, 9, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6864), 8 },
                    { 8, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6758), false, false, 17, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6772), 7 },
                    { 7, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6659), false, true, 3, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6676), 2 },
                    { 6, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6556), false, false, 12, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6571), 12 },
                    { 10, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6945), false, false, 19, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6959), 18 },
                    { 5, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6457), false, false, 14, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6471), 2 },
                    { 4, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6355), false, true, 16, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6369), 16 },
                    { 3, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6246), false, true, 1, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6264), 13 },
                    { 2, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6022), false, false, 5, new DateTime(2021, 6, 11, 23, 26, 37, 514, DateTimeKind.Local).AddTicks(6053), 7 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Necessitatibus reiciendis debitis. Ipsa iusto quis. Quo id blanditiis saepe fuga molestiae.", new DateTime(2021, 6, 11, 23, 26, 37, 485, DateTimeKind.Local).AddTicks(8598), 26, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "soluta", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(2717), 28, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "explicabo", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(3004), 36, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Suscipit dolorem nemo non maiores et autem consectetur autem ut. Omnis sit reiciendis corrupti. Amet suscipit quo assumenda quia non sequi facere qui qui. Vero quibusdam velit et sed qui et hic dolore. Non rem et dolore id blanditiis.", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(4936), 33, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Tempore ipsum deserunt cum incidunt dolorem. Quia perferendis iste possimus sed autem occaecati reprehenderit. In beatae voluptas occaecati accusantium labore sint. Eos totam occaecati rem possimus molestias rerum unde.", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(5690), 22, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "fuga", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(5968), 33, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Dolorem incidunt pariatur est itaque ducimus qui nisi eos. Qui in vero consequatur. Expedita recusandae vel omnis corporis quaerat. Molestias laborum quia praesentium sit. Assumenda maiores non consectetur cumque.", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(6699), 35, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "libero", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(6886), 38, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "autem", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(7034), 23, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Aut eius explicabo placeat.", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(8920), 40, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Quia sint praesentium.", new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(9199), 35, new DateTime(2021, 6, 11, 23, 26, 37, 486, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Reprehenderit sunt officiis.\nUt officiis aut.\nMolestiae maiores quae necessitatibus.\nExcepturi magni rem dolore in ut et ut.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1117), 32, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Et vel tempora quod veniam et voluptatem ducimus ut.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1565), 28, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "tempora", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1751), 34, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "non", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1892), 27, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Vel iure doloribus voluptatum quo sit.\nAut consequatur est natus.\nRem dolores aut nihil.\nOmnis qui dignissimos voluptas.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(3133), 23, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Quisquam dolores eos.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(3472), 27, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Nobis similique voluptas facere aut. Maiores non voluptatem officia dolor laudantium doloremque. Id modi molestias dolor. Ut quae ut cumque vel perspiciatis. Fugit velit aspernatur in unde a.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(4222), 38, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Libero laboriosam a. Incidunt qui occaecati autem voluptatibus doloribus occaecati provident. Autem vitae eum dolor corporis qui et doloremque non ut. Temporibus fugit dignissimos ipsa qui officia. Esse tempore dolor voluptas. Voluptatum nesciunt illum quisquam dolor sit natus rem mollitia.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(7804), 34, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Explicabo omnis facilis veritatis perferendis blanditiis doloribus. Tenetur sed autem deleniti ut qui. Aut vero minus tenetur labore voluptates fuga atque quam. Aut est debitis aut quia non distinctio sunt.", new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(8314), 25, new DateTime(2021, 6, 11, 23, 26, 37, 487, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2021, 6, 11, 23, 26, 37, 157, DateTimeKind.Local).AddTicks(6064), "Myra_Wilkinson38@gmail.com", "S5AE3lv1qBSHNqH68peolLqSkWgt/FnhCkZaVABW8pc=", "aIVA6vcRE6wcGYKH0BBD/rsHF6BwUISNEoyFsbk40fE=", new DateTime(2021, 6, 11, 23, 26, 37, 157, DateTimeKind.Local).AddTicks(7195), "Arely.Schmeler15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2021, 6, 11, 23, 26, 37, 170, DateTimeKind.Local).AddTicks(5679), "Gerhard34@gmail.com", "ht4qejvoIf/5CW8SR97aSSgEBkFV0/BXrKcflyiESzA=", "5Qlf2VqUavYfobjGtpS/ybeMmjIvTlyUE7/MMFjkJTw=", new DateTime(2021, 6, 11, 23, 26, 37, 170, DateTimeKind.Local).AddTicks(5808), "Claudine16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 6, 11, 23, 26, 37, 183, DateTimeKind.Local).AddTicks(4402), "Armando.Hermann@yahoo.com", "aVyzlxC3p1lmAQrZ8Zbx819UbvMUEAQvSbL8d3PLkN4=", "5TZuCdiqSAU9CbFTZ9yBc5cBEOHRTfeycbw2WM/qbBU=", new DateTime(2021, 6, 11, 23, 26, 37, 183, DateTimeKind.Local).AddTicks(4553), "Assunta60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2021, 6, 11, 23, 26, 37, 197, DateTimeKind.Local).AddTicks(1493), "Thea_Streich93@hotmail.com", "edW0BE4dnwwGBH2bV6oa2V65ItD+MWIEh4tHNHrNv+k=", "hF7K/dNS7HJ+DqUkj8+w1HZIY5Kh7ZKgvzYkObn/5qQ=", new DateTime(2021, 6, 11, 23, 26, 37, 197, DateTimeKind.Local).AddTicks(1644), "Adolph2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 6, 11, 23, 26, 37, 210, DateTimeKind.Local).AddTicks(4822), "Bret80@hotmail.com", "0abRPv5sjIu/TPfVRNq8X89lDO1ZeDsa9MlgSXZKoUk=", "WivnnGD0ZiYriJAsNCFgN+6d87ceVPqUb5Vy6qXFV1g=", new DateTime(2021, 6, 11, 23, 26, 37, 210, DateTimeKind.Local).AddTicks(4946), "Jayson12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2021, 6, 11, 23, 26, 37, 223, DateTimeKind.Local).AddTicks(1051), "Eldora68@gmail.com", "LTX2Jst1K9gpK96+iTRgdDOtKagOQXMbuXByB5xgI3k=", "8bYl3Y6jlv0at3UU+bpF7MHyw0GyGpOZ+OMw0owqRBE=", new DateTime(2021, 6, 11, 23, 26, 37, 223, DateTimeKind.Local).AddTicks(1208), "Maximilian.Kemmer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 6, 11, 23, 26, 37, 237, DateTimeKind.Local).AddTicks(8051), "Jade46@gmail.com", "MCBdu7JHMUgBelf4hm+3d8iA5G5mNvCRTpWCxvvPTDA=", "4y/CUaJpN19jh5sIL1pGJXg34/wCxgcuYAQpgfKyvT0=", new DateTime(2021, 6, 11, 23, 26, 37, 237, DateTimeKind.Local).AddTicks(8188), "Ford_Bednar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 6, 11, 23, 26, 37, 252, DateTimeKind.Local).AddTicks(3186), "Hazel63@yahoo.com", "I3rLjlSyjcZZ/c/1bkpkQnrWF6+DOZh61OJAYAmf8cs=", "U5Xz3HC1Hf6VKd8WaijNFa9EpGhvkGeMge2WmsX3ZnY=", new DateTime(2021, 6, 11, 23, 26, 37, 252, DateTimeKind.Local).AddTicks(3318), "Verna.Fahey10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2021, 6, 11, 23, 26, 37, 266, DateTimeKind.Local).AddTicks(2843), "Garnet.Leuschke@gmail.com", "VSLnGqSYoMzVw+JaEsGiaBqUaIaQxz9LwZ+mB7L8OUI=", "T6t/ZoYTDIDt0yAwQQNURB9wajzFWY2v1mph/y13R90=", new DateTime(2021, 6, 11, 23, 26, 37, 266, DateTimeKind.Local).AddTicks(2984), "Emie_Schumm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 6, 11, 23, 26, 37, 278, DateTimeKind.Local).AddTicks(1747), "Vince.Emard@gmail.com", "EFvsMqL+p7J9+GDJCllCj2IXOrsgemqKE9vXdbYFXJ4=", "kiswa/2nOYl9juCx9TBpQb9HvCto9hCynldxZWsuh0c=", new DateTime(2021, 6, 11, 23, 26, 37, 278, DateTimeKind.Local).AddTicks(1874), "Albin_Reichel68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 6, 11, 23, 26, 37, 291, DateTimeKind.Local).AddTicks(3327), "Johnny95@hotmail.com", "AW1QgAU4o08X9qHyTIjn8wk9X347pKXiIyLqRdCyekQ=", "NZOt7BHdieryGeBa+Wy/oYZdamrSuikEiR5pYo7KlpQ=", new DateTime(2021, 6, 11, 23, 26, 37, 291, DateTimeKind.Local).AddTicks(3453), "Cleo47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2021, 6, 11, 23, 26, 37, 308, DateTimeKind.Local).AddTicks(4423), "Gunner90@yahoo.com", "GpCpPd4hLe3P3zmulEzT5UQzAYddZgt9I5DyeQ+NbAI=", "ppFqBVwBR92hi4zPlcei9jDPWDoyUPCoySVXVSG0ReU=", new DateTime(2021, 6, 11, 23, 26, 37, 308, DateTimeKind.Local).AddTicks(4567), "Jarrett.Tremblay" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 6, 11, 23, 26, 37, 324, DateTimeKind.Local).AddTicks(6346), "Reuben.Cremin18@yahoo.com", "mKNwfwcXsczpaCZDw7VLeh5cViy+DqLPPQpf3ZkdZIs=", "mzobJ3hHLcXa31nO14020jjZbV9KJJzfVjaSTwb9ZXQ=", new DateTime(2021, 6, 11, 23, 26, 37, 324, DateTimeKind.Local).AddTicks(6468), "Ashlynn_Kovacek8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 6, 11, 23, 26, 37, 341, DateTimeKind.Local).AddTicks(6203), "Malvina_Prosacco@gmail.com", "JS1dAFOdT6DAiPiO/zHgowfga5sj22VHcnobQWvAAh8=", "UnBiVsbEzWrQTiz2Yidnz9ErqugE+EvC4x5ARxd8cZw=", new DateTime(2021, 6, 11, 23, 26, 37, 341, DateTimeKind.Local).AddTicks(6351), "Timothy_Thiel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2021, 6, 11, 23, 26, 37, 356, DateTimeKind.Local).AddTicks(3663), "Benjamin_Purdy96@gmail.com", "WA4qQIbr/rh3W+ibpxPr4vYDayMWt6eKKT7spdPSNJw=", "6CPqYdQJ7x+Jvur/rrV4OOd2p/njyN/Ye1M3nbCG6BI=", new DateTime(2021, 6, 11, 23, 26, 37, 356, DateTimeKind.Local).AddTicks(3807), "Zola_Hills" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 6, 11, 23, 26, 37, 373, DateTimeKind.Local).AddTicks(3332), "Noemie2@hotmail.com", "pFK5q5O1WwfQc+fPVyCBbLCGriwVrLDXoCBLS8b57C0=", "itmyj1QagDanx91avTWImRBAwx3pTkEcO3Oherb0aiw=", new DateTime(2021, 6, 11, 23, 26, 37, 373, DateTimeKind.Local).AddTicks(3489), "Isaac37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 6, 11, 23, 26, 37, 390, DateTimeKind.Local).AddTicks(4398), "Roma.Pollich55@yahoo.com", "qKE0RCf8T2/PckuB+Q/WA3twaw9WG2roLkv/w17U02s=", "AAzVLPy+2pIlVt23uCUFWQ1X+LYxS5WnyLUkng1O6AY=", new DateTime(2021, 6, 11, 23, 26, 37, 390, DateTimeKind.Local).AddTicks(4565), "Rickey.Windler99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2021, 6, 11, 23, 26, 37, 405, DateTimeKind.Local).AddTicks(743), "Tony28@hotmail.com", "gs9Py7zbqnoUbNQQrkjKMVk0noiW9Lzpz4BdcYDrRJM=", "bBwo2cB7h5bpdOiDFKXAiLLmCVBATkRnxlTGK1XViVc=", new DateTime(2021, 6, 11, 23, 26, 37, 405, DateTimeKind.Local).AddTicks(902), "Wilhelmine71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2021, 6, 11, 23, 26, 37, 416, DateTimeKind.Local).AddTicks(9685), "Blair_Adams@yahoo.com", "aWVbpt9SZa20o+zvNKm2cFzenExaO0RvzH2gvg9dZe4=", "r5eqm0ezjeyK4KG4+R4XVGf9u7aXjATPYrRy5ie+9dg=", new DateTime(2021, 6, 11, 23, 26, 37, 416, DateTimeKind.Local).AddTicks(9869), "Arden.Homenick" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 433, DateTimeKind.Local).AddTicks(9115), "Rhoda.Thiel@yahoo.com", "VeOF/6GvcwGi+Bzlc2SSl6GgkIXDeTdfM2PMGYUu5tE=", "M8//Bo+SRASFfdK8chNQguDIdjm5e1dXcfXc9AlCTrY=", new DateTime(2021, 6, 11, 23, 26, 37, 433, DateTimeKind.Local).AddTicks(9328), "Winona.Bergnaum5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 11, 23, 26, 37, 455, DateTimeKind.Local).AddTicks(3901), "46kuwM2FmD0Ls7xkvKeluRq43mEqM0NpZRzsCnLEkVI=", "FaxMNHVYAnEZinbGfN5Z+D5OJyh/i6mszAgs/ElUDys=", new DateTime(2021, 6, 11, 23, 26, 37, 455, DateTimeKind.Local).AddTicks(3901) });
        }
    }
}
