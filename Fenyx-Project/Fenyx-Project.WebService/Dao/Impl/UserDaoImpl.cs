using Fenyx_Project.WebService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Fenyx_Project.WebService.Dao.Impl
{
    public class UserDaoImpl : IDao<User>
    {
        private readonly ModelDbContext _dbContext;

        public UserDaoImpl()
        {
            _dbContext = new ModelDbContext();
        }
        
        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User Get(Guid id)
        {
            return _dbContext.Users.Include(u => u.Address).FirstOrDefault(u => u.Id == id);
        }

        public User Create(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public User Update(User entity)
        {
            _dbContext.Users.AddOrUpdate(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(Guid id)
        {
            User entity = Get(id);
            _dbContext.Users.Remove(entity);
            _dbContext.SaveChanges();
        }

    }
}