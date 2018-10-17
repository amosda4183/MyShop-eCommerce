using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        //saves the time when the class implementing the base class was created 
        public DateTimeOffset CreatedAt { get; set; }

        //constructor to setup Id and time created
        public BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
        }
    }
}
