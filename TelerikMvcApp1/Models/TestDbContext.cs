using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() : base(
            "Data Source=42.159.232.252;Initial Catalog=testdb;User id=sa;Password=Admin@12345")
        {

        }

        public DbSet<TestEntity> TestEntities { get; set; }
         
    }
}