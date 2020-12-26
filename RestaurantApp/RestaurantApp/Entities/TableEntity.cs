using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Entities
{
    public class TableEntity : Entity
    {
        new public virtual Guid Id { get; set; }

        public virtual int MaxSeats { get; set; }

        public virtual int Number { get; set; }
    }
}
