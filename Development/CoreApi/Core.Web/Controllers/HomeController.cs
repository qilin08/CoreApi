using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]")]
        public string Index()
        {
            return string.Format("使用ASP.NET Core 3.x 构建 RESTful API - {0}",DateTime.Now);
        }
    }
}
