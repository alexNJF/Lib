using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    class Book:BaseEntity
    {
        public string  Name { get; set; }
        public string ?  Auther { get; set; }
        public string  IUDCode { get; set; }
        public string ? Price { set; get; }
        public int CategoryID { get; set; }
        public Category Category { set; get; }



    }

    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        void IEntityTypeConfiguration<Book>.Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(book => book.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(book => book.IUDCode).IsUnique();
            
        }
    }
}
