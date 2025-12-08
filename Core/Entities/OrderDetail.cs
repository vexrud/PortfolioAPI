using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Sipariş detay bilgileri yer alır
    /// </summary>
    public class OrderDetail : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //Order entity id
        public Guid? OrderID { get; set; }
        public Order Order { get; set; }

        //Product entity id
        public Guid? ProductID { get; set; }
        public Product Product { get; set; }

        //Shipper entity id
        public Guid? ShipperID { get; set; }
        public Shipper Shipper { get; set; }

        public decimal? CargoLength { get; set; }
        public decimal? CargoWidth { get; set; }
        public decimal? CargoWeight { get; set; }

        public int? UnitCount { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalPrice { get; set; } //UnitPrice * UnitCount
        public double? Discount { get; set; }   //İndirim çeki yüzdesel hesaplanacak.

        public DateTime? DeliveryDate { get; set; } //<-- Teslimat tarihi
        public DateTime? ShippedDate { get; set; }  //<-- Kargolanma tarihi
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
