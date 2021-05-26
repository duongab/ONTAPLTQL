using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ONTAPLTQL.Models
{
    public partial class OTLTQLDbContext : DbContext
    {
        public OTLTQLDbContext()
            : base("name=OTLTQLDbContext")
        {
        }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        // public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
                .Property(e => e.makh)
                .IsUnicode(false);


            modelBuilder.Entity<Khachhang>()
                      .Property(e => e.tenkh)
                      .HasMaxLength(100);
        }

        public System.Data.Entity.DbSet<ONTAPLTQL.Models.Account> Accounts { get; set; }
    }
}
