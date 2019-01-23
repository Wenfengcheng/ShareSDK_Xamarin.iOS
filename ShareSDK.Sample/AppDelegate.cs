using Foundation;
using UIKit;
using ShareSDK;

namespace ShareSDK.Sample
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            //ShareSDK.RegistPlatforms((platformsRegister) =>
            //{
            //    platformsRegister.SetupQQWithAppId("100371282", "aed9b0303e3ed1e27bae87c33761161d");
            //    platformsRegister.SetupWeChatWithAppId("wx617c77c82218ea2c", "c7253e5289986cf4c4c74d1ccc185fb1");
            //    platformsRegister.SetupSinaWeiboWithAppkey("568898243", "38a4f8204cc784f81f9f0daaf31e02e3", "http://www.sharesdk.cn");
            //    //Facebook
            //    platformsRegister.SetupFacebookWithAppkey("1412473428822331", "a42f4f3f867dc947b9ed6020c2e93558", "shareSDK");

            //    platformsRegister.SetupDingTalkWithAppId("dingoabcwtuab76wy0kyzo");
            //    platformsRegister.SetupAliSocialWithAppId("2017062107540437");
            //    platformsRegister.SetupDouBanWithApikey("02e2cbe5ca06de5908a863b15e149b0b", "9f1e7b4f71304f2f", "http://www.sharesdk.cn");
            //});
            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }
    }
}

