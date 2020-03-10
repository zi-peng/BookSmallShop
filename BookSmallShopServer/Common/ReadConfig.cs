using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSmallShopServer.Common
{
    /// <summary>
    /// 读取配置文件信息（第二种方法）
    /// </summary>
    public class ReadConfig
    {
        public static string ReadAppSettings_File(string content)
        {
            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                return configuration[content];
            }
            catch
            {

                return "";
            }
        }
    }
}
