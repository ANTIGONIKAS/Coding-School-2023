using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repositories
{
    public interface IEntityRepo<TEntity>
        where TEntity :IEntityBase
    {
        void GetAll(Guid id);

        TEntity GetById(Guid id);

        void Add(TEntity entity);

        void Update(Guid id,TEntity entity );

        void Delete(Guid id);


    }
}
