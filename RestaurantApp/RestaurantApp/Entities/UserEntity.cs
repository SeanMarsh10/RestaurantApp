using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Entities
{
    public class UserEntity : Entity
    {
        public virtual string UserName { get; set; }

        public virtual string Passsword { get; set; }

        public virtual int AccessLevel { get; set; }
    }
}
