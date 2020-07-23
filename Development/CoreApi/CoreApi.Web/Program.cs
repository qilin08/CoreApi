/*********************************************************************************** 
 *   Filename :Program  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreApi.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            //using (var scope = host.Services.CreateScope())
            //{
            //    try
            //    {
            //        var dbContext = scope.ServiceProvider.GetService<CoreDbContext>();

            //        dbContext.Database.EnsureDeleted();
            //        dbContext.Database.Migrate();
            //    }
            //    catch (Exception e)
            //    {
            //        var logger = scope.ServiceProvider.GetService<ILogger<Program>>();
            //        logger.LogError(e,"迁移数据库时发生错误!");
            //    }
            //}

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        //.ConfigureLogging((context, loggingbuilder) =>
        //{
        //    ////该方法需要引入Microsoft.Extensions.Logging名称空间
        //    //loggingbuilder.AddFilter("System", LogLevel.Warning); //过滤掉系统默认的一些日志
        //    //loggingbuilder.AddFilter("Microsoft", LogLevel.Warning);//过滤掉系统默认的一些日志
        //    ////添加Log4Net
        //    ////var path = Directory.GetCurrentDirectory() + "\\log4net.config"; 
        //    ////不带参数：表示log4net.config的配置文件就在应用程序根目录下，也可以指定配置文件的路径
        //    //loggingbuilder.AddLog4Net();

        //    //var path = System.IO.Directory.GetCurrentDirectory();
        //    //loggingbuilder.AddLog4Net($"{path}/log4net.config");//配置文件

        //    loggingbuilder.AddLog4Net();
        //});
    }
}
