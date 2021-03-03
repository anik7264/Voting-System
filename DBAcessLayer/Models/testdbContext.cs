using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DBAcessLayer.Models
{
    public partial class testdbContext : DbContext
    {
        public testdbContext()
        {
        }

        public testdbContext(DbContextOptions<testdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidatelist> Candidatelists { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Voterlist> Voterlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;User Id=root;Database=testdb;Port=3306;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidatelist>(entity =>
            {
                entity.HasKey(e => e.Candidatename)
                    .HasName("PRIMARY");

                entity.ToTable("candidatelist");

                entity.Property(e => e.Candidatename)
                    .HasMaxLength(45)
                    .HasColumnName("candidatename");

                entity.Property(e => e.Candidatevote)
                    .HasColumnType("int(11)")
                    .HasColumnName("candidatevote");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Username, e.Password })
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Username)
                    .HasMaxLength(45)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(45)
                    .HasColumnName("usertype")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Voterlist>(entity =>
            {
                entity.HasKey(e => new { e.Voterid, e.Votername })
                    .HasName("PRIMARY");

                entity.ToTable("voterlist");

                entity.Property(e => e.Voterid)
                    .HasColumnType("int(11)")
                    .HasColumnName("voterid");

                entity.Property(e => e.Votername)
                    .HasMaxLength(45)
                    .HasColumnName("votername");

                entity.Property(e => e.Sl)
                    .HasColumnType("int(11)")
                    .HasColumnName("sl")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Voterblood)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("voterblood");

                entity.Property(e => e.Voterdateofbirth)
                    .HasColumnType("date")
                    .HasColumnName("voterdateofbirth");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
