using FluentNHibernate.Data;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Helpers
{
    public class DataHelperBase
    {
        public ISession session;

        public DataHelperBase()
        {
            session = new UnitOfWork().OpenSession();
        }
    }
}
