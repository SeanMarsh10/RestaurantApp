using FluentNHibernate.Data;
using RestaurantApp.Entities;
using RestaurantApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Helpers
{
    public class TablesDataHelper : DataHelperBase
    {
        public TablesDataHelper()
        {
        }

        public TableEntity GetTableByNumber(int tableNumber)
        {
            return session.Query<TableEntity>()
                          .Where(x => x.Number == tableNumber)
                          .FirstOrDefault();
        }

        public int GetTableMaxSeats(int tableNumber)
        {
            return session.Query<TableEntity>()
                          .Where(x => x.Number == tableNumber)
                          .Select(x => x.MaxSeats)
                          .FirstOrDefault();
        }

        public void AddTable(int tableNumber, int maxSeats)
        {
            CheckForExistingTable(tableNumber);
            var newTable = new TableEntity()
            {
                Number = tableNumber,
                MaxSeats = maxSeats
            };
            session.Save(newTable);
        }

        public override List<Entity> GetAll()
        {
            var tables = new List<Entity>();
            tables.AddRange(session.Query<TableEntity>().ToList());
            return tables;
        }

        private void CheckForExistingTable(int tableNumber)
        {
            var table = GetTableByNumber(tableNumber);
            if (table != null)
            {
                throw new TableAlreadyExistsException("Table already exists in database");
            }
        }
    }
}
