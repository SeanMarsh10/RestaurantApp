using FluentNHibernate.Data;

namespace RestaurantApp.Entities
{
    public class UserEntity : Entity
    {
        public virtual string UserName { get; set; }

        public virtual string Passsword { get; set; }

        public virtual int AccessLevel { get; set; }
    }
}
