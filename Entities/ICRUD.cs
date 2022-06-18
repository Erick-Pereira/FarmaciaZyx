using Shared;

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
