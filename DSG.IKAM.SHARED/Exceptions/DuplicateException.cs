using System;

namespace DSG.IKAM.SHARED.Exceptions
{
    public class DuplicateException : Exception
    {
        public DuplicateException(string message) : base($"Data is duplicated {message}")
        {

        }
    }
}
