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
    public class ShipperService : IShipperService
    {
        private readonly IShipperDal _shipperDal;

        public ShipperService(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal;
        }

        public void AddRecord(Shipper entity)
        {
            _shipperDal.Add(entity);
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

            _shipperDal.Update(record);
        }

        public List<Shipper> GetAllRecord()
        {
            return _shipperDal.GetAll();
        }

        public Shipper GetRecordById(Guid id)
        {
            return _shipperDal.Get(s => s.Id == id);
        }

        public void UpdateRecord(Shipper entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _shipperDal.Update(entity);
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
