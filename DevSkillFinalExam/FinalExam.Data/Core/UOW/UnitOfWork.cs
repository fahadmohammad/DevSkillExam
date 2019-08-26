using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core.UOW
{
    public abstract class UnitOfWork<T> : IDisposable where T : DbContext
    {
        protected T dbContext;

        public UnitOfWork(string connectionString, string migrationAssemblyName)
        {
            dbContext = (T)Activator.CreateInstance(typeof(T), connectionString, migrationAssemblyName);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
