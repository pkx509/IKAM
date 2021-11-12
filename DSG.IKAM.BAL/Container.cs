using DSG.IKAM.BAL.Implements;
using DSG.IKAM.BAL.Interfaces;

namespace DSG.IKAM.BAL
{
    public class Container : IContainer
    {
        public ILogService Logger { get; protected set; } = LogService.CreateInstant();
        public IBrandService Brand { get; protected set; } = BrandService.CreateInstant();
    }
}
