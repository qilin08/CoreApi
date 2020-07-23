/*********************************************************************************** 
 *   Filename :HomeController  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using CoreApi.Entity;
using CoreApi.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly MYSQLDbContext _context;

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
