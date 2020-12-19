using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Interfaces
{
    public interface IUnitOfWork
    {
        public abstract ISession OpenSession();
    }
}
