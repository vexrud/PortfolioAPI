using Core.Entities;
using Core.Infrastructure.EntityFramework;
using Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Concrete
{
    public class EfSupplierDal : EfEntityRepository<Supplier, CustomNorthwindContext>, ISupplierDal
    {
    }
}
