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
    public class CityService : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void AddRecord(City entity)
        {
            _cityDal.Add(entity);   
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

            _cityDal.Update(record);
        }

        public List<City> GetAllRecord()
        {
            return _cityDal.GetAll();
        }

        public City GetRecordById(Guid id)
        {
            return _cityDal.Get(c => c.Id == id);
        }

        public void UpdateRecord(City entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _cityDal.Update(entity);
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
