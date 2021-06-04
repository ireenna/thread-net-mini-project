using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class SomeMigration : Migration
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
                keyValue: 15);

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

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5024), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5190), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 15, 15, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5110), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5121), 14 },
                    { 18, 20, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5350), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5363), 10 },
                    { 17, 19, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5268), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5279), 6 },
                    { 13, 10, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4943), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4955), 20 },
                    { 12, 3, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4864), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4875), 5 },
                    { 11, 2, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4785), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4797), 18 },
                    { 10, 13, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4703), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4716), 17 },
                    { 19, 2, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5433), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5445), 4 },
                    { 9, 10, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4621), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4633), 9 },
                    { 7, 12, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4453), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4467), 1 },
                    { 6, 6, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4362), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4374), 4 },
                    { 5, 6, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4278), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4290), 15 },
                    { 4, 4, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4191), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4202), 5 },
                    { 3, 3, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4061), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4074), 10 },
                    { 2, 5, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(3940), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(3963), 21 },
                    { 1, 4, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(450), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(2421), 15 },
                    { 8, 19, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4538), false, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(4552), 13 },
                    { 20, 12, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5513), true, new DateTime(2021, 6, 4, 10, 51, 20, 648, DateTimeKind.Local).AddTicks(5524), 8 }
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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Laudantium nam est eos architecto et explicabo doloribus.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9098), 15, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9116) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Modi quas et beatae alias consectetur assumenda rem aperiam.", new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9781), 13, new DateTime(2021, 6, 4, 10, 51, 20, 605, DateTimeKind.Local).AddTicks(9801) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "ea", new DateTime(2021, 6, 4, 10, 51, 20, 571, DateTimeKind.Local).AddTicks(6610), 38, new DateTime(2021, 6, 4, 10, 51, 20, 571, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 15, "Consectetur aspernatur et ut rerum voluptas quasi ut molestias.", new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(4795), new DateTime(2021, 6, 4, 10, 51, 20, 582, DateTimeKind.Local).AddTicks(4953) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 17, "Fuga dolores perferendis nam omnis sapiente quia accusantium. Necessitatibus quia aut aut ut quia fugiat dolore veritatis magnam. Reprehenderit quo sit quis. Debitis necessitatibus dicta eos. Quo repellendus velit eius aut sapiente tempore vel eos. Sunt illum libero cum maxime modi rerum.", new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(2444), new DateTime(2021, 6, 4, 10, 51, 20, 584, DateTimeKind.Local).AddTicks(2583) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Laudantium reiciendis odio aliquam qui ut sed qui eveniet.\nEt et dicta culpa asperiores ut.\nCumque qui qui deserunt dolores quia.\nSunt quasi eos quia non accusamus autem et ipsam adipisci.", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(1633), 31, new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(1660) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "dignissimos", new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(2684), new DateTime(2021, 6, 4, 10, 51, 20, 585, DateTimeKind.Local).AddTicks(2706) });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2021, 6, 4, 10, 51, 20, 229, DateTimeKind.Local).AddTicks(9988), "Emie_Padberg67@yahoo.com", "86v1OeQqxzwb1Cr/av+ffxchqLD5r3vZUiPM8O2kYjo=", "t+GzFx4mRH3BHF3N7G566zxNZo9UERzNjlrFsWJgFSk=", new DateTime(2021, 6, 4, 10, 51, 20, 230, DateTimeKind.Local).AddTicks(125), "Juston37" });

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
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 51, 20, 273, DateTimeKind.Local).AddTicks(9041), "Antonina.Turner@yahoo.com", "dv/m5G6w0nPN4UJnWtMnn2alNZA4H6H/dKthCzBjl+A=", "Co+7w67D6CwBK1N13AO0KU4hE2HZvF1Lhlq/jgWwAwc=", new DateTime(2021, 6, 4, 10, 51, 20, 273, DateTimeKind.Local).AddTicks(9197), "Ashtyn_Blanda49" });

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
                keyValue: 15);

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

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5438), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5502), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 15, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5470), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5476), 14 },
                    { 18, 15, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5568), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5573), 3 },
                    { 17, 20, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5536), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5541), 16 },
                    { 13, 18, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5405), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5411), 3 },
                    { 12, 2, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5372), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5378), 1 },
                    { 11, 12, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5340), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5345), 13 },
                    { 10, 16, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5307), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5313), 1 },
                    { 19, 16, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5599), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5605), 21 },
                    { 9, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5274), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5280), 20 },
                    { 7, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5209), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5215), 17 },
                    { 6, 4, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5176), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5182), 7 },
                    { 5, 19, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5131), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5139), 21 },
                    { 4, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4985), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4996), 12 },
                    { 3, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4924), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4934), 6 },
                    { 2, 11, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4838), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4856), 1 },
                    { 1, 4, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(3131), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4182), 8 },
                    { 8, 14, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5242), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5247), 13 },
                    { 20, 2, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5630), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5635), 17 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Quo sunt necessitatibus impedit nobis repellendus voluptatem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(5039), 6, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Mollitia et exercitationem aliquam animi iusto est cupiditate.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6984), 13, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Porro nobis error.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7091), 14, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "A aliquid quia distinctio enim dolorem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7193), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Sit ut harum minus atque quidem molestias sint consectetur.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7306), 5, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Sapiente inventore nostrum.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7383), 5, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Blanditiis sed ea quia.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7628), 20, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Et dignissimos ut eaque voluptas labore.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7731), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Aliquam aut saepe ipsum consequuntur totam quia ipsum autem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7842), 10, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Asperiores nostrum doloremque animi et.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7989), 16, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Esse vero officia.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8068), 7, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Adipisci ut voluptatum eos accusamus dolor.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8164), 4, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sit dolorem aperiam alias maiores voluptates ut hic enim.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8356), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Voluptatem itaque iusto.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8438), 11, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Consequuntur ea qui cupiditate quaerat.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8528), 15, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Libero eligendi excepturi est veniam.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8622), 17, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Pariatur et aperiam eligendi et explicabo.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8713), 19, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Aut sed nisi ipsa animi.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8855), 13, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Repudiandae pariatur eum voluptate expedita.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8949), 4, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Quo et ut odio ut.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(9135), 17, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(1845), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1081.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8310), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8352), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1199.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8377), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/36.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8401), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/488.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8497), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/210.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8526), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1032.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8551), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/4.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8574), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1002.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8598), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/298.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8621), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/60.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8644), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8669), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8693), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/813.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8716), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/965.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8740), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1187.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8763), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/443.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8787), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/857.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8810), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/885.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8833), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/898.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(2515), "https://picsum.photos/640/480/?image=34", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3959), "https://picsum.photos/640/480/?image=210", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4108), "https://picsum.photos/640/480/?image=938", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4141), "https://picsum.photos/640/480/?image=582", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4167), "https://picsum.photos/640/480/?image=200", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4192), "https://picsum.photos/640/480/?image=556", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4217), "https://picsum.photos/640/480/?image=895", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4243), "https://picsum.photos/640/480/?image=501", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4268), "https://picsum.photos/640/480/?image=779", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4292), "https://picsum.photos/640/480/?image=971", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4316), "https://picsum.photos/640/480/?image=677", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4340), "https://picsum.photos/640/480/?image=987", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4365), "https://picsum.photos/640/480/?image=842", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4390), "https://picsum.photos/640/480/?image=127", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4415), "https://picsum.photos/640/480/?image=312", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4480), "https://picsum.photos/640/480/?image=122", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4509), "https://picsum.photos/640/480/?image=416", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4534), "https://picsum.photos/640/480/?image=127", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4558), "https://picsum.photos/640/480/?image=49", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4582), "https://picsum.photos/640/480/?image=579", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9811), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9817), 11 },
                    { 1, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(7499), true, 2, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(8513), 14 },
                    { 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9779), true, 12, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9784), 7 },
                    { 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9744), false, 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9750), 2 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9713), true, 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9718), 4 },
                    { 16, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9681), false, 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9686), 12 },
                    { 14, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9616), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9621), 10 },
                    { 13, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9582), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9588), 1 },
                    { 12, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9551), true, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9556), 2 },
                    { 11, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9520), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9525), 16 },
                    { 15, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9649), false, 9, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9654), 20 },
                    { 9, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9452), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9457), 18 },
                    { 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9417), false, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9423), 2 },
                    { 7, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9383), true, 10, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9389), 8 },
                    { 6, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9350), true, 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9355), 14 },
                    { 10, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9487), true, 13, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9492), 18 },
                    { 5, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9315), false, 5, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9321), 8 },
                    { 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9281), true, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9287), 6 },
                    { 3, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9248), true, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9254), 1 },
                    { 2, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9192), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9203), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Ipsa laborum accusantium saepe. Sed numquam sit inventore beatae cumque voluptas et dignissimos voluptates. Earum expedita numquam harum quo voluptatem velit.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(1719), 40, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 18, "mollitia", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4623), new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "voluptatum", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4872), 31, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Ut eaque aut sunt occaecati autem. Rerum qui neque in in. Quia ullam fugiat optio unde ex dolor velit quasi unde. Id id ea reiciendis id sit blanditiis assumenda quisquam. Doloribus et est quia fugit ipsa.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5624), 38, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 19, "Adipisci provident cumque repellendus facilis qui quia quos. Ipsa rem corrupti ut corrupti repellendus et qui eaque sapiente. Et soluta dolores magni qui sit in iusto.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5977), new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Inventore voluptate quia distinctio consectetur. Commodi dolores minima omnis velit occaecati esse esse quidem voluptas. Quos occaecati at deleniti dicta sint aperiam. Reprehenderit laudantium et rerum dolor ab amet.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6354), 25, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "beatae", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6426), 32, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "vitae", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6487), 32, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Dicta est reiciendis voluptas earum odit cumque in suscipit in.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(7857), 38, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Et dolores sed. Aspernatur est modi nemo. Labore natus placeat quo quis.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8160), 29, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Hic a velit optio corporis dolor voluptatum. At illum labore quia sit voluptate soluta ea. Voluptatum voluptatem aliquam dolor eos corporis soluta. Eum ex et aut eveniet qui ut. Veniam modi magni iure.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8574), 36, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Quasi quis quos illo aperiam autem nisi.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8727), 24, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Atque et dicta et minus ipsum et. Laborum ut tenetur tempore ut aut. Sit unde perferendis temporibus distinctio at quidem aut quos vel. Quos consequatur aut impedit tempora ab ea vel. At dolores deleniti expedita et saepe ipsa consequatur provident. Illum repellendus veritatis rem neque est.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1049), 38, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "quod", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1193), 37, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Soluta repudiandae velit.\nIpsam ut enim necessitatibus eius ab quae quasi ex neque.\nConsequatur et in architecto repellat voluptas molestiae provident pariatur.\nEx doloribus et.\nEt non ut quidem iste hic reiciendis et.\nNumquam excepturi quas.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(2954), 38, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Sed sint eveniet.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3100), 28, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 18, "maxime", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3161), new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Vel error aut sapiente.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3249), 39, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "ipsam", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3302), 31, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Numquam temporibus dolor non commodi error quos earum officia.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3511), 23, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 5, 20, 11, 13, 14, 826, DateTimeKind.Local).AddTicks(488), "Murray_Schuster79@gmail.com", "acAJ53wZsq31VAb6cMXgUfIax6/m7Y0/RHnoJEnMYEg=", "Rcm3LnHPlpiN5J9LLJYTd0PcilyDDnVc6Nswoyo47j0=", new DateTime(2021, 5, 20, 11, 13, 14, 826, DateTimeKind.Local).AddTicks(1583), "Titus_Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2021, 5, 20, 11, 13, 14, 837, DateTimeKind.Local).AddTicks(138), "Dave79@yahoo.com", "d32nF9qsABrvxMVc32IrJVyR99sYzoFWb8KMrKJtcBo=", "tKnkVn1ZFt/SZzKzklyEc3+JSjAszT7v5RMwkfSSA6I=", new DateTime(2021, 5, 20, 11, 13, 14, 837, DateTimeKind.Local).AddTicks(212), "Al_Raynor" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 5, 20, 11, 13, 14, 846, DateTimeKind.Local).AddTicks(7785), "Kendrick_Emmerich13@gmail.com", "hwaghCHm2/1iUok1aCOO6BLTATiQihj5O2AH/ftjbRE=", "+uJsbanlGIkilFjT1yEIO2jLY+GJdMK/HVrxnuwP6i8=", new DateTime(2021, 5, 20, 11, 13, 14, 846, DateTimeKind.Local).AddTicks(7817), "Lenore16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2021, 5, 20, 11, 13, 14, 856, DateTimeKind.Local).AddTicks(5118), "Lelia_Wintheiser@gmail.com", "NT0Ru66Nr2SQMOYwTg7h8HFDkbhZSGnjrOhfKMCK/VY=", "bRn9pW/8YH842PoDeaPqCJs4ZzFupb6KLJ5cFgWvvXI=", new DateTime(2021, 5, 20, 11, 13, 14, 856, DateTimeKind.Local).AddTicks(5182), "Lionel74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2021, 5, 20, 11, 13, 14, 866, DateTimeKind.Local).AddTicks(1579), "Shanna.Wolf62@yahoo.com", "xB+JebeSFso9LfB1R0QWq2UD0oOg7UGYMRPoyZ6i77Y=", "mXrPmUfK+EPvjzmLLdmoZE3H6a37OmSXuCK1tH6cFso=", new DateTime(2021, 5, 20, 11, 13, 14, 866, DateTimeKind.Local).AddTicks(1657), "Natasha_Watsica1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 5, 20, 11, 13, 14, 875, DateTimeKind.Local).AddTicks(6521), "Emil_Moen50@gmail.com", "Wgxx1H7JzjFDpm110weZvqoahZTXgr7Qe3b5WgxraQk=", "gohkEBKxAZWAwYeggEMnkbA6CM7XnSMXVBfwN82C910=", new DateTime(2021, 5, 20, 11, 13, 14, 875, DateTimeKind.Local).AddTicks(6589), "Jennifer45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2021, 5, 20, 11, 13, 14, 885, DateTimeKind.Local).AddTicks(1450), "Kaleb27@hotmail.com", "J1uf9/PUNeKVrn7jF/Yq7m+0EwZADBlvR+cV+rtcxZQ=", "ySLHbl4+0zW3baq+7fkLbdh9zsJFD7CH2FXuO9SBx58=", new DateTime(2021, 5, 20, 11, 13, 14, 885, DateTimeKind.Local).AddTicks(1515), "Hunter.Kemmer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 5, 20, 11, 13, 14, 894, DateTimeKind.Local).AddTicks(4593), "Brycen_Bayer@gmail.com", "aaOiiDbTIa2LHpb3qRNhL89CnRUeVJxi+tSdrX6b4OI=", "I4Gidaxl1CccNkwj4MlceIvNOPqMd17wS2LXcrlqh04=", new DateTime(2021, 5, 20, 11, 13, 14, 894, DateTimeKind.Local).AddTicks(4653), "Chelsie24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 904, DateTimeKind.Local).AddTicks(2432), "Giuseppe.Schowalter35@gmail.com", "hZ+2DYV5XXAIOVHgnWBDbfpcg8AQ4zM+9wIJLyAb918=", "hcAUmWfOD0aISKN9HfNk26g/aFy0FNDtKhd/p4b3dO0=", new DateTime(2021, 5, 20, 11, 13, 14, 904, DateTimeKind.Local).AddTicks(2515), "Gino.White66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2021, 5, 20, 11, 13, 14, 913, DateTimeKind.Local).AddTicks(1972), "Madge.McKenzie27@hotmail.com", "wkwbVcA0aF/VIzL/IDIjM7Azl1hRLCpn60+08IGE6BU=", "0FdI7ApNn6iiqH+JugvWa51yvP0xQNkO1rRxsvQ2Dlo=", new DateTime(2021, 5, 20, 11, 13, 14, 913, DateTimeKind.Local).AddTicks(2019), "Warren_Bernier" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 5, 20, 11, 13, 14, 922, DateTimeKind.Local).AddTicks(3523), "Sandra58@hotmail.com", "k8R4dwnKEzCNF/gUJhFLkEv4xK5nI1GjvYZySMBXGfU=", "usYqevKzZb+qARv2wZCKcPL7vjZGIQf77wZaG9DWDk4=", new DateTime(2021, 5, 20, 11, 13, 14, 922, DateTimeKind.Local).AddTicks(3584), "Angelina.Krajcik76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 5, 20, 11, 13, 14, 931, DateTimeKind.Local).AddTicks(4810), "Etha.Kuhic@hotmail.com", "tUkmuUC33oqMFIku6hXOpevaYAFHpD2+MLu02CIEfYg=", "xM96YjEgTurGXzj8FfvB3DIj8YsMlioDF0vJrWGj63c=", new DateTime(2021, 5, 20, 11, 13, 14, 931, DateTimeKind.Local).AddTicks(4874), "Antonio.Kub" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 5, 20, 11, 13, 14, 940, DateTimeKind.Local).AddTicks(5517), "Reymundo.Hyatt9@hotmail.com", "0t+8Uu4780g97Q47WrMGjg4ZC2NyaZyjhrVAueDckpw=", "k+nKIvhRcAZoCTlvp4jeLaxOc6Mm7mQvpAZpwIXGiZA=", new DateTime(2021, 5, 20, 11, 13, 14, 940, DateTimeKind.Local).AddTicks(5579), "Buck_Reynolds58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 5, 20, 11, 13, 14, 949, DateTimeKind.Local).AddTicks(9808), "Ewald_Brown15@gmail.com", "nWDeaY8L/6N+Fe0PIwDMFcbtD8CymNncpqw8sms9i7s=", "ubu59TXbBb0pWuax4nkHvFdu1BLWz6lpSf27whkn0Zw=", new DateTime(2021, 5, 20, 11, 13, 14, 949, DateTimeKind.Local).AddTicks(9852), "Nichole.Kulas" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 5, 20, 11, 13, 14, 960, DateTimeKind.Local).AddTicks(4225), "Webster.Armstrong@yahoo.com", "LbmH1t3nBO0bGpMlURNDdHCbhfm4YFhBp6i8jvYW89g=", "8aLXS7QORAG4uDB+wL5UxChZxhszib/in2oWivPE3oY=", new DateTime(2021, 5, 20, 11, 13, 14, 960, DateTimeKind.Local).AddTicks(4300), "Sigurd_Koch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 5, 20, 11, 13, 14, 970, DateTimeKind.Local).AddTicks(4430), "Chester.Gibson@yahoo.com", "VxSMljQua5wzDvMTEaHBXvqXg52XaKLJZ9FwWeAr64A=", "99Xcb7TKeygJf4WqTJHCz40J7et0ShfsSKdBaosYcIU=", new DateTime(2021, 5, 20, 11, 13, 14, 970, DateTimeKind.Local).AddTicks(4500), "Zetta_Corwin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2021, 5, 20, 11, 13, 14, 979, DateTimeKind.Local).AddTicks(94), "Cory22@hotmail.com", "cC/WtQdyOIXKFdNESGGD3+4le0trUPJBOjDBYWkwGSs=", "vIQ5cLovukqZYHZ7CGBut3nvr4rD4pqucGuIplghdSc=", new DateTime(2021, 5, 20, 11, 13, 14, 979, DateTimeKind.Local).AddTicks(117), "Harrison_Funk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 5, 20, 11, 13, 14, 987, DateTimeKind.Local).AddTicks(9474), "Maximus.Schowalter@hotmail.com", "07nUGFmM3kNcnN5BVOql7SjpvK++FzyfLSDhRBW5uhc=", "AlXbT32FGJzaFlNqe7BeNZHBHbEVro2VwUaHkpWOo/k=", new DateTime(2021, 5, 20, 11, 13, 14, 987, DateTimeKind.Local).AddTicks(9547), "Magnolia_Klocko" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 5, 20, 11, 13, 14, 998, DateTimeKind.Local).AddTicks(5070), "Kathryn_Abshire82@yahoo.com", "YPW+idxIGypCR3HAHfvBYxoTJIrKQqywAgAdOTCkUDQ=", "aLSTRGtEVgAXEB7SxTJVGuz2WAyBd8+WJ2DHMPCQAaQ=", new DateTime(2021, 5, 20, 11, 13, 14, 998, DateTimeKind.Local).AddTicks(5100), "Amina.Skiles4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 5, 20, 11, 13, 15, 9, DateTimeKind.Local).AddTicks(4440), "Javon.Hane5@yahoo.com", "qjQeVb5gyvGZR7JCCa3WcNpCJbbZC1msMQAAm8xzC88=", "sOIYRCoaEv1lNThIyXb7kFDIyRELtsXhnm+bAfZ5fj0=", new DateTime(2021, 5, 20, 11, 13, 15, 9, DateTimeKind.Local).AddTicks(4506), "Precious44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 15, 20, DateTimeKind.Local).AddTicks(3327), "UGZorU7ixmt7ZHZpwbpmfxeeDK1RdaxwQ8tmD7ojIGU=", "lAdg0m8nOXEvf6zmjZ8bbXKHhE8QfSpTUcV9L09Z+84=", new DateTime(2021, 5, 20, 11, 13, 15, 20, DateTimeKind.Local).AddTicks(3327) });
        }
    }
}
