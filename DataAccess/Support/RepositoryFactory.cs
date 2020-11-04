using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using IoC;

namespace DataAccess.Support
{
    internal class RepositoryFactory
    {
        private readonly IDictionary<string, object> repositories = new Dictionary<string, object>();
        private DbContext context;

        public RepositoryFactory(DbContext context)
        {
            this.context = context;
        }

        public TRepository Create<TRepository>()
        {
            string repoKey = typeof(TRepository).FullName;

            if (!this.repositories.Keys.Contains(repoKey)) RegisterRepository<TRepository>(repoKey);

            return (TRepository)this.repositories[repoKey];
        }

        private void RegisterRepository<TRepository>(string repoKey)
        {
            IDictionary<String, object> args = new Dictionary<string, object>() { { "context", this.context } };
            repositories.Add(repoKey, IoCFactory.Instance.Container.Resolve<TRepository>(args));
        }
    }
}
