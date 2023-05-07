using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        //IQueryable veritabanımıza yapacagımız sorguyu veritabanına gitmeden belirleyi düzenlemeyi saglar. tolist() ile cagırdıgımız zaman IQueryable calısacak. 

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities); // birden fazla ekleme istemi yapmak için
        void Update(T entity); //update ve delete işlemlerinin asenkron olmasına gerek yok.state ını modify olarak degısıtıyoruz
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);// birden fazla silme istemi yapmak için
    }

}
