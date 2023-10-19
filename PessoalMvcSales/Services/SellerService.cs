using PessoalMvcSales.Data;
using PessoalMvcSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PessoalMvcSales.Services
{
    public class SellerService
    {
        private readonly PessoalMvcSalesContext _context;

        public SellerService(PessoalMvcSalesContext context)
        {
            _context = context;
        }

        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }
    }
}
