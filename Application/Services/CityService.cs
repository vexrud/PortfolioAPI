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
        private readonly ICityDal _cityRepository;

        public CityService(ICityDal cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void AddRecord(City entity)
        {
            _cityRepository.Add(entity);   
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
            
            _cityRepository.Update(record);
        }

        public List<City> GetAllRecord()
        {
            return _cityRepository.GetAll();
        }

        public City GetRecordById(Guid id)
        {
            return _cityRepository.Get(c => c.Id == id);
        }

        public void UpdateRecord(City entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _cityRepository.Update(entity);
        }
    }
}
