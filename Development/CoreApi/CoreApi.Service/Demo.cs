using System;
using Core.IService;

namespace Core.Service
{
    public class Demo : IDemo
    {
        public string GetMessage()
        {
            return "使用ASP.NET Core 3.x 构建 RESTful API";
        }
    }
}
