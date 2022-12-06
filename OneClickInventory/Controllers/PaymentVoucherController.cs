﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OneClickInventory.Controllers
{
    [Authorize(Roles = Pages.MainMenu.PaymentVoucher.RoleName)]
    public class PaymentVoucherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}