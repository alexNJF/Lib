using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Entities
{
    public class User:BaseEntity
    { 
        public string  Name { get; set; }
        public string  PasswordHash { get; set; }
        public int RollId { get; set; }
        public string  phone { get; set; }
        public  int MyProperty { get; set; }
        public address ? Address { get; set; }

    }

   public class address
    {
     
        public string  ? Countruy  { get; set; }
        public string ? State { get; set; }
        public string ? City { get; set; }
        public string ? Street { get; set; }
        public string ? Alley { get; set; }
        public string ? PostalCode { get; set; }

    }


}
