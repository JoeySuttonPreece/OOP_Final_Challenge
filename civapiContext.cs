using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OOP_Final_Challenge
{
    public partial class civapiContext : DbContext
    {
        public civapiContext()
        {
        }

        public civapiContext(DbContextOptions<civapiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Computer> Computer { get; set; }
        public virtual DbSet<Room> Room { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClassCode);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Building)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => new { d.Building, d.RoomNo })
                    .HasConstraintName("FK_Room_Class");
            });

            modelBuilder.Entity<Computer>(entity =>
            {
                entity.HasKey(e => new { e.Number, e.Building, e.RoomNo });

                entity.Property(e => e.Building)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Computer)
                    .HasForeignKey(d => new { d.Building, d.RoomNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Room_Computer");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => new { e.Building, e.RoomNo });

                entity.Property(e => e.Building)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });
        }
    }
}
