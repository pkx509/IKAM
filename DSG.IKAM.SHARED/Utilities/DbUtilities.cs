using System;

namespace DSG.IKAM.SHARED.Utilities
{
    public static class DbUtilities
    {
        public static DateTime ToDateTime2(this DateTime self)
        {
            return self.AddHours(14);
        }

        public static DateTime NowUtc2 => DateTime.UtcNow.ToDateTime2();
        public static DateTime DateTime2 => (DateTime)(new DateTime2());
    }
}
