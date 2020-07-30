using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZweiTwech.API.Models;

namespace ZweiTwech.API.Data
{
    public class ZweiTechDbContext : DbContext
    {
        public ZweiTechDbContext(DbContextOptions<ZweiTechDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
