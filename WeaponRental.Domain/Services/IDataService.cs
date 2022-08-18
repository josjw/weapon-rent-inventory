using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeaponRental.Domain.Services
{
    public interface IDataService<T>
    {
        Task<T> Create(T entity);

        Task<T> Get(int id);

        Task<T> Update(int id, T entity);

        Task<bool> Delete(int id);
    }
}
