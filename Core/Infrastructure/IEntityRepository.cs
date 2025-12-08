using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure
{
    /// <summary>
    /// where class : referans tip | IEntity : yani bu generic yapı IEntity olabilir yada IEntity implemente eden bir nesne yapısı olabilir
    /// new() : Bir örneği oluşturulmalı
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Expression GetAll() fonksiyonu çağırıldığı zaman içerisinde Linq sorgulamaları ile filtreleme uygulayarak veritabanından dataları çekmemizde yardımcı olacak.
        //Linq.Expression kütüphanesi ile birlikte gelir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        //Get fonksiyonu genellikle tek bir kayıda erişmek için kullanıldığından dolayı istenilen kayıdın ayırt edici olan yani unique olan değeri ile çağırılarak
        //ilgili kayıda erişim sağlanmasını amaçlıyoruz.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
