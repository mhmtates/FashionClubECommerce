using FashionClubECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashionClubECommerce.DataAccess.Concrete.Contexts.EntityFramework.Mappings
{
    public class OrderNotesMap : IEntityTypeConfiguration<OrderNotes>
    {
        public void Configure(EntityTypeBuilder<OrderNotes> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.OrdersId).IsRequired();
            builder.Property(x => x.Notes).HasMaxLength(150);
            builder.Property(x => x.Notes).IsRequired();
            builder.Property(x => x.NoteDate).IsRequired();
            builder.HasOne<Orders>(x => x.Orders).WithMany(c => c.OrderNotes).HasForeignKey(f => f.OrdersId);
            builder.ToTable("OrderNotes");
        }
    }
}
