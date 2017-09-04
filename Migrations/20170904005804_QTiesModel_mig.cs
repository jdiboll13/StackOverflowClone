using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StackOverflowClone.Migrations
{
    public partial class QTiesModel_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TagsModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TagName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagsModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QTiesModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    QuestionID = table.Column<int>(type: "int4", nullable: false),
                    QuestionsModelID = table.Column<int>(type: "int4", nullable: true),
                    TagID = table.Column<int>(type: "int4", nullable: false),
                    TagsModelID = table.Column<int>(type: "int4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QTiesModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QTiesModel_QuestionsModel_QuestionsModelID",
                        column: x => x.QuestionsModelID,
                        principalTable: "QuestionsModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QTiesModel_TagsModel_TagsModelID",
                        column: x => x.TagsModelID,
                        principalTable: "TagsModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QTiesModel_QuestionsModelID",
                table: "QTiesModel",
                column: "QuestionsModelID");

            migrationBuilder.CreateIndex(
                name: "IX_QTiesModel_TagsModelID",
                table: "QTiesModel",
                column: "TagsModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QTiesModel");

            migrationBuilder.DropTable(
                name: "TagsModel");
        }
    }
}
