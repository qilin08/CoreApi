using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreApi.Web.Controllers
{
    /// <summary>
    /// Redis缓存
    /// </summary>
    [Route("/Redis")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private IEasyCachingProvider cachingProvider;
        private IEasyCachingProviderFactory easyCachingProviderFactory;
        public RedisController(IEasyCachingProviderFactory cachingProviderFactory)
        {
            this.easyCachingProviderFactory = cachingProviderFactory;
            this.cachingProvider = cachingProviderFactory.GetCachingProvider("RedisExample");
        }

        [HttpGet("Demo")]
        public IActionResult SetRedisItem()
        {
            this.cachingProvider.Set("easycaching", "Hello World", expiration: TimeSpan.FromDays(1));
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult GetRedisItem()
        {
            var item = this.cachingProvider.Get<string>("easycaching");
            return Ok(item);
        }
    }
}
