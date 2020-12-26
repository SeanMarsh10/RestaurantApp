using FluentNHibernate.Mapping;
using RestaurantApp.Entities;

namespace RestaurantApp.Mappings
{
    public class CategoriesEntityMapping : ClassMap<CategoriesEntity>
    {
        public CategoriesEntityMapping()
        {
            Id(x => x.Id, "category_id");
            Map(x => x.Name, "name");
            Table("categories");
        }
    }
}
