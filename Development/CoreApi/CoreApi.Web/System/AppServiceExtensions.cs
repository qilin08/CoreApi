using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CoreApi.Web.System
{
    public static class AppServiceExtensions
    {
        /// <summary>
        /// 注册应用程序域中的服务
        /// </summary>
        /// <param name="services"></param>
        public static void AddAppServices(this IServiceCollection services)
        {
            var ts = Assembly.Load("CoreApi.Service").GetTypes().ToArray();
            foreach (var item in ts.Where(s => !s.IsInterface))
            {
                var interfaceType = item.GetInterfaces();
                foreach (var typeArray in interfaceType)
                {
                    services.AddTransient(typeArray, item);
                }
            }
        }
    }
}
