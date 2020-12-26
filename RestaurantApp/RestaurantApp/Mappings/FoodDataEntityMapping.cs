using FluentNHibernate.Mapping;
using RestaurantApp.Entities;

namespace RestaurantApp.Mappings
{
    public class FoodDataEntityMapping : ClassMap<FoodDataEntity>
    {
        public FoodDataEntityMapping()
        {
            Id(x => x.Id, "food_id");
            Map(x => x.Name, "name");
            Map(x => x.Price, "price");
            References(x => x.Category);
            Table("food_data");
        }
    }
}
