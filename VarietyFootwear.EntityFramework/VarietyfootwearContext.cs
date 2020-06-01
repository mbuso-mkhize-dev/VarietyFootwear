using Microsoft.EntityFrameworkCore;
using VarietyFootwear.EntityFramework.Models;

namespace VarietyFootwear.EntityFramework
{
    public partial class VarietyfootwearContext : DbContext
    {
        public VarietyfootwearContext()
        {
        }

        public VarietyfootwearContext(DbContextOptions<VarietyfootwearContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Kid> Kids { get; set; }
        public virtual DbSet<Men> Mens { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Shoe> Shoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.MailingListId)
                    .HasName("PK__Feedback__4CE9ED5B2425E0B3");

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.Feedback1).IsUnicode(false);

                entity.Property(e => e.Like).IsUnicode(false);
            });

            modelBuilder.Entity<Kid>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Kids__B40CC6ED6CE9AFAE");

                entity.Property(e => e.Colour).IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.Section).IsUnicode(false);

                entity.Property(e => e.UnitPrice).IsUnicode(false);
            });

            modelBuilder.Entity<Men>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Mens__B40CC6ED15719022");

                entity.Property(e => e.Colour).IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.Section).IsUnicode(false);

                entity.Property(e => e.UnitPrice).IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderNumber)
                    .HasName("PK__Orders__96241949FC663C92");

                entity.Property(e => e.Colour).IsUnicode(false);

                entity.Property(e => e.EmailName).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Price).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.Section).IsUnicode(false);
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Register__1788CCAC13B3BA02");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CreditCardNumber).IsUnicode(false);

                entity.Property(e => e.EmailAdress).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);
            });

            modelBuilder.Entity<Shoe>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Shoes__B40CC6ED3E5E8C10");

                entity.Property(e => e.Colour).IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.Section).IsUnicode(false);

                entity.Property(e => e.UnitPrice).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}