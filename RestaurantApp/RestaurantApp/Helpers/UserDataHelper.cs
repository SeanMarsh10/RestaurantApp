using Microsoft.Extensions.Logging;
using NHibernate;
using RestaurantApp.Entities;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantApp.Helpers
{
    public class UserDataHelper : DataHelperBase
    {
        private const string passwordRegexPatter = "[0-9]{4}";
        private readonly ILogger<UserDataHelper> log;

        public UserDataHelper() : base()
        {
        }

        public bool MatchPasswordWithUserName(string password, UserEntity user)
        {
            return password == user.Passsword;
        }

        public UserEntity GetUserData(string password)
        {
            var userData =  session.Query<UserEntity>()
                                   .Where(x => x.Passsword == password)
                                   .FirstOrDefault();
            return userData;
        }

        public UserModel GetUserModelFromEntity(UserEntity userEntity)
        {
            return new UserModel(userEntity);
        }

        public bool CreateUser(string userName, string password, int accessLevel)
        {
            if (!ValidatePassword(password))
            {
                return false;
            }
            try
            {
                var userData = new UserEntity()
                {
                    UserName = userName,
                    Passsword = password,
                    AccessLevel = accessLevel
                };

                session.Save(userData);

            }
            catch(Exception e)
            {
                log.LogError("Error {0} adding user {0} to database", e, userName);
                return false;
            }
            return true;
        }

        public bool CheckIfUserExists(string userName, string password)
        {
            return session.Query<UserEntity>().Where(x => x.UserName == userName ||
                                                     x.Passsword == password).Any();
        }

        private bool ValidatePassword(string password)
        {
            Regex regularExpression = new Regex(passwordRegexPatter);
            return regularExpression.IsMatch(password);
        }
    }
}
