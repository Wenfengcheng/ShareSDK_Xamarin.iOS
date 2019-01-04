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
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 100) / 2, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 100, 100)
            };
            button.SetTitle(ShareSDK_Base.SdkVersion, UIControlState.Normal);
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.TouchUpInside += (sender, e) =>
            {
                ShareMenu();
            };
            

            this.View.AddSubview(button);
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
                                                        case (ulong)SSDKResponseState.Upload:
                                                            break;
                                                        case (ulong)SSDKResponseState.Success:
                                                            UIAlertController alert = UIAlertController.Create("Share Success", null, UIAlertControllerStyle.Alert);
                                                            UIAlertAction action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                                                            alert.AddAction(action);
                                                            this.PresentViewController(alert, true, null);
                                                            break;
                                                        case (ulong)SSDKResponseState.Fail:
                                                            UIAlertController alert1 = UIAlertController.Create("Share Failed", null, UIAlertControllerStyle.Alert);
                                                            UIAlertAction action1 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                                                            alert1.AddAction(action1);
                                                            this.PresentViewController(alert1, true, null);
                                                            break;
                                                        case (ulong)SSDKResponseState.Cancel:
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
            //        case (ulong)SSDKResponseState.Upload:
            //            break;
            //        case (ulong)SSDKResponseState.Success:
            //            UIAlertController alert = UIAlertController.Create("Share Success", null, UIAlertControllerStyle.Alert);
            //            UIAlertAction action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
            //            alert.AddAction(action);
            //            this.PresentViewController(alert, true, null);
            //            break;
            //        case (ulong)SSDKResponseState.Fail:
            //            UIAlertController alert1 = UIAlertController.Create("Share Failed", null, UIAlertControllerStyle.Alert);
            //            UIAlertAction action1 = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
            //            alert1.AddAction(action1);
            //            this.PresentViewController(alert1, true, null);
            //            break;
            //        case (ulong)SSDKResponseState.Cancel:
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

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
