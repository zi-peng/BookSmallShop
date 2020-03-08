using System;
using System.Collections.Generic;
using System.Text;

namespace BookSmallShopServer.DatabaseTable
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class T_PersonalCenter_User
    {
        public int ID { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTIme { get; set; }
    }
}
