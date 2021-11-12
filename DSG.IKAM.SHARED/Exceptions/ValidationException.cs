using System;

namespace DSG.IKAM.SHARED.Exceptions
{
    public class ValidationException: Exception
    {
        public ValidationException(string message = "No data selection") : base($"{message}")
        {

        }
    }
}
