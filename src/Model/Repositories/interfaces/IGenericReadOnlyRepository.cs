using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories.Interfaces
{
    public interface IGenericReadOnlyRepository<T>
    {
        List<T> GetAll();
        IQueryable<T> List();

        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        T GetByID(object id);
        IEnumerable<T> GetWithRawSql(string query, params object[] parameters);


    }
}
