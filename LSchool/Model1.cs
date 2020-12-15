namespace LSchool
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<clientservice> clientservice { get; set; }
        public virtual DbSet<documentbyservice> documentbyservice { get; set; }
        public virtual DbSet<gender> gender { get; set; }
        public virtual DbSet<manufacturer> manufacturer { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<productphoto> productphoto { get; set; }
        public virtual DbSet<productsale> productsale { get; set; }
        public virtual DbSet<service> service { get; set; }
        public virtual DbSet<servicephoto> servicephoto { get; set; }
        public virtual DbSet<tag> tag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.RegistrationDate)
                .HasPrecision(6);

            modelBuilder.Entity<client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.GenderCode)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.clientservice)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.tag)
                .WithMany(e => e.client)
                .Map(m => m.ToTable("tagofclient", "14").MapLeftKey("ClientID").MapRightKey("TagID"));

            modelBuilder.Entity<clientservice>()
                .Property(e => e.StartTime)
                .HasPrecision(6);

            modelBuilder.Entity<clientservice>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<clientservice>()
                .HasMany(e => e.documentbyservice)
                .WithRequired(e => e.clientservice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<documentbyservice>()
                .Property(e => e.DocumentPath)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .HasMany(e => e.client)
                .WithRequired(e => e.gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manufacturer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.MainImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.productphoto)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.productsale)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.product1)
                .WithMany(e => e.product2)
                .Map(m => m.ToTable("attachedproduct", "14").MapLeftKey("MainProductID").MapRightKey("AttachedProductID"));

            modelBuilder.Entity<productphoto>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<productsale>()
                .Property(e => e.SaleDate)
                .HasPrecision(6);

            modelBuilder.Entity<service>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .Property(e => e.MainImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.clientservice)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.servicephoto)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servicephoto>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<tag>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tag>()
                .Property(e => e.Color)
                .IsUnicode(false);
        }
    }
}
