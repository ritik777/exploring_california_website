using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_BuildingBlocks.Controllers
{
    public class HomeController 
    {
        public String Index()
        {
            return "Hello";
        }
    }
}