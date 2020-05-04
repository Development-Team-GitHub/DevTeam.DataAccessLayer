using DevTeam.DataAccessLayer.Data;
using DevTeam.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTeam.DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Users = new UserRepository(_dbContext);
        }

        public IUserRepository Users { get; private set; }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
