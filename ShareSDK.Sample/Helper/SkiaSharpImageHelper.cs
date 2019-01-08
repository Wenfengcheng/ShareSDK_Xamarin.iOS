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
    }
}
