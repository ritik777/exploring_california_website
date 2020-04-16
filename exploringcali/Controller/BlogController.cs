using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace MVC_BuildingBlocks.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "blog posts" };
        }

        [Route("blog/{year:min(1993)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            return new ContentResult { Content = string.Format("Year {0};Month {1}; Key {2};", year, month, key) };
        }
    }
}