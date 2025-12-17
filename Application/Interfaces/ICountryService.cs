using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICountryService
    {
        List<Country> GetAllRecord();
        Country GetRecordById(Guid id);

        void AddRecord(Country entity);
        void UpdateRecord(Country entity);
        void DeleteRecord(Guid id);
    }
}
