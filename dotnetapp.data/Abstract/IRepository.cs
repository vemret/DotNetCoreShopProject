using System.Collections.Generic;

namespace dotnetapp.data.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll(); //database tüm ürünleri getir
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}