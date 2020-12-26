using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class TableModel
    {
        public int TableNumber { get; set; }

        public string ServerName { get; set; }

        public bool InUse { get; set; }

        public int DiningSequence { get; set; }
    }
}
