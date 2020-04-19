using CoreApi.IService;

namespace CoreApi.Service
{
    public class Demo : IDemo
    {
        public string GetMessage()
        {
            return "使用ASP.NET Core 3.x 构建 RESTful API";
        }
    }
}
