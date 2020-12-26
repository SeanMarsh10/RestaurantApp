using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using RestaurantApp.Entities;
using RestaurantApp.Interfaces;
using ISession = NHibernate.ISession;

namespace RestaurantApp.Helpers
{
    public class UnitOfWork : IUnitOfWork
    {
        public ISession OpenSession()
        {
            var connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

            var sessionSetup = Fluently.Configure()
                                      .Database(MsSqlConfiguration.MsSql2012
                                                                  .ConnectionString(connectionString)
                                                                  .ShowSql());
            var session = sessionSetup.Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserEntity>())
                                      .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                      .Create(false, false)).BuildSessionFactory(); 

            return session.OpenSession();
        }
    }
}
