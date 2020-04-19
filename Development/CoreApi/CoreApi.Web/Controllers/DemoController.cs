using System;
using CoreApi.IService;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly IDemo _demo;

        public DemoController(IDemo demo)
        {
            _demo = demo ?? throw new ArgumentNullException(nameof(demo));
        }

        [HttpGet("[action]")]
        public string GetMessage()
        {
            var result = _demo.GetMessage();
            return result;
        }

        [HttpGet("[action]")]
        public string GetMessages()
        {
            return "测试路由多个端点！";
        }
    }
}
