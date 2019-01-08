using System;
using ShareSDK;
using Foundation;

namespace ShareSDK.Sample.Helper
{
    public class ShareSDKHelper
    {
        private static ShareSDK _shareSDK;

        public static ShareSDK Instance => _shareSDK ?? (_shareSDK = new ShareSDK());

        /// <summary>
        /// Shares the parameters.
        /// </summary>
        /// <param name="param">Parameter.</param>
        /// <param name="type">Type.</param>
        /// <param name="stateChangedHandler">State changed handler.</param>
        public static void ShareParams(NSMutableDictionary param, SSDKPlatformType type, Action<SSDKResponseState, NSDictionary, SSDKContentEntity, NSError> stateChangedHandler = null)
        {
            ShareSDK.Share(type, param, stateChangedHandler);
        }

        /// <summary>
        /// Auth the specified type, settings and stateChangedHandler.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="settings">Settings.</param>
        /// <param name="stateChangedHandler">State changed handler.</param>
        public static void Auth(SSDKPlatformType type, NSDictionary settings = null, Action<SSDKResponseState, SSDKUser, NSError> stateChangedHandler = null)
        {
            ShareSDK.Authorize(type, settings, stateChangedHandler);
        }
    }
}
