using FluentNHibernate.Mapping;
using RestaurantApp.Entities;

namespace RestaurantApp.Mappings
{
    public class UserEntityMapping : ClassMap<UserEntity>
    {
        public UserEntityMapping()
        {
            Id(x => x.Id, "id");
            Map(x => x.UserName, "user_name");
            Map(x => x.Passsword, "password");
            Map(x => x.AccessLevel, "access_level");
            Table("user_data");
        }
    }
}
