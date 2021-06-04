using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class AddDislikes : Migration
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
                name: "IsDislike",
                table: "PostReactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDislike",
                table: "CommentReactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsDislike", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2021, 6, 4, 13, 11, 13, 215, DateTimeKind.Local).AddTicks(7327), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 215, DateTimeKind.Local).AddTicks(8850), 5 },
                    { 18, 6, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1099), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1107), 17 },
                    { 17, 8, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1041), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1050), 18 },
                    { 15, 4, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(928), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(936), 10 },
                    { 14, 11, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(870), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(879), 5 },
                    { 13, 15, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(813), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(822), 20 },
                    { 12, 10, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(755), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(764), 19 },
                    { 11, 17, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(695), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(704), 12 },
                    { 19, 4, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1156), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1165), 9 },
                    { 10, 12, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(633), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(642), 18 },
                    { 8, 2, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(262), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(271), 1 },
                    { 7, 2, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(203), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(212), 5 },
                    { 6, 2, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(144), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(152), 11 },
                    { 5, 8, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(82), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(91), 10 },
                    { 4, 16, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(20), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(29), 1 },
                    { 3, 14, new DateTime(2021, 6, 4, 13, 11, 13, 215, DateTimeKind.Local).AddTicks(9952), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 215, DateTimeKind.Local).AddTicks(9961), 16 },
                    { 2, 15, new DateTime(2021, 6, 4, 13, 11, 13, 215, DateTimeKind.Local).AddTicks(9869), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 215, DateTimeKind.Local).AddTicks(9884), 7 },
                    { 9, 5, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(554), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(569), 2 },
                    { 20, 6, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1214), false, true, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(1223), 4 },
                    { 16, 6, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(985), false, false, new DateTime(2021, 6, 4, 13, 11, 13, 216, DateTimeKind.Local).AddTicks(994), 18 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Repudiandae quisquam sunt tempore vel in.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(3777), 19, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Esse repellendus sunt et cupiditate ipsum consequatur eos earum possimus.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(7128), 9, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Repellendus qui dolor debitis voluptate explicabo quia ipsa.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(7516), 8, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Commodi ea vitae eum sed ut voluptatum necessitatibus.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(7870), 17, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Non voluptatibus in ducimus rem accusamus.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(8323), 20, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Labore veritatis voluptatem recusandae placeat dolores et dolorem.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(8664), new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Delectus et qui perspiciatis quia sunt dolorum animi tempore minima.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(9004), 6, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Reprehenderit exercitationem velit corporis a dolorum laboriosam nostrum atque.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(9336), 11, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Qui ratione harum ipsa assumenda.", new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(9587), 17, new DateTime(2021, 6, 4, 13, 11, 13, 181, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Debitis molestiae explicabo nesciunt doloremque voluptas.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(107), 5, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Exercitationem qui saepe est.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(390), 11, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Exercitationem adipisci quia quam quis et.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(638), 17, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Dolore voluptatibus earum doloribus iste.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(860), 20, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Et tenetur delectus velit ipsa enim.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1103), 5, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Dolores consectetur quia.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1311), 11, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Id dolor maxime sunt aspernatur et illo modi.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1564), 6, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Repellendus ut odio aliquam mollitia iure deleniti qui voluptates.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1963), 12, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Aliquam molestiae culpa dolor veniam.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(2225), 6, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Optio quisquam enim laboriosam vel vel suscipit accusamus.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(2483), 17, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Sit voluptates velit atque veniam et fugiat ut.", new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(2753), 14, new DateTime(2021, 6, 4, 13, 11, 13, 182, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 714, DateTimeKind.Local).AddTicks(6305), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/43.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 715, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 715, DateTimeKind.Local).AddTicks(9982), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/271.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(116), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1128.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(187), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/907.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(256), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/384.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(577), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/381.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(695), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/773.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(769), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/178.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(842), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1152.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(926), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/416.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1002), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/659.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1071), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/514.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1135), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/872.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1201), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/415.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1271), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/727.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1338), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/820.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1607), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/607.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1731), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/735.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1810), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1208.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1888), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/393.jpg", new DateTime(2021, 6, 4, 13, 11, 12, 716, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 727, DateTimeKind.Local).AddTicks(9897), "https://picsum.photos/640/480/?image=606", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2164), "https://picsum.photos/640/480/?image=516", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2256), "https://picsum.photos/640/480/?image=116", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2341), "https://picsum.photos/640/480/?image=523", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2592), "https://picsum.photos/640/480/?image=914", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2687), "https://picsum.photos/640/480/?image=96", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2766), "https://picsum.photos/640/480/?image=424", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2847), "https://picsum.photos/640/480/?image=1046", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2924), "https://picsum.photos/640/480/?image=674", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3003), "https://picsum.photos/640/480/?image=819", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3080), "https://picsum.photos/640/480/?image=823", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3162), "https://picsum.photos/640/480/?image=615", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3240), "https://picsum.photos/640/480/?image=363", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3317), "https://picsum.photos/640/480/?image=552", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3394), "https://picsum.photos/640/480/?image=531", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3471), "https://picsum.photos/640/480/?image=456", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3548), "https://picsum.photos/640/480/?image=536", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3859), "https://picsum.photos/640/480/?image=478", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3968), "https://picsum.photos/640/480/?image=908", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(4046), "https://picsum.photos/640/480/?image=490", new DateTime(2021, 6, 4, 13, 11, 12, 728, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3730), false, true, 12, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3738), 10 },
                    { 1, new DateTime(2021, 6, 4, 13, 11, 13, 199, DateTimeKind.Local).AddTicks(9428), false, true, 5, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(1178), 13 },
                    { 19, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3672), false, true, 11, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3681), 19 },
                    { 18, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3612), false, true, 15, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3622), 16 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3553), false, true, 14, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3561), 5 },
                    { 16, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3494), false, true, 1, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3503), 6 },
                    { 14, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3304), false, true, 7, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3312), 15 },
                    { 13, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3246), false, true, 18, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3255), 7 },
                    { 12, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3185), false, false, 3, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3196), 10 },
                    { 11, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3126), false, true, 10, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3135), 21 },
                    { 15, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3429), false, false, 1, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3440), 1 },
                    { 9, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3009), false, false, 2, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3018), 8 },
                    { 8, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2951), false, true, 15, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2959), 3 },
                    { 7, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2892), false, false, 13, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2901), 2 },
                    { 6, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2832), false, true, 9, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2841), 3 },
                    { 10, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3069), false, true, 8, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(3077), 7 },
                    { 5, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2771), false, false, 2, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2779), 4 },
                    { 4, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2706), false, false, 14, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2715), 15 },
                    { 3, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2641), false, false, 6, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2650), 11 },
                    { 2, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2548), false, true, 10, new DateTime(2021, 6, 4, 13, 11, 13, 200, DateTimeKind.Local).AddTicks(2565), 20 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "veritatis", new DateTime(2021, 6, 4, 13, 11, 13, 151, DateTimeKind.Local).AddTicks(8301), 24, new DateTime(2021, 6, 4, 13, 11, 13, 151, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { "rerum", new DateTime(2021, 6, 4, 13, 11, 13, 152, DateTimeKind.Local).AddTicks(1388), new DateTime(2021, 6, 4, 13, 11, 13, 152, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Aut est ratione perspiciatis et.\nDoloremque et totam dolores minus.\nId vel voluptatem et mollitia aut sed voluptatibus.", new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(238), 32, new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "quas", new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(814), 26, new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Optio atque corrupti magni vel.\nDistinctio id enim nesciunt aut ducimus neque doloribus velit.\nLaboriosam in rerum explicabo quaerat accusamus.\nQuos minima impedit ipsum voluptatum rerum ad consectetur.\nDolorem ex assumenda aut dolore deserunt modi id corrupti.\nQuis pariatur odit.", new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(4805), 31, new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Non nulla sunt. Consequatur eum illum asperiores pariatur tempore id sit sapiente. Delectus magnam minima. Eius consectetur tempora maxime ex laboriosam id incidunt qui. Iure quod enim voluptatem perspiciatis laborum nisi nisi amet. Ut earum consectetur aliquam quod omnis.", new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(9883), 40, new DateTime(2021, 6, 4, 13, 11, 13, 161, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "magnam", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(44), 38, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Et quod et amet quos ut neque.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(1620), 36, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "est", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(1894), 23, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Aliquid eligendi dolorum et aut praesentium minima repellat.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(2237), 40, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Ipsum sit non provident atque. Eligendi et consequatur nesciunt at tenetur ut sunt. Consectetur facilis harum consectetur quo tempore impedit natus. Temporibus autem magni aliquid maxime.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(2777), 37, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Id voluptates quasi architecto fuga rerum mollitia fugiat ut.\nAssumenda fugit facilis rerum culpa aut voluptas.\nLaborum et et praesentium est.\nMaxime aut officia laboriosam inventore voluptatibus aut neque.\nQuis ut temporibus.\nSimilique aut unde.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(3372), 23, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "accusantium", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(3477), 30, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Earum et illum beatae quaerat labore qui eos ea.\nExcepturi illo aliquam omnis natus.\nEst illo ad repudiandae autem soluta possimus.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(3955), 28, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 6, "Maxime dolorem quasi eum laboriosam.\nSed atque sequi vitae et magni eum.\nPorro labore et dolores eos inventore est laudantium.\nDolorum qui sit reiciendis quaerat quod praesentium perferendis maxime ducimus.\nReprehenderit ut quaerat magni quo est distinctio beatae ea.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(4826), new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "dicta", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(4974), 23, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Et minus nobis minima minima qui non.\nOfficia vero quod.\nQuasi illo nobis reiciendis quaerat deleniti voluptatibus quis.\nQuia in provident veritatis consequatur consequatur nemo et quo.\nModi id ducimus explicabo porro.\nAut a aut velit.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(5518), 35, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Blanditiis velit praesentium aut aut atque ut corrupti. Deleniti suscipit sequi eius voluptates dicta dolorum voluptas facere. Occaecati sunt dolorum sapiente delectus illum voluptatem. Quia ipsum beatae beatae mollitia adipisci aliquid.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(5983), 39, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Consequatur soluta sed nam laborum eum aut necessitatibus ab quisquam. Earum ut ut vel et fugiat labore. Nostrum minus sapiente consequatur ipsam impedit.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(6407), 29, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Sint est et autem possimus voluptas aut a ut qui. Quaerat voluptatum qui deserunt dolores qui ea eum id. Recusandae ex voluptas. Pariatur ipsam aut tenetur. Facilis ab voluptatem ab. Consequatur enim omnis deleniti aut rerum officiis necessitatibus et.", new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(8202), 30, new DateTime(2021, 6, 4, 13, 11, 13, 162, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 6, 4, 13, 11, 12, 819, DateTimeKind.Local).AddTicks(5778), "Giles44@hotmail.com", "bGTU9cfFGKFL0Mr2Ls+FRh0LRDseI1FrILR9st8KBN0=", "0dzkZa1JZCSRhPgpHwOqSRXR1JTcCyP+eRgNV3EZ8tI=", new DateTime(2021, 6, 4, 13, 11, 12, 819, DateTimeKind.Local).AddTicks(7736), "Darian34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2021, 6, 4, 13, 11, 12, 833, DateTimeKind.Local).AddTicks(6038), "Caterina.Runolfsdottir91@gmail.com", "W8NJodxQHTnmQ9SEsA6Hh6G9u1S3t0Jx8yEbDmMPAYM=", "iX05cBqoMl5Y+yHQyqXi26lwGITJyECgdru07Bboong=", new DateTime(2021, 6, 4, 13, 11, 12, 833, DateTimeKind.Local).AddTicks(6176), "Carrie_Bayer8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 6, 4, 13, 11, 12, 847, DateTimeKind.Local).AddTicks(9743), "Kaley40@yahoo.com", "10LChylrSrQ79XACRC65k563tJW1BeLs2dwKU7Ouylk=", "zyw5Qbw9t7NMpJ+aAcCNPcUalN3jgjqQysc+xiteXx4=", new DateTime(2021, 6, 4, 13, 11, 12, 847, DateTimeKind.Local).AddTicks(9879), "Wilson29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2021, 6, 4, 13, 11, 12, 864, DateTimeKind.Local).AddTicks(1749), "Tomasa.Schumm54@yahoo.com", "wdmT6fe+kxzdd+SIT+AKcbmXY8mm9fWh5cgibvN0g3E=", "mGdeaJdFTj3zFRTXe2fWx3a36oi03Rh8xHpERU6/5n4=", new DateTime(2021, 6, 4, 13, 11, 12, 864, DateTimeKind.Local).AddTicks(1880), "Torey86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 6, 4, 13, 11, 12, 882, DateTimeKind.Local).AddTicks(4408), "Sigurd.Kunze@gmail.com", "IoZbuf6ClVb0PxEiXHIYTiV31sO/fNwi3+DKJ4ONsso=", "/8EYyaUEKGpUXeLqo29W8Xrb1ESQLNkxJXtM6a6C1vU=", new DateTime(2021, 6, 4, 13, 11, 12, 882, DateTimeKind.Local).AddTicks(4566), "Frederik.Herman36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 12, 898, DateTimeKind.Local).AddTicks(6462), "Rodrick_West@yahoo.com", "u4FRzYTitnB7+zFtSUG50gXVA2mT9d7sFkGooO5MCEo=", "0jfS1vuk3A0vM0mTd5dn13046JN3SH6WlEhkuD8XpGQ=", new DateTime(2021, 6, 4, 13, 11, 12, 898, DateTimeKind.Local).AddTicks(6610), "Trycia61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 6, 4, 13, 11, 12, 910, DateTimeKind.Local).AddTicks(4652), "Arielle64@gmail.com", "LXJP/X5BWaYjXFjvmaHKXqxMnCqD0RTa4MvqKdx05kw=", "qzJKLsC6fiMcqFe4e31CdbYUBxlA1joTDu43wa0aldQ=", new DateTime(2021, 6, 4, 13, 11, 12, 910, DateTimeKind.Local).AddTicks(4787), "Halle.Balistreri4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 4, 13, 11, 12, 924, DateTimeKind.Local).AddTicks(9565), "Tre79@yahoo.com", "1gJ8qKILjfvmvqwie1jgSmUIK3iwbO12Qzc8GUWieFM=", "4zhP59OaEF+SZW+KDf3vxSnc4hDobWJ26kMRZd92CGs=", new DateTime(2021, 6, 4, 13, 11, 12, 924, DateTimeKind.Local).AddTicks(9694), "Beatrice.Padberg18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2021, 6, 4, 13, 11, 12, 942, DateTimeKind.Local).AddTicks(3875), "Theron26@yahoo.com", "l3eZrhLdOc3Rd5J8XyOJJpWN5ucAUsPNj1WOjQsuMhg=", "rHts3ZsXt2nIvXQgC71fYqKVlPZLZEnVr1O5RDoliJY=", new DateTime(2021, 6, 4, 13, 11, 12, 942, DateTimeKind.Local).AddTicks(4027), "Delia18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 6, 4, 13, 11, 12, 956, DateTimeKind.Local).AddTicks(7519), "Crystel30@gmail.com", "T0Q0q32/IBRs9LWYRC87YMjhYaDk2BxXSmmKNRz0Saw=", "k//3zbGQWtJqQRdHXk9ulbqS9kIv2bjWimf08ui+nMs=", new DateTime(2021, 6, 4, 13, 11, 12, 956, DateTimeKind.Local).AddTicks(7647), "Jamaal97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2021, 6, 4, 13, 11, 12, 969, DateTimeKind.Local).AddTicks(7553), "Cody_Turcotte@yahoo.com", "egGQ5DezPHZ30ORhplwqUOUWKXvNbM1jtHTGRXu+iX8=", "G7npn5ptkL5J8U2OXypmNiLuYLfSKsCJ/Nq+QNC9Lj0=", new DateTime(2021, 6, 4, 13, 11, 12, 969, DateTimeKind.Local).AddTicks(7704), "Clyde.Rohan31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 6, 4, 13, 11, 12, 981, DateTimeKind.Local).AddTicks(4040), "Breana_Koss@gmail.com", "z2+XaJfVE8N2gxFHRtZZKeb4kfPkHxGx8+fInGxhtco=", "LkVR8MKHoGAyyPT9WwuG1HEqevqugw06VKx5Z5HqZEk=", new DateTime(2021, 6, 4, 13, 11, 12, 981, DateTimeKind.Local).AddTicks(4191), "Baby.Mann42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 6, 4, 13, 11, 12, 995, DateTimeKind.Local).AddTicks(9001), "Prudence76@yahoo.com", "13LiukA+R+Ev2KvavOjeKV9bkhi0NXpxJBUH+xctVyQ=", "u2dbwqAn1V7fcfv/woWs2ZJ9mvMFuQy8mtUJ27a6HqI=", new DateTime(2021, 6, 4, 13, 11, 12, 995, DateTimeKind.Local).AddTicks(9134), "Elmira_Bogan91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2021, 6, 4, 13, 11, 13, 19, DateTimeKind.Local).AddTicks(1559), "Norwood.Crooks@hotmail.com", "o/WO8niYhLtuhjZvhHPQOv/7IVheZxSXnbl6R4Ok4UE=", "ErYKGbCDDAqkA3bC4mqQDUOzk7xsSwlbJibKLkARvsc=", new DateTime(2021, 6, 4, 13, 11, 13, 19, DateTimeKind.Local).AddTicks(1686), "Kayley.OConnell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2021, 6, 4, 13, 11, 13, 32, DateTimeKind.Local).AddTicks(7924), "Dixie.Kutch@yahoo.com", "6j5/IajUZkejL/tC4237Fe6g28rHLvnqHKaar8sAfPY=", "kq0iAT8gze/5dMy/dPeMS1Jv7UUBY2DlXwn8g3MbYXU=", new DateTime(2021, 6, 4, 13, 11, 13, 32, DateTimeKind.Local).AddTicks(8050), "Karl.Daugherty48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2021, 6, 4, 13, 11, 13, 46, DateTimeKind.Local).AddTicks(2424), "Piper_Romaguera6@gmail.com", "rpJjTdhtgBj2Vi2rhg0QxF1kLfx6C3MLFBcLkfZTL5s=", "8u9WILwmUgcsqdMnmRFvaV6Nq5ThzdZ/fLj1jcezr8g=", new DateTime(2021, 6, 4, 13, 11, 13, 46, DateTimeKind.Local).AddTicks(2575), "Alexandra_Ortiz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2021, 6, 4, 13, 11, 13, 61, DateTimeKind.Local).AddTicks(8350), "Otha23@hotmail.com", "w5dffNLAwrXTH/SATkwNRIoOBRvoZsblJUvkPmesfaI=", "a4FNOnGq+goXpR9aNPLE1gfMGHbiQ75ONZfNjV8gd8g=", new DateTime(2021, 6, 4, 13, 11, 13, 61, DateTimeKind.Local).AddTicks(8496), "Linnie_Ziemann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2021, 6, 4, 13, 11, 13, 78, DateTimeKind.Local).AddTicks(9177), "Zachary_Daugherty6@gmail.com", "0YarHEvV57cN9TlaN+mFh5zQ0ZnwZStX5zapq2C6qH4=", "20YTIJIofO1ZdcoRguq4n2D6vNGP6NkSNhNrngNoPc4=", new DateTime(2021, 6, 4, 13, 11, 13, 78, DateTimeKind.Local).AddTicks(9327), "Valerie.Feeney" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 6, 4, 13, 11, 13, 95, DateTimeKind.Local).AddTicks(3391), "Alva.Daugherty@yahoo.com", "SFReEAAHppEoP1O7VWXLht9p9o2dNcaTUi9bwvSrHac=", "de8PfLSdQ62mSj0nbgQEOKJljkC4b/LHRoPWoYyO2uw=", new DateTime(2021, 6, 4, 13, 11, 13, 95, DateTimeKind.Local).AddTicks(3535), "Guy.Monahan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 6, 4, 13, 11, 13, 113, DateTimeKind.Local).AddTicks(8572), "Jacynthe82@yahoo.com", "kCbtKbdSFzARnFd/3ZP28iN7psz+51GjzuTwqU0jfQw=", "3CuRpGlzGiJaQq1Wv6JowmWz2iqC7/4E2qm/uOWX2kQ=", new DateTime(2021, 6, 4, 13, 11, 13, 113, DateTimeKind.Local).AddTicks(8700), "Haylie_Homenick" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 11, 13, 128, DateTimeKind.Local).AddTicks(5419), "P0CiN0wQ3qMRDF0KSKCq+AnpJtpM4Hz2jY+NUV/qLRE=", "SeHiMl5lTfaUfjnoFIGtW/eUVeAksnI7IQyfdfUWeyI=", new DateTime(2021, 6, 4, 13, 11, 13, 128, DateTimeKind.Local).AddTicks(5419) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDislike",
                table: "PostReactions");

            migrationBuilder.DropColumn(
                name: "IsDislike",
                table: "CommentReactions");

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(450), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(2421), 15 },
                    { 18, 20, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5350), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5363), 10 },
                    { 17, 19, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5268), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5279), 6 },
                    { 15, 15, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5110), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5121), 14 },
                    { 14, 6, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5024), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5037), 10 },
                    { 13, 10, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4943), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4955), 20 },
                    { 12, 3, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4864), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4875), 5 },
                    { 11, 2, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4785), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4797), 18 },
                    { 19, 2, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5433), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5445), 4 },
                    { 10, 13, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4703), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4716), 17 },
                    { 8, 19, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4538), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4552), 13 },
                    { 7, 12, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4453), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4467), 1 },
                    { 6, 6, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4362), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4374), 4 },
                    { 5, 6, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4278), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4290), 15 },
                    { 4, 4, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4191), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4202), 5 },
                    { 3, 3, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4061), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4074), 10 },
                    { 2, 5, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(3940), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(3963), 21 },
                    { 9, 10, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4621), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4633), 9 },
                    { 20, 12, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5513), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5524), 8 },
                    { 16, 3, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5190), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5201), 21 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Voluptas eos amet et nihil omnis cum ut voluptatem.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(4079), 10, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Illo beatae voluptates est.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8348), 4, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Quos incidunt voluptatem.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8570), 20, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Earum nostrum harum eos et.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8734), 11, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Qui voluptas est aut illo quasi consequatur.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8907), 10, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 14, "Laudantium nam est eos architecto et explicabo doloribus.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9098), new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Dolorum et commodi.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9370), 12, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Corrupti quae eaque cupiditate aperiam hic.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9585), 7, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Modi quas et beatae alias consectetur assumenda rem aperiam.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9781), 13, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Eius eum assumenda excepturi et et totam aut quo.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1), 18, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Officia occaecati aliquam nihil sequi molestiae.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(182), 3, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Voluptatem culpa officia molestiae similique qui ut at qui.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(379), 19, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Soluta ut numquam enim perferendis autem voluptatem aut numquam eaque.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(786), 13, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Quos deleniti recusandae ut voluptatem est culpa.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(993), 20, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Magnam dolor officia tempore architecto similique quaerat sunt asperiores rerum.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1210), 19, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Ipsa voluptatem eos harum error.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1501), 13, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Cum sapiente laboriosam beatae magnam.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1833), 11, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Quisquam ut corrupti optio quis delectus explicabo molestiae sed.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(2118), 11, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Laudantium et soluta vitae culpa tempora saepe adipisci sit aut.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(2302), 10, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Laborum sunt eius dolore mollitia dolorem.", new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(2456), 16, new DateTime(2021, 6, 4, 10, 51, 20, 606, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 993, DateTimeKind.Local).AddTicks(1557), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/832.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(4919), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5059), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/477.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5127), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/649.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5194), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1033.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5264), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/567.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5337), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1174.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5410), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/840.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5483), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/564.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5598), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/580.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5667), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/643.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5733), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/265.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5798), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1050.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5863), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/771.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5934), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/425.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6001), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/122.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6072), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1023.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6146), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/837.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6218), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/843.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6291), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1218.jpg", new DateTime(2021, 6, 4, 10, 51, 19, 994, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(677), "https://picsum.photos/640/480/?image=1027", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3254), "https://picsum.photos/640/480/?image=401", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3366), "https://picsum.photos/640/480/?image=688", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3444), "https://picsum.photos/640/480/?image=191", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3528), "https://picsum.photos/640/480/?image=556", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3613), "https://picsum.photos/640/480/?image=945", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3703), "https://picsum.photos/640/480/?image=948", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7407), "https://picsum.photos/640/480/?image=620", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7523), "https://picsum.photos/640/480/?image=988", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7590), "https://picsum.photos/640/480/?image=509", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7692), "https://picsum.photos/640/480/?image=964", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7778), "https://picsum.photos/640/480/?image=991", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7856), "https://picsum.photos/640/480/?image=955", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7933), "https://picsum.photos/640/480/?image=736", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8009), "https://picsum.photos/640/480/?image=775", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8077), "https://picsum.photos/640/480/?image=114", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8154), "https://picsum.photos/640/480/?image=270", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8233), "https://picsum.photos/640/480/?image=672", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8313), "https://picsum.photos/640/480/?image=570", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8392), "https://picsum.photos/640/480/?image=463", new DateTime(2021, 6, 4, 10, 51, 20, 9, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1620), true, 18, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1636), 1 },
                    { 1, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(5496), false, 13, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(7712), 6 },
                    { 19, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1512), true, 11, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1528), 3 },
                    { 18, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1383), true, 11, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1398), 17 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1273), false, 20, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1288), 20 },
                    { 16, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1154), true, 16, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(1177), 16 },
                    { 14, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(798), true, 3, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(816), 18 },
                    { 13, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(699), true, 8, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(713), 2 },
                    { 12, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(600), true, 13, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(615), 15 },
                    { 11, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(503), false, 19, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(517), 6 },
                    { 15, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(898), true, 11, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(911), 10 },
                    { 9, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(309), true, 16, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(324), 7 },
                    { 8, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(209), false, 7, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(223), 16 },
                    { 7, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(112), true, 7, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(126), 2 },
                    { 6, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(10), true, 10, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(25), 6 },
                    { 10, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(408), true, 4, new DateTime(2021, 6, 4, 10, 51, 20, 631, DateTimeKind.Local).AddTicks(423), 19 },
                    { 5, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9914), false, 16, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9928), 18 },
                    { 4, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9814), false, 10, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9829), 11 },
                    { 3, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9711), true, 15, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9726), 2 },
                    { 2, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9542), true, 18, new DateTime(2021, 6, 4, 10, 51, 20, 630, DateTimeKind.Local).AddTicks(9581), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "ea", new DateTime(2021, 6, 4, 10, 51, 20, 571, DateTimeKind.Local).AddTicks(6610), 38, new DateTime(2021, 6, 4, 10, 51, 20, 571, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Consectetur aspernatur et ut rerum voluptas quasi ut molestias.", new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(4795), new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Cupiditate optio voluptas est similique sint velit.", new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(6119), 40, new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "ea", new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(6344), 25, new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Fuga dolores perferendis nam omnis sapiente quia accusantium. Necessitatibus quia aut aut ut quia fugiat dolore veritatis magnam. Reprehenderit quo sit quis. Debitis necessitatibus dicta eos. Quo repellendus velit eius aut sapiente tempore vel eos. Sunt illum libero cum maxime modi rerum.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(2444), 27, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Qui nobis quis repudiandae.\nFacilis odio rerum architecto.\nRerum numquam dolor.\nOmnis aut sunt dolore nesciunt iusto.\nEst et in quae.\nFuga alias doloribus iste veniam laborum consequatur sed.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(6312), 22, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Accusantium autem reiciendis corrupti provident non qui et ex. Alias labore iste consequatur cupiditate aut. Et quo accusamus. Sit iusto saepe sint facere ad voluptate. Sit voluptatem tenetur quia qui dolores inventore modi. Vitae est mollitia voluptatem.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(7224), 26, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Et quis error perferendis ducimus eius aut minima. Itaque vitae aut. Et ipsa eos accusantium amet ab sed odit ut. Placeat nulla maiores veritatis enim commodi.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(8014), 35, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Aperiam quia beatae. Illum minus voluptatem ipsum magni. Qui modi corporis.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(8430), 40, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Consequatur earum velit et.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(8674), 21, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Sequi eum repudiandae quaerat ab dolor. Placeat et et dolor impedit quis ipsam aspernatur recusandae. Laboriosam est dolorum.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(9450), 34, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Occaecati sapiente repellat velit accusantium ullam voluptatem.\nEx in consectetur aliquam.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(9804), 38, new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Autem et molestias sed repellat fuga aut. Ut atque quia omnis dolor dicta odit voluptas. Provident numquam omnis suscipit deserunt fuga occaecati similique perferendis. Et soluta ut ut facilis ipsum consequuntur eligendi.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(457), 22, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Eveniet minus quia vel inventore. In corrupti dicta esse fugit sed placeat. Eius repellendus consequatur doloribus ut voluptatibus aut adipisci. Libero eius natus. Et qui perferendis ad autem aut.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(1142), 38, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 21, "Laudantium reiciendis odio aliquam qui ut sed qui eveniet.\nEt et dicta culpa asperiores ut.\nCumque qui qui deserunt dolores quia.\nSunt quasi eos quia non accusamus autem et ipsam adipisci.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(1633), new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Id unde corrupti nam aut placeat.\nNon optio quibusdam rem nihil dolor.\nPerferendis eius delectus assumenda occaecati neque placeat consequuntur quibusdam.\nDoloremque impedit nostrum deserunt.\nIllo consequatur repellat eum voluptas asperiores ut odit eum voluptas.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(2481), 24, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "dignissimos", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(2684), 31, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Quod ullam aut natus modi voluptatem laudantium.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(3046), 33, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Quia praesentium eveniet aperiam facilis temporibus rem mollitia. Aut aut aut dolores dignissimos ut error id nobis. Ratione culpa explicabo unde nostrum. Quos repellendus reiciendis commodi cumque eum voluptatem qui adipisci sequi.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(3535), 35, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "quibusdam", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(3814), 35, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 4, 10, 51, 20, 130, DateTimeKind.Local).AddTicks(8011), "Talon71@gmail.com", "TCOSYbZK0h/j/7Bxil1iipS2YsirCC7f7eQvWrIDejM=", "Rf46XRfv9MS+fegU7NyAeEWs4orqHT6bAXvPQDtlu3I=", new DateTime(2021, 6, 4, 10, 51, 20, 131, DateTimeKind.Local).AddTicks(272), "Cheyenne.Ryan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2021, 6, 4, 10, 51, 20, 150, DateTimeKind.Local).AddTicks(3017), "Celia95@hotmail.com", "volK6ocRq5rbgk6X9mdqVMjwRDyU/WQTZ2SOsM0D0Yg=", "IuADl9ufwa7Ejsw88opZeoAmrSP6m/PpFwoy/7bOpho=", new DateTime(2021, 6, 4, 10, 51, 20, 150, DateTimeKind.Local).AddTicks(3174), "Rosetta24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 6, 4, 10, 51, 20, 171, DateTimeKind.Local).AddTicks(5365), "Candelario.Kshlerin51@gmail.com", "KsBLCCIiUSxx4Gh7/EPLFC/5gDQ0sD1MysiTJG1fJCw=", "Q14OIS+Rb5cc571eRqWhIbuAlkj4r9AN2to64je3uLQ=", new DateTime(2021, 6, 4, 10, 51, 20, 171, DateTimeKind.Local).AddTicks(5511), "Keely_Vandervort" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 4, 10, 51, 20, 202, DateTimeKind.Local).AddTicks(5610), "Gregorio26@yahoo.com", "b6fnj+BI7597xyxpvPcvbH2CBlS/Oo+KuIBYiu1EfFM=", "QNwHPI3i9lpvDaXq4GJYiYgs2gulsxlAntr+fTF9CQw=", new DateTime(2021, 6, 4, 10, 51, 20, 202, DateTimeKind.Local).AddTicks(5761), "Zander_Kub58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 6, 4, 10, 51, 20, 217, DateTimeKind.Local).AddTicks(6821), "Kennedy.Stark66@hotmail.com", "nJ/LGLSYuHotiW7h1FsOHqN29cBnUZAMbFJuyN588jY=", "gp+lc8gesI/29RQLs5UsHYW6cz5MDyHW5CLkxUHVz20=", new DateTime(2021, 6, 4, 10, 51, 20, 217, DateTimeKind.Local).AddTicks(6950), "Callie48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 229, DateTimeKind.Local).AddTicks(9988), "Emie_Padberg67@yahoo.com", "86v1OeQqxzwb1Cr/av+ffxchqLD5r3vZUiPM8O2kYjo=", "t+GzFx4mRH3BHF3N7G566zxNZo9UERzNjlrFsWJgFSk=", new DateTime(2021, 6, 4, 10, 51, 20, 230, DateTimeKind.Local).AddTicks(125), "Juston37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 6, 4, 10, 51, 20, 242, DateTimeKind.Local).AddTicks(520), "Corine51@gmail.com", "rfJ24youUfh74FOKHzleuCm1Hh5rzwsbynbIN1J+KSQ=", "1PFAbAy/pTnNckhgx3mKUE9fyYw6Y/9lkq4Kffi3iP4=", new DateTime(2021, 6, 4, 10, 51, 20, 242, DateTimeKind.Local).AddTicks(652), "Tracey.Boyer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2021, 6, 4, 10, 51, 20, 255, DateTimeKind.Local).AddTicks(9171), "Johan_Gusikowski39@gmail.com", "fUpEzWbZHOHy3TxIEjsgz29B3j/sYzFRBGY2kjaX3KA=", "/MtXtwrxvQ6xrOmTS/VyCtq2W694Oq0Zl+nPFYO7mX8=", new DateTime(2021, 6, 4, 10, 51, 20, 255, DateTimeKind.Local).AddTicks(9318), "Brielle.Brown" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 6, 4, 10, 51, 20, 273, DateTimeKind.Local).AddTicks(9041), "Antonina.Turner@yahoo.com", "dv/m5G6w0nPN4UJnWtMnn2alNZA4H6H/dKthCzBjl+A=", "Co+7w67D6CwBK1N13AO0KU4hE2HZvF1Lhlq/jgWwAwc=", new DateTime(2021, 6, 4, 10, 51, 20, 273, DateTimeKind.Local).AddTicks(9197), "Ashtyn_Blanda49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 6, 4, 10, 51, 20, 290, DateTimeKind.Local).AddTicks(5534), "Ignacio_Nikolaus@gmail.com", "R8sSbusycZNRPMUnLTWCTXHuNbSQP/Gi6U32jxNeJh8=", "YlPjSbaYPgFb4NFGVA3eFUetLEJeXR/2qUo6DYxuloM=", new DateTime(2021, 6, 4, 10, 51, 20, 290, DateTimeKind.Local).AddTicks(5679), "Lizeth_Quitzon" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 6, 4, 10, 51, 20, 309, DateTimeKind.Local).AddTicks(4117), "Janessa.Ernser@yahoo.com", "AlVA5VoBeiFvVlfsCvBfxGesdczn7CpFeWkI0v0wU+4=", "OnJGrlI4q2exzyeFMd2k8ZFdN9FDADzB/6NcqOz8vCM=", new DateTime(2021, 6, 4, 10, 51, 20, 309, DateTimeKind.Local).AddTicks(4264), "Jarrell28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2021, 6, 4, 10, 51, 20, 329, DateTimeKind.Local).AddTicks(4276), "Fredy25@yahoo.com", "lDODMBemV/9CR5qfd8As4WdAGeIz2HscFeIAh1g9G1M=", "8xjv9IEGITySdXc4KF0oh20MwGLKpEsebzy2SZM6yAg=", new DateTime(2021, 6, 4, 10, 51, 20, 329, DateTimeKind.Local).AddTicks(4453), "Elmer_Connelly79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 6, 4, 10, 51, 20, 347, DateTimeKind.Local).AddTicks(1225), "Justyn87@hotmail.com", "rIQBtjvByHYEhuScfTOZnFbPpAlW7AJ3prNgjvyrijc=", "v3wDNh/MdjLLZ+fXiFBSOuDTSmpTGfJp0IXT0eZyTX4=", new DateTime(2021, 6, 4, 10, 51, 20, 347, DateTimeKind.Local).AddTicks(1389), "Guiseppe.Maggio28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 6, 4, 10, 51, 20, 364, DateTimeKind.Local).AddTicks(2271), "Delpha_Treutel@hotmail.com", "ZLUoT+YpCS327CAkU0Bek3Oya3Ygmpwt2B/sq6TdNMk=", "CBtjoJ988sewDNtfIGtPXhfy2wDdjXkUcxB/TjJVIBQ=", new DateTime(2021, 6, 4, 10, 51, 20, 364, DateTimeKind.Local).AddTicks(2438), "Gavin.Bins19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 6, 4, 10, 51, 20, 381, DateTimeKind.Local).AddTicks(7796), "Stone_Miller94@yahoo.com", "YMj2TxJsTYlZ+uHHl7p7WSwX0IaqZglsLYaYEzvGu9o=", "3Zjj2SXQCwfkvo15qIkvv1hIz2lDtYPKlrhck6FdZeM=", new DateTime(2021, 6, 4, 10, 51, 20, 381, DateTimeKind.Local).AddTicks(8024), "Chris44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2021, 6, 4, 10, 51, 20, 405, DateTimeKind.Local).AddTicks(6280), "Deontae_Harris46@gmail.com", "5aY0vhWy/SuXgHB92SWCgRWxaC7n+tPKBS0IVkptqX4=", "b1jqe3gMFXHKHMgN3373qjk8Jzb7SmehxIwjk+MKggk=", new DateTime(2021, 6, 4, 10, 51, 20, 405, DateTimeKind.Local).AddTicks(6456), "Kaela_Langosh" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 6, 4, 10, 51, 20, 424, DateTimeKind.Local).AddTicks(3289), "Janae_Ryan96@yahoo.com", "fYaasPcSAn+wh4ILRH7VwThBWAARc9XmLq3z8XcsJKA=", "Ago5aX0SyfYt3EWPXycjvP5eIly8r0qf4yfbg4JGOEM=", new DateTime(2021, 6, 4, 10, 51, 20, 424, DateTimeKind.Local).AddTicks(3472), "Magdalen_Gaylord39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2021, 6, 4, 10, 51, 20, 444, DateTimeKind.Local).AddTicks(5220), "Kayden_Leffler45@gmail.com", "r/4lfZLa9ScAd0I6cNi7Pp6dNX9EvpOKBbM6udx55qE=", "26yi1o8O6I1gP2kgco/oJPlkaQk/rExcERA78Mo+GLE=", new DateTime(2021, 6, 4, 10, 51, 20, 444, DateTimeKind.Local).AddTicks(5401), "Clemens85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2021, 6, 4, 10, 51, 20, 462, DateTimeKind.Local).AddTicks(8079), "Rubye.Witting89@yahoo.com", "dZdEQqUcpeu37QP84/Gp6qUCTf+72ce5a15QEhERPW8=", "v6oT+nHjCFkEtgqUr+VvItCJf01xW2fvT2Me2FQ/p+4=", new DateTime(2021, 6, 4, 10, 51, 20, 462, DateTimeKind.Local).AddTicks(8246), "Lenna14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2021, 6, 4, 10, 51, 20, 501, DateTimeKind.Local).AddTicks(8825), "Thea_Romaguera98@hotmail.com", "mER/rfqlIOnh5PCuKJPUDhyWWVgrLSxhWwzOnFDAjL8=", "kFM3mFxXGDp80/xzTO1/YBWL1AvniR5YJDB83d8Bsdc=", new DateTime(2021, 6, 4, 10, 51, 20, 501, DateTimeKind.Local).AddTicks(8998), "Deangelo_Zboncak87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 520, DateTimeKind.Local).AddTicks(7089), "hMYeteBbrjBNhRD8HL+Aozk+hE7TwpfypX8R1tpXtdc=", "E5oNxCS5Nxp5F1SyDghP/5bZzsIdHxjv58/YnK1HP6U=", new DateTime(2021, 6, 4, 10, 51, 20, 520, DateTimeKind.Local).AddTicks(7089) });
        }
    }
}
