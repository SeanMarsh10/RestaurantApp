using RestaurantApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class UserModel
    {
        public UserModel(UserEntity userEntity)
        {
            this.UserName = userEntity.UserName;
            this.Password = userEntity.Passsword;
        }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
