using DSG.IKAM.BAL.Interfaces;
using System;

namespace DSG.IKAM.BAL.Implements
{
    public class LogService : ILogService
    {
        internal static LogService CreateInstant()
        {
            return new LogService();
        }

        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
