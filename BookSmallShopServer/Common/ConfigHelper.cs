using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookSmallShopServer.Common
{

    /// <summary>
    /// 读取配置文件信息（第一种方法）
    /// </summary>
    public class ConfigHelper
    {
        public static string GetValue(string RootKey, string Secendkey = "", string ThirdKey = "")
        {
            //添加 json 文件路径
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            //创建配置根对象
            var configurationRoot = builder.Build();
            //一级
            var rootValue = configurationRoot.GetSection(RootKey);
            //二级
            if (string.IsNullOrEmpty(Secendkey))
                return rootValue?.Value ?? "";
            var sv = rootValue.GetSection(Secendkey);
            //三级
            if (string.IsNullOrEmpty(ThirdKey))
                return sv?.Value ?? "";
            var tv = sv.GetSection(ThirdKey);
            return tv?.Value ?? "";
        }
    }
}
