using FluentNHibernate.Data;
using System;

namespace RestaurantApp.Entities
{
    public class CategoriesEntity : Entity
    {
        new public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }
    }
}
