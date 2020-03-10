using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookSmallShopServer.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;

namespace BookSmallShop
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
            //注入service服务
            //注册Swagger服务
            services.AddSwaggerGen(x =>
            {
                // 添加文档信息
                //标题版本描述
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "CoreWebApi", Version = "v1" });
                #region  显示XML注释的代码
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //Core.Admin.webapi.xml是我的项目生成XML文档的后缀名,具体的以你项目为主
                var xmlPath = Path.Combine(basePath, "BookSmallShopWebAPI.xml");
                x.IncludeXmlComments(xmlPath);
                #endregion
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //启用Swagger中间件
            app.UseSwagger();

            //配置SwaggerUI
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "CoreWebApi");
            });
            app.UseMvc();
        }
    }
}
