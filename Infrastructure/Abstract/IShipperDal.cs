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
    /// Shipper tablosuna özgü veritabanı operasyonları yer alır.
    /// </summary>
    public interface IShipperDal : IEntityRepository<Shipper>
    {
    }
}
