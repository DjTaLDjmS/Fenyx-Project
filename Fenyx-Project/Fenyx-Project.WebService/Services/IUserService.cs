using Fenyx_Project.WebService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Fenyx_Project.WebService.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IUserService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        Task<List<UserListItemContract>> FindAllUsers();

        [OperationContract]
        Task<UserContract> FindUser(Guid id);

        [OperationContract]
        Task<UserContract> AddUser(UserContract p);

        [OperationContract]
        Task<UserContract> UpdateUser(UserContract p);

        [OperationContract]
        Task DeleteUser(Guid id);
    }
}
