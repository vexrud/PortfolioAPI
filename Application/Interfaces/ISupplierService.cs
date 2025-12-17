using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISupplierService
    {
        List<Supplier> GetAllRecord();
        Supplier GetRecordById(Guid id);

        void AddRecord(Supplier entity);
        void UpdateRecord(Supplier entity);
        void DeleteRecord(Guid id);
    }
}
