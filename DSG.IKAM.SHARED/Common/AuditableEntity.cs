using System;

namespace DSG.IKAM.SHARED.Common
{
    public abstract class AuditableEntity
    {
        public string CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }
}
