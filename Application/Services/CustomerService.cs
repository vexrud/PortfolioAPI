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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void AddRecord(Customer entity)
        {
            _customerDal.Add(entity);
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

            _customerDal.Update(record);
        }

        public List<Customer> GetAllRecord()
        {
            return _customerDal.GetAll();
        }

        public Customer GetRecordById(Guid id)
        {
            return _customerDal.Get(c => c.Id == id);
        }

        public void UpdateRecord(Customer entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _customerDal.Update(entity);
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
