﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JR.DevFw.Web.Example.Code.Controllers
{
    public class HomeController:Controller
    {
        public string Index()
        {
            return "hello,devfw!";
        }
    }
}