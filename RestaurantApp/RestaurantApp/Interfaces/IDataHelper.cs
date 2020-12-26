using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Interfaces
{
    public interface IDataHelper
    {
        public abstract List<Entity> GetAll();
    }
}
