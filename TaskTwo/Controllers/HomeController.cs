﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskTwo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AmazonTrans()
        {


            return View();
        }
        public IActionResult EbayTrans()
        {


            return View();
        }
        public IActionResult EbayIndex()
        {


            return View();
        }
    }
}