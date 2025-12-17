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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierDal _supplierDal;

        public SupplierService(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void AddRecord(Supplier entity)
        {
            _supplierDal.Add(entity);
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

            _supplierDal.Update(record);
        }

        public List<Supplier> GetAllRecord()
        {
            return _supplierDal.GetAll();
        }

        public Supplier GetRecordById(Guid id)
        {
            return _supplierDal.Get(s => s.Id == id);
        }

        public void UpdateRecord(Supplier entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _supplierDal.Update(entity);
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
