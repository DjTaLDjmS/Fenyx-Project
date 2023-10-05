using AppForm.WebServices.Utils;
using Fenyx_Project.WebService.Contracts;
using Fenyx_Project.WebService.Dao.Impl;
using Fenyx_Project.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Fenyx_Project.WebService.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "UserService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez UserService.svc ou UserService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class UserService : IUserService
    {
        public async Task<List<UserListItemContract>> FindAllUsers()
        {
            var usersFromDb =  await new UserDaoImpl().GetAll();

            List<UserListItemContract> userListItemContract = MapperConfig
                .ModelMapper.Map<List<User> ,List <UserListItemContract>>(usersFromDb);

            return userListItemContract;
        }

        public async Task<UserContract> FindUser(Guid id)
        {
            var usersFromDb = await new UserDaoImpl().Get(id);

            UserContract userContract = MapperConfig
                .ModelMapper.Map<User, UserContract>(usersFromDb);
            
            return userContract;
        }

        public async Task<UserContract> AddUser(UserContract p)
        {
            User userSaved = MapperConfig
                .ModelMapper.Map<UserContract, User>(p);

            await new UserDaoImpl().Create(userSaved);
            return p;
        }

        public async Task<UserContract> UpdateUser(UserContract p)
        {
            User userSaved = MapperConfig
              .ModelMapper.Map<UserContract, User>(p);

            await new UserDaoImpl().Update(userSaved);
            return p;
        }

        public async Task DeleteUser(Guid id)
        {
            await new UserDaoImpl().Delete(id);
        }
    }
}
