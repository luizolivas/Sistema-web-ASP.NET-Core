using PessoalMvcSales.Data;
using PessoalMvcSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PessoalMvcSales.Services.Exceptions;


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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any( x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id Not Found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex) 
            {
                throw new DbConcurrencyException(ex.Message);
            }

        }
    }
}
