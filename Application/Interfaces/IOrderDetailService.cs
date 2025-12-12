using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderDetailService
    {
        List<Category> GetAllRecord();
        Category GetRecordById(Guid id);

        void AddRecord(Category entity);
        void UpdateRecord(Category entity);
        void DeleteRecord(Guid id);
    }
}
