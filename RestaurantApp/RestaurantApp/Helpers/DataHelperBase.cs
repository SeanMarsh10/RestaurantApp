using FluentNHibernate.Data;
using NHibernate;
using RestaurantApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Helpers
{
    public class DataHelperBase : IDataHelper
    {
        public ISession session;

        public DataHelperBase()
        {
            session = new UnitOfWork().OpenSession();
        }

        public virtual List<Entity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
