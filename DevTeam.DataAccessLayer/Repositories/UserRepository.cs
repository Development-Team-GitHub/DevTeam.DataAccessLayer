using DevTeam.DataAccessLayer.Data;
using DevTeam.DataAccessLayer.Interfaces;
using DevTeam.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevTeam.DataAccessLayer.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public ApplicationDbContext DbContext
        {
            get { return _dbContext; }
        }

        public User GetUser(object id)
        {
            return DbContext.User.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return DbContext.User.ToList();
        }
    }
}
