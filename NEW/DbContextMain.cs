using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NEW
{
    public class DbContextMain : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TestDB;User Id=postgres;Password=saravana;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
