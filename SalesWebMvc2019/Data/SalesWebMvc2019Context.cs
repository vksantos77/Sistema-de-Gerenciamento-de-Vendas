using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2019.Models;

namespace SalesWebMvc2019.Data
{
    public class SalesWebMvc2019Context : DbContext
    {
        public SalesWebMvc2019Context (DbContextOptions<SalesWebMvc2019Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc2019.Models.Department> Department { get; set; }
    }
}
