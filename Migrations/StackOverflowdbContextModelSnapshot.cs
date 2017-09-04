﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StackOverflowClone;
using System;

namespace StackOverflowClone.Migrations
{
    [DbContext(typeof(StackOverflowdbContext))]
    partial class StackOverflowdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("StackOverflowClone.Models.AnswersModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int>("QuestionID");

                    b.Property<int?>("QuestionsModelID");

                    b.Property<int>("UserID");

                    b.Property<int?>("UsersModelID");

                    b.Property<int>("VoteCount");

                    b.HasKey("ID");

                    b.HasIndex("QuestionsModelID");

                    b.HasIndex("UsersModelID");

                    b.ToTable("AnswersModel");
                });

            modelBuilder.Entity("StackOverflowClone.Models.CommentsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerID");

                    b.Property<int?>("AnswersModelID");

                    b.Property<string>("Body");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int>("QuestionID");

                    b.Property<int?>("QuestionsModelID");

                    b.Property<int>("UserID");

                    b.Property<int?>("UsersModelID");

                    b.HasKey("ID");

                    b.HasIndex("AnswersModelID");

                    b.HasIndex("QuestionsModelID");

                    b.HasIndex("UsersModelID");

                    b.ToTable("CommentsModel");
                });

            modelBuilder.Entity("StackOverflowClone.Models.QTiesModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionID");

                    b.Property<int?>("QuestionsModelID");

                    b.Property<int>("TagID");

                    b.Property<int?>("TagsModelID");

                    b.HasKey("ID");

                    b.HasIndex("QuestionsModelID");

                    b.HasIndex("TagsModelID");

                    b.ToTable("QTiesModel");
                });

            modelBuilder.Entity("StackOverflowClone.Models.QuestionsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("DatePosted");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.Property<int?>("UsersModelID");

                    b.Property<int>("VoteCount");

                    b.HasKey("ID");

                    b.HasIndex("UsersModelID");

                    b.ToTable("QuestionsModel");
                });

            modelBuilder.Entity("StackOverflowClone.Models.TagsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TagName");

                    b.HasKey("ID");

                    b.ToTable("TagsModel");
                });

            modelBuilder.Entity("StackOverflowClone.Models.UsersModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BitForMod");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("UsersModel");
                });

            modelBuilder.Entity("StackOverflowClone.Models.AnswersModel", b =>
                {
                    b.HasOne("StackOverflowClone.Models.QuestionsModel", "QuestionsModel")
                        .WithMany()
                        .HasForeignKey("QuestionsModelID");

                    b.HasOne("StackOverflowClone.Models.UsersModel", "UsersModel")
                        .WithMany()
                        .HasForeignKey("UsersModelID");
                });

            modelBuilder.Entity("StackOverflowClone.Models.CommentsModel", b =>
                {
                    b.HasOne("StackOverflowClone.Models.AnswersModel", "AnswersModel")
                        .WithMany()
                        .HasForeignKey("AnswersModelID");

                    b.HasOne("StackOverflowClone.Models.QuestionsModel", "QuestionsModel")
                        .WithMany()
                        .HasForeignKey("QuestionsModelID");

                    b.HasOne("StackOverflowClone.Models.UsersModel", "UsersModel")
                        .WithMany()
                        .HasForeignKey("UsersModelID");
                });

            modelBuilder.Entity("StackOverflowClone.Models.QTiesModel", b =>
                {
                    b.HasOne("StackOverflowClone.Models.QuestionsModel", "QuestionsModel")
                        .WithMany()
                        .HasForeignKey("QuestionsModelID");

                    b.HasOne("StackOverflowClone.Models.TagsModel", "TagsModel")
                        .WithMany()
                        .HasForeignKey("TagsModelID");
                });

            modelBuilder.Entity("StackOverflowClone.Models.QuestionsModel", b =>
                {
                    b.HasOne("StackOverflowClone.Models.UsersModel", "UsersModel")
                        .WithMany()
                        .HasForeignKey("UsersModelID");
                });
#pragma warning restore 612, 618
        }
    }
}
