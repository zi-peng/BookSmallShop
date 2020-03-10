using System;
using System.Collections.Generic;
using System.Text;

namespace BookSmallShopServer.Common
{
    public class ResultData
    {
        /// <summary>
        /// 返回的状态  
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 返回的数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 返回的文字信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 显示的条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
    }
}
