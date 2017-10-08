using System;
using System.Drawing;
using System.Drawing.Imaging;

public class ImageUtil
{
    public static void smethod_0(string pic_url, string path, float scale)
    {
        Image image = Image.FromFile(pic_url);
        int width = (int)(image.Size.Width * scale);
        int height = (int)(image.Size.Height * scale);
        Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.Transparent);
        graphics.DrawImage(image, new Rectangle(0, 0, width, height));
        bitmap.Save(path, ImageFormat.Jpeg);
    }
}

