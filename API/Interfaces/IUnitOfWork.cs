using System;
using System.Threading.Tasks;
using API.Models;

namespace API.Interfaces
{
    public interface IUnitOfWork : IDisposable 
    {
        IUserRepository UserRepository {get; }
        IMessageRepository MessageRepository {get;}
        Task<bool> Complete();
        bool HasChanges();
    }
}