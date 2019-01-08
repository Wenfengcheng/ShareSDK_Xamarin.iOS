using System;
using ShareSDK.UI;
using ShareSDK;
using ShareSDK.Sample.Helper;
using UIKit;
using Foundation;
using SkiaSharp;
using System.Collections.Generic;

namespace ShareSDK.Sample
{
    public partial class ViewController : UIViewController
    {
        UIButton button;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Black Page";
            this.View.BackgroundColor = UIColor.Black;

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


        private void ShareMenu()
        {
            NSMutableDictionary shareParams = new NSMutableDictionary();

            shareParams.SSDKSetupShareParamsByText("Test Share", 
                                                   UIImage.FromFile("image1.jpg"), 
                                                   NSUrl.FromString("https://www.mob.com"), 
                                                   "Test Share Title", 
                                                   SSDKContentType.Auto);

            List<NSObject> items = new List<NSObject>()
            {
                NSNumber.FromUInt64((ulong)SSDKPlatformType.QQ),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.Wechat),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.SinaWeibo),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.SMS),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.Mail),
                NSNumber.FromUInt64((ulong)SSDKPlatformType.Copy),
            };

            ShareSDKHelper.Instance.ShowShareActionSheet(view:null,
                                                items: items.ToArray(),
                                                shareParams:shareParams,
                                                configuration:null,
                                             stateChangedHandler: (state, platformType, userData, contentEntity, error, end) =>
                                            {
                                                    switch(state)
                                                    {
                                                        case SSDKResponseState.Upload:
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
                                                    image,
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

        private void ShareMiniProgram()
        {
            NSMutableDictionary shareParams = new NSMutableDictionary();

            shareParams.SSDKSetupWeChatMiniProgramShareParamsByTitle("Mini Program",
                                                                     "test MiniProgram",
                                                                     NSUrl.FromString("http://mob.com"),
                                                                     "pages/index/index",
                                                                     new NSString("image1.jpg"),
                                                                     new NSString("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1522154322305&di=7f4bf3d0803fe8c2c66c140f0a6ea0b4&imgtype=0&src=http%3A%2F%2Fa4.topitme.com%2Fo%2F201007%2F29%2F12803876734174.jpg"),
                                                                     "gh_afb25ac019c9",
                                                                     true, 
                                                                     0,
                                                                     SSDKPlatformType.WechatSession);
            ShareSDKHelper.ShareParams(shareParams, SSDKPlatformType.WechatSession);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
