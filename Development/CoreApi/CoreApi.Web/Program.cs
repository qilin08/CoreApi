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
    }
}
