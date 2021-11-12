using System;

namespace DSG.IKAM.SHARED.Utilities
{
    internal class DateTime2
    {
        private DateTime _inner;
        public static explicit operator DateTime(DateTime2 self)
        {
            return self._inner.AddHours(14);
        }
    }
}