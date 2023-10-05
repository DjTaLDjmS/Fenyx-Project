using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenyx_Project.WebService.Dao
{
    public interface IDao<TEntity> where TEntity : class, new()
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> Get(Guid id);

        Task<TEntity> Create(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task Delete(Guid id);
    }
}
