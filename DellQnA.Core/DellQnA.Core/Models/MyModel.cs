namespace DellQnA.Core.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<AnswerTable> AnswerTables { get; set; }
        public virtual DbSet<QuestionTable> QuestionTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionTable>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<QuestionTable>()
                .Property(e => e.UID)
                .IsFixedLength();

            modelBuilder.Entity<UserTable>()
                .Property(e => e.UserName)
                .IsUnicode(false);
        }
    }
}
