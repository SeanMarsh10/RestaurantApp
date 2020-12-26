using FluentNHibernate.Mapping;
using RestaurantApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Mappings
{
    public class ResourceEntityMapping : ClassMap<ResourceEntity>
    {
        public ResourceEntityMapping()
        {
            Id(x => x.Id, "resource_id");
            Map(x => x.Name, "resource_name");
            Map(x => x.Data, "resource_data");
            Table("resource_header");
        }
    }
}
