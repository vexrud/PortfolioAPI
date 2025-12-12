using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICityService
    {
        List<City> GetAllRecord();
        City GetRecordById(Guid id);

        void AddRecord(City entity);
        void UpdateRecord(City entity);
        void DeleteRecord(Guid id);
    }
}
