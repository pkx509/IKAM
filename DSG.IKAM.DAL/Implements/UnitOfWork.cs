using System.Data;

namespace DSG.IKAM.DAL.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        private void ResetRepositories()
        {
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch //(Exception ex)
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
