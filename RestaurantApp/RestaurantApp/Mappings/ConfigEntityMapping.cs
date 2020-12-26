using FluentNHibernate.Mapping;
using RestaurantApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Mappings
{
    public class ConfigEntityMapping : ClassMap<ConfigEntity>
    {
        public ConfigEntityMapping()
        {
            Id(x => x.Id, "config_id");
            Map(x => x.Name, "config_name");
            Map(x => x.Data, "config_data");
            Table("config_header");
        }
    }
}
