using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StackOverflowClone.Migrations
{
    public partial class CommentsModel_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentsModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AnswerID = table.Column<int>(type: "int4", nullable: false),
                    AnswersModelID = table.Column<int>(type: "int4", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "timestamp", nullable: false),
                    QuestionID = table.Column<int>(type: "int4", nullable: false),
                    QuestionsModelID = table.Column<int>(type: "int4", nullable: true),
                    UserID = table.Column<int>(type: "int4", nullable: false),
                    UsersModelID = table.Column<int>(type: "int4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentsModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CommentsModel_AnswersModel_AnswersModelID",
                        column: x => x.AnswersModelID,
                        principalTable: "AnswersModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentsModel_QuestionsModel_QuestionsModelID",
                        column: x => x.QuestionsModelID,
                        principalTable: "QuestionsModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentsModel_UsersModel_UsersModelID",
                        column: x => x.UsersModelID,
                        principalTable: "UsersModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentsModel_AnswersModelID",
                table: "CommentsModel",
                column: "AnswersModelID");

            migrationBuilder.CreateIndex(
                name: "IX_CommentsModel_QuestionsModelID",
                table: "CommentsModel",
                column: "QuestionsModelID");

            migrationBuilder.CreateIndex(
                name: "IX_CommentsModel_UsersModelID",
                table: "CommentsModel",
                column: "UsersModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentsModel");
        }
    }
}
