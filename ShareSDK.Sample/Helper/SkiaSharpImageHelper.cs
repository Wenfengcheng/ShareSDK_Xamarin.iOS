using System;
using System.IO;
using System.Threading.Tasks;
using SkiaSharp;
using FFImageLoading;

namespace ShareSDK.Sample.Helper
{
    public class SkiaSharpImageHelper
    {
        public static async Task<SKBitmap> LoadWebImage(string imageUrl)
        {
            SKBitmap webBitmap = null;
            try
            {
                using(Stream stream = await ImageService.Instance.LoadUrl(imageUrl, cacheDuration: TimeSpan.FromDays(30)).AsPNGStreamAsync())
                {
                    //await stream.CopyToAsync(memoryStream);
                   //memoryStream.Seek(0, SeekOrigin.Begin);

                    webBitmap = SKBitmap.Decode(stream);
                }
                return webBitmap;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public static async Task<Stream> LoadImageStream(string imageUrl)
        {
            Stream imageStream = null;
            try
            {
                if (string.IsNullOrEmpty(imageUrl)) 
                {
                    return imageStream;
                }
                else if(imageUrl.Substring(0, 4) == "http")
                {
                    imageStream = await ImageService.Instance.LoadUrl(imageUrl, TimeSpan.FromDays(300)).AsJPGStreamAsync(100);
                }
                else 
                {
                    imageStream = await ImageService.Instance.LoadFile(imageUrl).AsJPGStreamAsync(100);
                }
                return imageStream;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
