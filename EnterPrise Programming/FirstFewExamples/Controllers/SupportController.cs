﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstFewExamples.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}