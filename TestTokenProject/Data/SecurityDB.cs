namespace TestTokenProject.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SecurityDB : DbContext
    {
        public SecurityDB()
            : base("name=SecurityDB")
        {
        }

        public virtual DbSet<UserMaster> UserMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaster>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserMaster>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UserMaster>()
                .Property(e => e.UserRoles)
                .IsUnicode(false);

            modelBuilder.Entity<UserMaster>()
                .Property(e => e.UserEmailID)
                .IsUnicode(false);
        }
    }
}
