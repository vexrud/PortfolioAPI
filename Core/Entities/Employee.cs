using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Çalışan personellerin temel bilgileri
    /// </summary>
    public class Employee : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public EmployeeTitle Title { get; set; }
        public TitleOfCourtesy TitleOfCourtesy { get; set; } //<-- Nezaket Unvanı Mr. Mrs. gibi
        public Gender Gender { get; set; }  
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }

        //City entity id
        public Guid? CityID { get; set; }
        public City City { get; set; }

        //District entity id
        public Guid? DistrictID { get; set; }
        public District District { get; set; }

        //Country entity id
        public Guid? CountryID { get; set; }
        public Country Country { get; set; }

        public string PostalCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Information1 { get; set; }
        public string Information2 { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    public enum EmployeeTitle
    {
        Unknown = 0,
        Owner = 1,
        Staff = 2,
        Engineer = 3,
        First_Air_Specialist = 4,
        Accounting_Staff = 5,
        Marketing_Staff = 6,
        Manager = 7,
        Team_Leader = 8,
    }

    public enum TitleOfCourtesy
    {
        Unknown = 0,
        Mr = 1,
        Mrs = 2
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2,
    }
}
