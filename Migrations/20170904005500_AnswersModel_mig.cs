using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StackOverflowClone.Migrations
{
    public partial class AnswersModel_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BitForMod = table.Column<bool>(type: "bool", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Body = table.Column<string>(type: "text", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "int4", nullable: false),
                    UsersModelID = table.Column<int>(type: "int4", nullable: true),
                    VoteCount = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QuestionsModel_UsersModel_UsersModelID",
                        column: x => x.UsersModelID,
                        principalTable: "UsersModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswersModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Body = table.Column<string>(type: "text", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "timestamp", nullable: false),
                    QuestionID = table.Column<int>(type: "int4", nullable: false),
                    QuestionsModelID = table.Column<int>(type: "int4", nullable: true),
                    UserID = table.Column<int>(type: "int4", nullable: false),
                    UsersModelID = table.Column<int>(type: "int4", nullable: true),
                    VoteCount = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswersModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnswersModel_QuestionsModel_QuestionsModelID",
                        column: x => x.QuestionsModelID,
                        principalTable: "QuestionsModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswersModel_UsersModel_UsersModelID",
                        column: x => x.UsersModelID,
                        principalTable: "UsersModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswersModel_QuestionsModelID",
                table: "AnswersModel",
                column: "QuestionsModelID");

            migrationBuilder.CreateIndex(
                name: "IX_AnswersModel_UsersModelID",
                table: "AnswersModel",
                column: "UsersModelID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsModel_UsersModelID",
                table: "QuestionsModel",
                column: "UsersModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswersModel");

            migrationBuilder.DropTable(
                name: "QuestionsModel");

            migrationBuilder.DropTable(
                name: "UsersModel");
        }
    }
}
