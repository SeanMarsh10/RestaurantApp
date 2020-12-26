using FluentNHibernate.Data;
using System;

namespace RestaurantApp.Entities
{
    public class FoodDataEntity : Entity
    {
        new public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual decimal Price { get; set; }

        public virtual CategoriesEntity Category { get; set; }
    }
}
