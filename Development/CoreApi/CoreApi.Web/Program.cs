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
            //        logger.LogError(e,"Ǩ�����ݿ�ʱ��������!");
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
        //    ////�÷�����Ҫ����Microsoft.Extensions.Logging���ƿռ�
        //    //loggingbuilder.AddFilter("System", LogLevel.Warning); //���˵�ϵͳĬ�ϵ�һЩ��־
        //    //loggingbuilder.AddFilter("Microsoft", LogLevel.Warning);//���˵�ϵͳĬ�ϵ�һЩ��־
        //    ////���Log4Net
        //    ////var path = Directory.GetCurrentDirectory() + "\\log4net.config"; 
        //    ////������������ʾlog4net.config�������ļ�����Ӧ�ó����Ŀ¼�£�Ҳ����ָ�������ļ���·��
        //    //loggingbuilder.AddLog4Net();

        //    //var path = System.IO.Directory.GetCurrentDirectory();
        //    //loggingbuilder.AddLog4Net($"{path}/log4net.config");//�����ļ�

        //    loggingbuilder.AddLog4Net();
        //});
    }
}
