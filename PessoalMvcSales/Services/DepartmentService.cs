using Microsoft.AspNetCore.Mvc;
using PessoalMvcSales.Data;
using PessoalMvcSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoalMvcSales.Services
{
    public class DepartmentService : Controller
    {
        private readonly PessoalMvcSalesContext _context;

        public DepartmentService(PessoalMvcSalesContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
