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
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictDal _districtDal;

        public DistrictService(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }


        public void AddRecord(District entity)
        {
            _districtDal.Add(entity);
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

            _districtDal.Update(record);
        }

        public List<District> GetAllRecord()
        {
            return _districtDal.GetAll();
        }

        public District GetRecordById(Guid id)
        {
            return _districtDal.Get(d => d.Id == id);
        }

        public void UpdateRecord(District entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _districtDal.Update(entity);
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
