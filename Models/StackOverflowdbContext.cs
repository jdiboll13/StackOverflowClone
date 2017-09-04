using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StackOverflowClone.Models;

namespace StackOverflowClone.Models
{
    public partial class StackOverflowdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost;Database=StackOverflowdb;Username=dev;Password=brit1336");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<StackOverflowClone.Models.AnswersModel> AnswersModel { get; set; }

        public DbSet<StackOverflowClone.Models.CommentsModel> CommentsModel { get; set; }

        public DbSet<StackOverflowClone.Models.QTiesModel> QTiesModel { get; set; }

        public DbSet<StackOverflowClone.Models.QuestionsModel> QuestionsModel { get; set; }

        public DbSet<StackOverflowClone.Models.TagsModel> TagsModel { get; set; }

        public DbSet<StackOverflowClone.Models.UsersModel> UsersModel { get; set; }
    }
}
