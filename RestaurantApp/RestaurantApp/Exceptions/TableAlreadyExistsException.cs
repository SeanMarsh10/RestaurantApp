using System;

namespace RestaurantApp.Exceptions
{
    public class TableAlreadyExistsException : Exception
    {

        public TableAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
