using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Concrete
{
    /// <summary>
    /// EntityFramework kullanan veritabanı context yapıdır.
    /// DBContext : EntityFramework içerisinde gelen base context class'ıdır.
    /// </summary>
    public class CustomNorthwindContext : DbContext
    {
        //Step 1: Veritabanımın yolunu belirtmem gerekiyor. (OnConfiguring : Projenin hangi veritabanı ile ilişkili olduğunu belirtiyoruz.)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = VEXRUD\SQLEXPRESS; Integrated Security=True; Persist Security Info=False; Pooling=False; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=True;"); //ConnectionString kendi bilgisayarım
        }

        //Step 2: Sırasıyla hangi entity'in database üzerinde hangi table'a karşılık geleceğini DbSet Property ile belirtmek
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        
    }
}
