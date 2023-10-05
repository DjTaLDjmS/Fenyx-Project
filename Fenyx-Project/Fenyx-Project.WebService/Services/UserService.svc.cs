using AppForm.WebServices.Utils;
using Fenyx_Project.WebService.Contracts;
using Fenyx_Project.WebService.Dao.Impl;
using Fenyx_Project.WebService.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Fenyx_Project.WebService.Services
{
    public class UserService : IUserService
    {
        private static readonly ILog log = log4net.LogManager
            .GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        public async Task<List<UserListItemContract>> FindAllUsers()
        {
            log.Info("Appel de la methode FindAllUsers() du service Fenyx-Project.WebService");
            var usersFromDb =  await new UserDaoImpl().GetAll();

            List<UserListItemContract> userListItemContract = MapperConfig
                .ModelMapper.Map<List<User> ,List <UserListItemContract>>(usersFromDb);

            return userListItemContract;
        }

        public async Task<UserContract> FindUser(Guid id)
        {
            log.Info("Appel de la methode FindUser() du service Fenyx-Project.WebService");

            var usersFromDb = await new UserDaoImpl().Get(id);

            UserContract userContract = MapperConfig
                .ModelMapper.Map<User, UserContract>(usersFromDb);
            
            return userContract;
        }

        public async Task<UserContract> AddUser(UserContract p)
        {
            log.Info("Appel de la methode AddUser() du service Fenyx-Project.WebService");

            User userSaved = MapperConfig
                .ModelMapper.Map<UserContract, User>(p);

            await new UserDaoImpl().Create(userSaved);
            return p;
        }

        public async Task<UserContract> UpdateUser(UserContract p)
        {
            log.Info("Appel de la methode UpdateUser() du service Fenyx-Project.WebService");

            User userSaved = MapperConfig
              .ModelMapper.Map<UserContract, User>(p);

            await new UserDaoImpl().Update(userSaved);
            return p;
        }

        public async Task DeleteUser(Guid id)
        {
            log.Info("Appel de la methode DeleteUser() du service Fenyx-Project.WebService");

            await new UserDaoImpl().Delete(id);
        }
    }
}
