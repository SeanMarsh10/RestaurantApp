using FluentNHibernate.Mapping;
using RestaurantApp.Entities;

namespace RestaurantApp.Mappings
{
    public class TableEntityMapping : ClassMap<TableEntity>
    {
        public TableEntityMapping()
        {
            Id(x => x.Id, "table_id");
            Map(x => x.MaxSeats, "max_seats");
            Map(x => x.Number, "table_number");
            Table("tables");
        }
    }
}
