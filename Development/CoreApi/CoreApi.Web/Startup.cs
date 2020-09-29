/*********************************************************************************** 
 *   Filename :Startup  
 *   Date:2020/07/23 17:11:32 
 *   Machinename:DESKTOP-28ROJ1R 
 *   Created by: qlSun 
 *   Description : 
 * 
 *   ChangeLog: 
 *   2020/07/23 17:11:32: Created! 
 ************************************************************************************/
using System;
using System.IO;
using System.Reflection;
using CoreApi.Entity;
using CoreApi.IService.Email;
using CoreApi.Service.Email;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace CoreApi.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IEmail, Email>();

            // ����MySql���ݿ�
            services.AddDbContextPool<MYSQLDbContext>(options => options
                    .UseMySql(Configuration.GetConnectionString("MySqlContext"), mySqlOptions => mySqlOptions
                        // replace with your Server Version and Type
                        .ServerVersion(new ServerVersion(new Version(8, 0, 19), ServerType.MySql))
                    ));

            //services.AddDbContext<CoreDbContext>(options =>
            //{
            //    options.UseSqlite("Data Source = routine.db");
            //});

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1",
                    Description = "API�ĵ�����",
                    Contact = new OpenApiContact
                    {
                        Email = "934860498@qq.com",
                        Name = "������Ŀ",
                        //Url = new Uri("http://t.abc.com/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "BROOKE���֤",
                        //Url = new Uri("http://t.abc.com/")
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                x.IncludeXmlComments(xmlPath);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                x.RoutePrefix = "api";// �����Ϊ�գ�����·�����Ǹ�����/index.html������Ϊ�գ���ʾֱ���ڸ��������ʣ��뻻һ��·����ֱ��д���ּ��ɣ�����ֱ��дc.RoutePrefix = "swagger"; �����·��Ϊ ������/swagger/index.html

            });
        }
    }
}
