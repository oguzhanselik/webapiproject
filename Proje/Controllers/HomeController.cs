using Microsoft.AspNetCore.Mvc;
using System;

namespace Proje.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public String Index()
        {
            
            return "Welcome";
        }
    }
}
