using Application.Interfaces;
using Core.Entities;
using Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderService(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void AddRecord(Order entity)
        {
            _orderDal.Add(entity);
        }

        public void DeleteRecord(Guid id)
        {
            var record = GetRecordById(id);

            if(record == null)
            {
                throw new Exception("Kayıt bulunamadı.");
            }

            record.IsDeleted = true;
            record.UpdatedDate = DateTime.Now;

            _orderDal.Update(record);
        }

        public List<Order> GetAllRecord()
        {
            return _orderDal.GetAll();
        }

        public Order GetRecordById(Guid id)
        {
            return _orderDal.Get(o => o.Id == id);
        }

        public void UpdateRecord(Order entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _orderDal.Update(entity);
        }
    }
}
