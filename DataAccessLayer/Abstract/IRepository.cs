using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //T ne ise o tabloyu getircek bize yanı her tablo icin ayrı bir interface acmaya gerek yok
    public interface IRepository<T>
    {
        List<T> List();

        void Insert(T p);

        T Get(Expression<Func<T, bool>> filter);

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
