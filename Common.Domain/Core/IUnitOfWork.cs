using System;
using System.Threading.Tasks;

namespace Common.Domain.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        Task<int> CommitAsync();
    }
}
