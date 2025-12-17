using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllRecord();
        Customer GetRecordById(Guid id);

        void AddRecord(Customer entity);
        void UpdateRecord(Customer entity);
        void DeleteRecord(Guid id);
    }
}
