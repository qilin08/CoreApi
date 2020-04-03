using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.IService;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    [ApiController]
    [Route("api/Demo")]
    public class DemoController : ControllerBase
    {
        private readonly IDemo _demo;

        public DemoController(IDemo demo)
        {
            _demo = demo ?? throw new ArgumentNullException(nameof(demo));
        }

        [HttpGet]
        public string GetMessage()
        {
            var result = _demo.GetMessage();
            return result;
        }
    }
}
