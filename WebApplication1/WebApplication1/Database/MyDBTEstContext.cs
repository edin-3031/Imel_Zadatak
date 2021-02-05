using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Database
{
    public partial class MyDBTEstContext : DbContext
    {
        public MyDBTEstContext()
        {
        }

        public MyDBTEstContext(DbContextOptions<MyDBTEstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }
        public virtual DbSet<ZaposleniciDogadjaji> ZaposleniciDogadjaji { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=MyDBTEst;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposlenici>(entity =>
            {
                entity.Property(e => e.Adresa)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DatumDodavanja).HasColumnType("datetime");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.Grad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZaposleniciDogadjaji>(entity =>
            {
                entity.ToTable("Zaposlenici_Dogadjaji");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.TekstDogadjaja)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ZaposleniciId).HasColumnName("Zaposlenici_Id");

                entity.HasOne(d => d.Zaposlenici)
                    .WithMany(p => p.ZaposleniciDogadjaji)
                    .HasForeignKey(d => d.ZaposleniciId)
                    .HasConstraintName("FK__Zaposleni__Zapos__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
