using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Entity;
using CoreApi.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly MYSQLDbContext _context;

        //注入MoviesContext
        public HomeController(MYSQLDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public string Index()
        {
            return string.Format("使用ASP.NET Core 3.x 构建 RESTful API - {0}",DateTime.Now);
        }

        [HttpGet("[action]")]
        public List<Disease> GetDiseases()
        {
            return _context.Disease.ToList();
        }
    }
}
