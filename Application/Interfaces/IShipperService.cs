using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IShipperService
    {
        List<Shipper> GetAllRecord();
        Shipper GetRecordById(Guid id);

        void AddRecord(Shipper entity);
        void UpdateRecord(Shipper entity);
        void DeleteRecord(Guid id);
    }
}
