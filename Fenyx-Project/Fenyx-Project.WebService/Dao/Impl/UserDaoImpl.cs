using Fenyx_Project.WebService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
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
        
        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> Get(Guid id)
        {
            return await _dbContext.Users.Include(u => u.Address).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> Create(User entity)
        {
            _dbContext.Users.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<User> Update(User entity)
        {
            _dbContext.Address.AddOrUpdate(entity.Address);
            _dbContext.Users.AddOrUpdate(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(Guid id)
        {
            User entity = await Get(id);
            //Ajout de WillCascadeOnDelete
            //_dbContext.Address.Remove(entity.Address);
            _dbContext.Users.Remove(entity);
            _dbContext.SaveChanges();
        }

    }
}