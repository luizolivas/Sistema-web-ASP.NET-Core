using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PessoalMvcSales.Models;

namespace PessoalMvcSales.Data
{
    public class PessoalMvcSalesContext : DbContext
    {
        public PessoalMvcSalesContext (DbContextOptions<PessoalMvcSalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
