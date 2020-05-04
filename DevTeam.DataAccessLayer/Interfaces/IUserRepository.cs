using DevTeam.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTeam.DataAccessLayer.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetUser(object id);

        IEnumerable<User> GetAllUsers();
    }
}
