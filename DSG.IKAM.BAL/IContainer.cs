using DSG.IKAM.BAL.Interfaces;

namespace DSG.IKAM.BAL
{
    public interface IContainer
    {
        ILogService Logger { get; }
        IBrandService Brand { get; }
    }
}
