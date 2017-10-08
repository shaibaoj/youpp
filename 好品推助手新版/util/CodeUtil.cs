using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace haopintui.util
{
    public class CodeUtil
    {
        public static void alimama_plan(CmsForm cmsForm){

            WebRequest request = WebRequest.Create("http://pin.aliyun.com/get_img?identity=sm-union-pub&sessionid=2d0bdcb6e845f17f411131dec335731e&type=number&t=1497600133993");
            WebResponse response = request.GetResponse();
            Stream st = response.GetResponseStream();
            Bitmap bitmap = (Bitmap)Bitmap.FromStream(st);
            UnCodebase ud = new UnCodebase(bitmap);
            bitmap = ud.GrayByPixels();
            ud.ClearNoise(128, 2);

            //pictureBox1.Image = bitmap;

            tessnet2.Tesseract ocr = new tessnet2.Tesseract();//声明一个OCR类
            ocr.SetVariable("tessedit_char_whitelist", "0123456789"); //设置识别变量，当前只能识别数字。
            ocr.Init(cmsForm.app_path + @"\\tmpe", "eng", true); //应用当前语言包。注，Tessnet2是支持多国语的。语言包下载链接：http://code.google.com/p/tesseract-ocr/downloads/list
            List<tessnet2.Word> result = ocr.DoOCR(bitmap, Rectangle.Empty);//执行识别操作
            string code = result[0].Text;
            //textBox1.Text = code;

            LogUtil.log_call(cmsForm,"code:" + code);

        }

    }
}
