using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneClickInventory.Data;
using OneClickInventory.Models;

namespace OneClickInventory.Controllers
{
    
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = Pages.MainMenu.Dashboard.RoleName)]
        public async Task<IActionResult> Index()
        {
            List<ProductType> ProductTypes = await _context.ProductType.ToListAsync();
            int ProductTypeCount = ProductTypes.Count();
            ViewBag.ProductTypeCount = ProductTypeCount.ToString("C0");

            List<Product> Products = await _context.Product.Where(x => x.DomainStatus == true).ToListAsync();
            int ProductCount = Products.Count();
            ViewBag.ProductCount = ProductCount.ToString("C0");

            List<SalesOrder> SalesOrders = await _context.SalesOrder.ToListAsync();
            int SalesOrderCount = SalesOrders.Count();
            ViewBag.ProductCount = ProductCount.ToString("C0");



            return View();
        }
    }
}