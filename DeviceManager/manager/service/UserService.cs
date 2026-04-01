using DeviceManager.manager.dto;
using DeviceManager.manager.entity;
using DeviceManager.manager.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.service
{
    public class UserService
    {
        private readonly DeviceManagerDbContext _dbContext;

        public UserService(DeviceManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
        
        //user may not exist
        public User? GetUserById(uint Id)
        {
            return _dbContext.Users.FirstOrDefault(u  => u.Id == Id);
        }

        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(UserDTO user)
        {
            var dbUser = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);

            if (dbUser == null) return;

            if(user.Name != null) dbUser.Name = user.Name;
            if (user.Location != null) dbUser.Location = user.Location;

            _dbContext.SaveChanges();
        }

        public void DeleteUser(uint Id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == Id);

            if (user == null) return;

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
    }
}
