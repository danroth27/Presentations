using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ResponseCachingSample.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("[action]")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        [ResponseCache(Duration = 5)]
        public IActionResult CachedIndex()
        {
            return View();
        }
    }
}
