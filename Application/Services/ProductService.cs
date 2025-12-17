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
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void AddRecord(Product entity)
        {
            _productDal.Add(entity);
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

            _productDal.Update(record);
        }

        public List<Product> GetAllRecord()
        {
            return _productDal.GetAll();
        }

        public Product GetRecordById(Guid id)
        {
            return _productDal.Get(p =>  p.Id == id);
        }

        public void UpdateRecord(Product entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _productDal.Update(entity);
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
