using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ICRUD<T>
    {
        Response Insert(T item);
        Response Update(T item);
        Response Delete(int id);
        DataResponse<T> GetAll();
        SingleResponse<T> GetByID(int id);
    }
}
