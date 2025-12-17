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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public void AddRecord(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void DeleteRecord(Guid id)
        {
            var record = GetRecordById(id);

            if (record == null)
            {
                throw new Exception("Kayıt bulunamadı.");
            }

            record.IsDeleted = true;
            record.UpdatedDate = DateTime.Now;
            _categoryDal.Update(record);           
        }

        public List<Category> GetAllRecord()
        {
            return _categoryDal.GetAll();
        }

        public Category GetRecordById(Guid id)
        {
            return _categoryDal.Get(c => c.Id == id);
        }

        public void UpdateRecord(Category entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _categoryDal.Update(entity);
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
