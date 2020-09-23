using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
            : base()
        {
            
        }
    }
}
