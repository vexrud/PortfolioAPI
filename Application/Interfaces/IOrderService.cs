using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAllRecord();
        Order GetRecordById(Guid id);

        void AddRecord(Order entity);
        void UpdateRecord(Order entity);
        void DeleteRecord(Guid id);
    }
}
