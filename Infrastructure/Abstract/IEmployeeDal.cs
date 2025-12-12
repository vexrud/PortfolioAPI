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
    /// Employee tablosuna özgü veritabanı operasyonları yer alır.
    /// </summary>
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}
