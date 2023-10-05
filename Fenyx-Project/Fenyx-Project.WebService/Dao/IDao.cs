using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenyx_Project.WebService.Dao
{
    public interface IDao<TEntity> where TEntity : class, new()
    {
        List<TEntity> GetAll();
        
        TEntity Get(Guid id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        void Delete(Guid id);
    }
}
