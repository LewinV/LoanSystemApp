using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystemApp.Persistence.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
       Task<int> Add(T entity);
    }
}
