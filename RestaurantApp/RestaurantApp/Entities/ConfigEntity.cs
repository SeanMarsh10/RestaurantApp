using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Entities
{
    public class ConfigEntity : Entity
    {
        new public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Data { get; set; }
    }
}
