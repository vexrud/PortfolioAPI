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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailService(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void AddRecord(OrderDetail entity)
        {
            _orderDetailDal.Add(entity);
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

            _orderDetailDal.Update(record);
        }

        public List<OrderDetail> GetAllRecord()
        {
            return _orderDetailDal.GetAll();
        }

        public OrderDetail GetRecordById(Guid id)
        {
            return _orderDetailDal.Get(o => o.Id == id);
        }

        public void UpdateRecord(OrderDetail entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _orderDetailDal.Update(entity);
        }

        /** TODO: Bu kısım Authorization oluşturulduktan sonra sadece sistem adminlerinin erişebileceği şekilde yapılacak.*/
        //public void HardDelete(Guid id)
        //{
        //    var record = _categoryDal.Get(c => c.Id == id);

        //    if (record == null)
        //    {
        //        throw new Exception("Kayıt bulunamadı.");
        //    }

        //    _categoryDal.Delete(record);
        //}
    }
}
