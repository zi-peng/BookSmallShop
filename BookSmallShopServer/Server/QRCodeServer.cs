using System;
using System.Collections.Generic;
using System.Text;
using ZXing;
using ZXing.Mobile;
using ZXing.QrCode;
using System.Drawing;
using System.Drawing.Imaging;
namespace BookSmallShopServer.Server
{
    /// <summary>
    /// 字符串生成二维码
    /// </summary>
    public class QRCodeServer
    {
        public static string QRCode(string text, string width, string heigh)
        {
            try
            {
                //BarcodeWriter writer = new BarcodeWriter();

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
