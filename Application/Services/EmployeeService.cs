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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeService(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void AddRecord(Employee entity)
        {
            _employeeDal.Add(entity);
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

            _employeeDal.Update(record);
        }

        public List<Employee> GetAllRecord()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetRecordById(Guid id)
        {
            return _employeeDal.Get(e => e.Id == id);
        }

        public void UpdateRecord(Employee entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _employeeDal.Update(entity);
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
