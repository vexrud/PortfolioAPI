using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllRecord();
        Product GetRecordById(Guid id);

        void AddRecord(Product entity);
        void UpdateRecord(Product entity);
        void DeleteRecord(Guid id);
    }
}
