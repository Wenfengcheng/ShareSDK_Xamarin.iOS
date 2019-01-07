using System;
using ShareSDK.UI;
using ShareSDK;
using UIKit;
using Foundation;
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
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 250) / 2, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 100, 100)
            };
            button.SetTitle("Text", UIControlState.Normal);
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.TouchUpInside += (sender, e) =>
            {
                ShareMenu();
            };
            this.View.AddSubview(button);


            UIButton miniProgrambutton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width + 50) / 2, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 100, 100)
            };
            miniProgrambutton.SetTitle("Mini Program", UIControlState.Normal);
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

            new ShareSDK().ShowShareActionSheet(view:null,
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

            //ShareSDK.Share( SSDKPlatformType.Wechat, shareParams,(state, userData, contentEntity, error) => {
            //    switch(state)
            //    {
            //        case SSDKResponseState.Upload:
            //            break;
            //        case SSDKResponseState.Success:
            //            UIAlertController alert = UIAlertController.Create("Share Success", null, UIAlertControllerStyle.Alert);
            //            UIAlertAction action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
            //            alert.AddAction(action);
            //            this.PresentViewController(alert, true, null);
            //            break;
            //        case SSDKResponseState.Fail:
            //            UIAlertController alert1 = UIAlertController.Create("Share Failed", null, UIAlertControllerStyle.Alert);
            //            UIAlertAction action1 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
            //            alert1.AddAction(action1);
            //            this.PresentViewController(alert1, true, null);
            //            break;
            //        case SSDKResponseState.Cancel:
            //            UIAlertController alert2 = UIAlertController.Create("Share Cancel", null, UIAlertControllerStyle.Alert);
            //            UIAlertAction action2 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
            //            alert2.AddAction(action2);
            //            this.PresentViewController(alert2, true, null);
            //            break;
            //        default:
            //            break;
            //    }
            //});
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

            ShareSDK.Share(SSDKPlatformType.WechatSession, shareParams, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
