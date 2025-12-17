using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAllRecord();
        OrderDetail GetRecordById(Guid id);

        void AddRecord(OrderDetail entity);
        void UpdateRecord(OrderDetail entity);
        void DeleteRecord(Guid id);
    }
}
