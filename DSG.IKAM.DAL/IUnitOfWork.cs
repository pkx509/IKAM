using System;

namespace DSG.IKAM.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
