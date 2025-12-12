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
        private readonly ICategoryDal _categoryRepository;

        public CategoryService(ICategoryDal categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public void AddRecord(Category entity)
        {
            _categoryRepository.Add(entity);
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
            _categoryRepository.Update(record);
            // _categoryRepository.Delete(record);  //Hard Delete            
        }

        public List<Category> GetAllRecord()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetRecordById(Guid id)
        {
            return _categoryRepository.Get(c => c.Id == id);
        }

        public void UpdateRecord(Category entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _categoryRepository.Update(entity);
        }
    }
}
