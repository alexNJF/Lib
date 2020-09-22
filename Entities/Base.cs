using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IEntity
    {

    }
    public abstract class BaseEntitiy<Tkey>:IEntity
    {
        public Tkey id { get; set; }
    }
    public abstract class BaseEntity:BaseEntitiy<int>
    {

    }

}
