using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Entities
{
    class Category:BaseEntity
    {
        public string  Name { get; set; }
        public int ?  ParentCategoryId { get; set; }

        public Category ParentCategory { set; get; }
        public ICollection<Category> ChildCategoy { set; get; }
        public ICollection<Book> Books { set; get; }
    }
}
