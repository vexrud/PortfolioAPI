using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Ürüne ait temel bilgiler
    /// </summary>
    public class Product : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //Supplier entity id
        public Guid? SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        //Category entity id
        public Guid? CategoryID { get; set; }
        public Category Category { get; set; }

        public string QuantityPerUnit { get; set; } //<-- Bir birimdeki miktar
        public decimal? UnitPrice { get; set; } //<-- Bir birim fiyatı
        public int? UnitsInStock { get; set; }  //<-- Stoktaki birim adeti
        public int? UnitsOnOrder { get; set; }  //<-- Sipariş edilen birim miktari
        public int? ReorderLevel { get; set; }  //<-- Yeniden sipariş edilme düzeyi *Bu alan gereksiz olabilir bu yüzden kaldırılabilir

        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
