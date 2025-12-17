using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllRecord();
        Employee GetRecordById(Guid id);

        void AddRecord(Employee entity);
        void UpdateRecord(Employee entity);
        void DeleteRecord(Guid id);
    }
}
