using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.Domain.Core;
using DataAccess.Support;
using IoC;

namespace DataAccess
{
    public abstract class UnitOfWorkBase : IUnitOfWork
    {
        private readonly DbContext context;
        private readonly RepositoryFactory repositoryFactory;
        private bool disposed;
        protected ILoggerProvider loggerProvider;
        protected IConfiguration configuration;

        public UnitOfWorkBase(ILoggerProvider loggerProvider, IConfiguration configuration)
        {
            this.loggerProvider = loggerProvider;
            this.configuration = configuration;
            this.context = CreateContext() ?? throw new ArgumentNullException(nameof(context));
            this.repositoryFactory = new RepositoryFactory(this.context);
        }

        public int Commit() => this.context.SaveChanges();

        public Task<int> CommitAsync()
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(UnitOfWorkBase));
            return this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed) return;

            if (disposing)
            {
                this.context?.Dispose();
            }

            this.disposed = true;
        }

        public TRepository GetRepository<TRepository>() => repositoryFactory.Create<TRepository>();

        protected abstract DbContext CreateContext();
    }
}
