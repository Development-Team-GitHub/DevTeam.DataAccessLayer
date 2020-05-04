using System;
using System.Collections.Generic;
using System.Text;

namespace DevTeam.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        void SaveChanges();
    }
}
