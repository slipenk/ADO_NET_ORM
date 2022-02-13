using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab_6_kpz
{
    public partial class GreenResortManagementSystemModels : DbContext
    {
        public GreenResortManagementSystemModels()
            : base("name=GreenResortManagementSystemModels")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GreenResortManagementSystemModels, Lab_6_kpz.Migrations.Configuration>());
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Dwelling> Dwellings { get; set; }
        public virtual DbSet<Entertainment> Entertainments { get; set; }
        public virtual DbSet<MM_Tours_Clients> MM_Tours_Clients { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Tours_Entertainments> Tours_Entertainments { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Workers_Tours> Workers_Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.MIddle_name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.MM_Tours_Clients)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ID_clients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dwelling>()
                .HasMany(e => e.Tours)
                .WithRequired(e => e.Dwelling)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entertainment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Entertainment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Entertainment>()
                .HasMany(e => e.Tours_Entertainments)
                .WithRequired(e => e.Entertainment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.MM_Tours_Clients)
                .WithRequired(e => e.Tour)
                .HasForeignKey(e => e.ID_tours)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Tours_Entertainments)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Workers_Tours)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Workers_Tours)
                .WithRequired(e => e.Worker)
                .HasForeignKey(e => e.ID_worker)
                .WillCascadeOnDelete(false);
        }
    }
}
