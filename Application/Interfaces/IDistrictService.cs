using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDistrictService
    {
        List<District> GetAllRecord();
        District GetRecordById(Guid id);

        void AddRecord(District entity);
        void UpdateRecord(District entity);
        void DeleteRecord(Guid id);
    }
}
