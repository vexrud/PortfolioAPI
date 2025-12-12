using Core.Entities;
using Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstract
{
    /// <summary>
    /// Supplier tablosuna özgü veritabanı operasyonları yer alır.
    /// </summary>
    public interface ISupplierDal : IEntityRepository<Supplier>
    {
    }
}
