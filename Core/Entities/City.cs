using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Veritabanındaki şehir bilgileri *Bu sehirler ülkeler ile foreignKey ilişkisine sahip olmalıdır.
    /// </summary>
    public class City : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
