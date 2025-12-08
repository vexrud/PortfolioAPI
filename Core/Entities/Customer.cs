using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Müşterilerin temel bilgileri
    /// </summary>
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    //<-- CompanyName
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }

        //City entity id
        public Guid? CityID { get; set; }
        //City EntityReferance
        public City City { get; set; } 

        //District entity id
        public Guid? DistrictID {  get; set; }
        //District EntityReferance
        public District District { get; set; }
        public string PostalCode { get; set; }

        //Country entity id
        public Guid? CountryID { get; set; }
        public Country Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
