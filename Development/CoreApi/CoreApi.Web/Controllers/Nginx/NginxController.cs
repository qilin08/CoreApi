using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Web.Controllers.Nginx
{
    [Route("api/[controller]")]
    [ApiController]
    public class NginxController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return $"{HttpContext.Connection.LocalIpAddress.ToString()}:{HttpContext.Connection.LocalPort.ToString()}";
        }
    }
}
