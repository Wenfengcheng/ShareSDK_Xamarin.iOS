using System;
using ShareSDK;
using ShareSDK.UI;
using FFImageLoading.Forms;
using ShareSDK.Sample.Helper;
using UIKit;
using Foundation;
using SkiaSharp;
using System.Collections.Generic;
using FFImageLoading;
using CoreGraphics;

namespace ShareSDK.Sample
{
    public partial class ViewController : UIViewController
    {
        UIButton button;
        UIImageView imageView;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Black Page";
            this.View.BackgroundColor = UIColor.Black;
            Console.WriteLine(ShareSDK_Base.SdkVersion);

            //imageView = new UIImageView()
            //{
            //    ContentMode = UIViewContentMode.ScaleAspectFit,
            //    Frame = this.View.Bounds
            //};
            //ImageService.Instance.LoadUrl("https://bopodastoragestaging.blob.core.chinacloudapi.cn/himedia-content/3d357563-1970-b524-6ddf-6847926c1d6f.jpg").Into(imageView);
            //this.View.AddSubview(imageView);
            button = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 300 ) / 4, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 100, 100)
            };
            button.SetTitle("Text", UIControlState.Normal);
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.TouchUpInside += (sender, e) =>
            {
                ShareMenu();
            };
            this.View.AddSubview(button);

            UIButton imagebutton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 100 ) / 2, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 100, 100)
            };
            imagebutton.SetTitle("Image", UIControlState.Normal);
            imagebutton.SetTitleColor(UIColor.White, UIControlState.Normal);
            imagebutton.TouchUpInside += (sender, e) =>
            {
                ShareImage();
            };
            this.View.AddSubview(imagebutton);


            UIButton miniProgrambutton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect((3* UIScreen.MainScreen.Bounds.Width - 100) / 4, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 100, 100)
            };
            miniProgrambutton.SetTitle("MiniProgram", UIControlState.Normal);
            miniProgrambutton.SetTitleColor(UIColor.White, UIControlState.Normal);
            miniProgrambutton.TouchUpInside += (sender, e) =>
            {
                ShareMiniProgram();
            };
            this.View.AddSubview(miniProgrambutton);


            // Perform any additional setup after loading the view, typically from a nib.
        }

        private NSData CompressWithMaxLength(NSData imageData, nuint maxSize)
        {
            // Compress by quality
            nfloat compression = 1;
            UIImage image = UIImage.LoadFromData(imageData);
            Console.WriteLine("Before compressing quality, image size ={0} KB", imageData.Length / 1024f);
            if (imageData.Length / 1024 <= maxSize) return imageData;

            //获取原图片宽高比
            nfloat sourceImageAspectRatio = image.Size.Width / image.Size.Height;
            CGSize defaultSize = CGSize.Empty;
            if (image.Size.Width > 1024)
                defaultSize = new CGSize(1024, 1024 / sourceImageAspectRatio);
            else
                defaultSize = image.Size;

            UIImage newImage = this.ReSizeImage(defaultSize, image);
            imageData = newImage.AsJPEG(1.0f);
            Console.WriteLine("Resize image quality, image size ={0} KB", imageData.Length / 1024f);
            if (imageData.Length / 1000 < maxSize) return imageData;

            List<nfloat> compressionQualityArr = new List<nfloat>();
            nfloat avg = 1.0f / 250;
            nfloat value = avg;
            for (int i = 250; i >= 1; i--)
            {
                value = i * avg;
                compressionQualityArr.Add(value);
            }
            /*
             调整大小
             说明：压缩系数数组compressionQualityArr是从大到小存储。
             */
            //思路：使用二分法搜索
            imageData = this.HalfFuntion(compressionQualityArr.ToArray(), newImage, imageData, maxSize);
            Console.WriteLine("Half Funtion image quality, image size ={0} KB", imageData.Length / 1024f);

            //如果还是未能压缩到指定大小，则进行降分辨率
            while (imageData.Length == 0)
            {
                //每次降100分辨率
                nfloat reduceWidth = 100.0f;
                nfloat reduceHeight = 100.0f / sourceImageAspectRatio;
                if (defaultSize.Width - reduceWidth <= 0 || defaultSize.Height - reduceHeight <= 0)
                {
                    break;
                }
                defaultSize = new CGSize(defaultSize.Width - reduceWidth, defaultSize.Height - reduceHeight);
                UIImage finalImage = this.ReSizeImage(defaultSize, UIImage.LoadFromData(newImage.AsJPEG(compressionQualityArr[compressionQualityArr.Count - 1])));
                imageData = this.HalfFuntion(compressionQualityArr.ToArray(), finalImage, finalImage.AsJPEG(1), maxSize);
            }
            return imageData;
        }

        private UIImage ReSizeImage(CGSize size, UIImage image)
        {
            CGSize newSize = new CGSize(image.Size.Width, image.Size.Height);
            nfloat tempHeight = newSize.Height / size.Height;
            nfloat tempWidth = newSize.Width / size.Width;

            if (tempWidth > 1.0 && tempWidth >= tempHeight)
            {
                newSize = new CGSize(image.Size.Width / tempWidth, image.Size.Height / tempWidth);
            }
            else if (tempHeight > 1.0 && tempWidth <= tempHeight)
            {
                newSize = new CGSize(image.Size.Width / tempHeight, image.Size.Height / tempHeight);
            }

            UIGraphics.BeginImageContext(newSize);
            image.Draw(new CGRect(0, 0, newSize.Width, newSize.Height));
            UIImage newImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return newImage;
        }

        private NSData HalfFuntion(nfloat[] arr, UIImage image, NSData data, nuint maxSize)
        {
            NSData tempData = new NSData();
            nuint start = 0;
            nuint end = (nuint)arr.Length - 1;
            nuint index = 0;
            nuint difference = nuint.MaxValue;

            while (start <= end)
            {
                index = start + (end - start) / 2;
                data = image.AsJPEG(arr[index]);
                nuint sizeOrigin = data.Length;
                nuint sizeOriginKB = sizeOrigin / 1024;
                //NSLog(@"当前降到的质量：%ld", (unsigned long)sizeOriginKB);
                //NSLog(@"\nstart：%zd\nend：%zd\nindex：%zd\n压缩系数：%lf", start, end, (unsigned long)index, [arr[index] floatValue]);

                if (sizeOriginKB > maxSize)
                {
                    start = index + 1;
                }
                else if (sizeOriginKB < maxSize)
                {
                    if (maxSize - sizeOriginKB < difference)
                    {
                        difference = maxSize - sizeOriginKB;
                        tempData = data;
                    }
                    if (index <= 0)
                    {
                        break;
                    }
                    end = index - 1;
                }
                else
                {
                    break;
                }
            }
            return tempData;
        }

        private void ShareMenu()
        {
            NSMutableDictionary shareParams = new NSMutableDictionary();

            shareParams.SSDKSetupShareParamsByText("Test Share", 
                                                   new NSString("https://msyunkestaging.blob.core.chinacloudapi.cn/himedia-content/a1a5aebc-bfdb-8e6c-7e98-ba635af70616.png"), 
                                                   new NSUrl("https://www.baidu.com"),
                                                   "Test Share", 
                                                   SSDKContentType.Image);
                                                 
            List<NSObject> items = new List<NSObject>()
            {
                NSNumber.FromUInt64((ulong)SSDKPlatformType.WechatSession),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.WechatTimeline),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.SinaWeibo),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.QQFriend),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.QZone),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.LinkedIn)
            };

            SSUIPlatformItem saveItem = new SSUIPlatformItem()
            {
                IconNormal = UIImage.FromFile("album"),
                IconSimple = UIImage.FromFile("album"),
                PlatformName = "存入相册",
                PlatformId = "save"
            };
            saveItem.AddTarget(this, new ObjCRuntime.Selector("saveImage"));
            items.Add(saveItem);

            SSUIPlatformItem copyItem = new SSUIPlatformItem()
            {
                IconNormal = UIImage.FromFile("album"),
                IconSimple = UIImage.FromFile("album"),
                PlatformName = "复制链接",
                PlatformId = "copy"
            };
            copyItem.AddTarget(this, new ObjCRuntime.Selector("copyLink"));
            items.Add(copyItem);

            SSUIPlatformItem moreItem = new SSUIPlatformItem()
            {
                IconNormal = UIImage.FromFile("album"),
                IconSimple = UIImage.FromFile("album"),
                PlatformName = "更多",
                PlatformId = "more"
            };
            moreItem.AddTarget(this, new ObjCRuntime.Selector("systemShare"));
            items.Add(moreItem);

            SSUIShareSheetConfiguration configuration = new SSUIShareSheetConfiguration()
            {
                Style = SSUIActionSheetStyle.Simple,
                DirectSharePlatforms = items.ToArray()
            };

            ShareSDKHelper.Instance.ShowShareActionSheet(view:null,
                                                         items: items.ToArray(),
                                                shareParams:shareParams,
                                                configuration: configuration,
                                             stateChangedHandler: (state, platformType, userData, contentEntity, error, end) =>
                                            {
                                                    switch(state)
                                                    {
                                                        case SSDKResponseState.Begin:
                                                            break;
                                                        case SSDKResponseState.Success:
                                                            UIAlertController alert = UIAlertController.Create("Share Success", null, UIAlertControllerStyle.Alert);
                                                            UIAlertAction action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                                                            alert.AddAction(action);
                                                            this.PresentViewController(alert, true, null);
                                                            break;
                                                        case SSDKResponseState.Fail:
                                                            UIAlertController alert1 = UIAlertController.Create("Share Failed", null, UIAlertControllerStyle.Alert);
                                                            UIAlertAction action1 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                                                            alert1.AddAction(action1);
                                                            this.PresentViewController(alert1, true, null);
                                                            break;
                                                        case SSDKResponseState.Cancel:
                                                            UIAlertController alert2 = UIAlertController.Create("Share Cancel", null, UIAlertControllerStyle.Alert);
                                                            UIAlertAction action2 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                                                            alert2.AddAction(action2);
                                                            this.PresentViewController(alert2, true, null);
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                            }
                                            );

        }

        [Export("saveImage")]
        void SaveImage()
        {

        }

        [Export("copyLink")]
        void CopyLink()
        {

        }

        [Export("systemShare")]
        void SystemShare()
        {

        }

        private async void ShareImage()
        {
            NSMutableDictionary shareParams = new NSMutableDictionary();

            //NSArray images = NSArray.FromObjects("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1522154322305&di=7f4bf3d0803fe8c2c66c140f0a6ea0b4&imgtype=0&src=http%3A%2F%2Fa4.topitme.com%2Fo%2F201007%2F29%2F12803876734174.jpg");
            NSData image = null;

            SkiaSharp.SKBitmap back = await SkiaSharpImageHelper.LoadWebImage("https://msyunkestaging.blob.core.chinacloudapi.cn/himedia-content/a1a5aebc-bfdb-8e6c-7e98-ba635af70616.png");
            SkiaSharp.SKBitmap ima = await SkiaSharpImageHelper.LoadWebImage("https://msyunkestaging.blob.core.chinacloudapi.cn/himedia-content/fdc0d632-fcc0-338f-0643-a2bef04964f2.jpg");

            int width = back.Width;
            int height = back.Height;

            try
            {
                using (var tempSurface = SKSurface.Create(new SKImageInfo(width, height)))
                using (var paint = new SKPaint()
                {
                    Style = SKPaintStyle.Fill,
                    Color = SKColors.White,
                })
                using(var textPaint = new SKPaint()
                {
                    Color = SKColors.Black,
                    IsAntialias = true,
                    TextSize = 34,
                    TextAlign = SKTextAlign.Center,
                    FakeBoldText = true,
                    Typeface = SKFontManager.Default.MatchCharacter("Courier New", '中')
                })
                {
                    var canvas = tempSurface.Canvas;

                    canvas.Clear(SKColors.Transparent);

                    string str1 = "美女与IT兽 | Seeed：做物联网应用别";
                    string str2 = "再把时间花在硬件研发上";

                    float xText = width / 2;
                    float yText = (722 + 918) / 2;

                    canvas.DrawBitmap(back, SKRect.Create(0, 0, width, height));
                    canvas.DrawRoundRect(SKRect.Create(32, 420, width - 64, 498), 10, 10, paint);
                    canvas.DrawBitmap(ima, SKRect.Create(32, 420, width - 64, 302));
                    canvas.DrawText(str1, xText, yText, textPaint);
                    canvas.DrawText(str2, xText, yText + 50, textPaint);

                    image = NSData.FromArray(tempSurface.Snapshot().Encode().ToArray());
                }
            }
            catch (Exception ex)
            {

            }

            shareParams.SSDKSetupWeChatParamsByText("https://www.baidu.com",
                                                    "-----------",
                                                    null,
                                                    new NSString("image1.jpg"),
                                                    UIImage.FromFile("image1.jpg"),
                                                    null,
                                                    null,
                                                    null,
                                                    null,
                                                    null,
                                                    null,
                                                    SSDKContentType.Image,
                                                     SSDKPlatformType.WechatSession);
            ShareSDKHelper.ShareParams(shareParams, SSDKPlatformType.WechatSession);
        }

        private async void ShareMiniProgram()
        {
            UIImage videoImage = null;
            using(System.IO.Stream stream = await SkiaSharpImageHelper.LoadImageStream("https://bopodastoragestaging.blob.core.chinacloudapi.cn/himedia-content/63eab63c-f827-6b6a-4f62-23af0502fca0.jpg"))
            {
                NSMutableDictionary shareParams = new NSMutableDictionary();
                //videoImage = UIImage.LoadFromData(NSData.FromStream(stream));
                NSData finalData = CompressWithMaxLength(NSData.FromStream(stream), 100);

                shareParams.SSDKSetupWeChatMiniProgramShareParamsByTitle("NET Core 1.1的新增特性",
                                                                         "<p>通过今天的活动，您将了解到科技助力各行各业提高效率成就的不凡之旅。如果您对人工智能，大数据，混合现实，物联网，云计算等最新数字科技在各行业应用感兴趣的话，我们的精心准备一定会使您不虚此行。</p>",
                                                                         NSUrl.FromString("http://mob.com"),
                                                                         $"pages/video/video?scene=209&tenancyName=Demo&isLiveVideo=true",
                                                                         null,
                                                                         finalData,
                                                                         "gh_9c9c75154329",
                                                                         true,
                                                                         0,
                                                                         SSDKPlatformType.WechatSession);
                ShareSDKHelper.ShareParams(shareParams, SSDKPlatformType.WechatSession, (state, userData, contentEntity, error) =>
                {
                    switch (state)
                    {
                        case SSDKResponseState.Begin:
                            break;
                        case SSDKResponseState.Success:
                            UIAlertController alert = UIAlertController.Create("Share Success", null, UIAlertControllerStyle.Alert);
                            UIAlertAction action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                            alert.AddAction(action);
                            this.PresentViewController(alert, true, null);
                            break;
                        case SSDKResponseState.Fail:
                            UIAlertController alert1 = UIAlertController.Create("Share Failed", null, UIAlertControllerStyle.Alert);
                            UIAlertAction action1 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                            alert1.AddAction(action1);
                            this.PresentViewController(alert1, true, null);
                            break;
                        case SSDKResponseState.Cancel:
                            UIAlertController alert2 = UIAlertController.Create("Share Cancel", null, UIAlertControllerStyle.Alert);
                            UIAlertAction action2 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                            alert2.AddAction(action2);
                            this.PresentViewController(alert2, true, null);
                            break;
                        default:
                            break;
                    }
                });
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
