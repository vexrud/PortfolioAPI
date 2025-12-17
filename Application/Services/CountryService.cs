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
    public class CountryService : ICountryService
    {
        private readonly ICountryDal _countryDal;

        public CountryService(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public void AddRecord(Country entity)
        {
            _countryDal.Add(entity);
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
            _countryDal.Update(record);
        }

        public List<Country> GetAllRecord()
        {
            return _countryDal.GetAll();
        }

        public Country GetRecordById(Guid id)
        {
            return _countryDal.Get(c => c.Id == id);
        }

        public void UpdateRecord(Country entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _countryDal.Update(entity);
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
