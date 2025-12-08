using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Siparişe ait temel bilgiler
    /// </summary>
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //Customer entity id
        public Guid? CustomerID { get; set; }
        public Customer Customer { get; set; }

        //Employee entity id
        public Guid? EmployeeID { get; set; }
        public Employee Employee { get; set; }        

        //Shipper entity id
        public Guid? ShipperID { get; set; }
        public Shipper Shipper { get; set; }


        public DateTime? OrderDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
