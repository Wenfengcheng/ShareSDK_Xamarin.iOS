using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ShareSDK
{
    // @interface SSDKShare (NSMutableDictionary)
    [Category]
    [BaseType(typeof(NSMutableDictionary))]
    interface NSMutableDictionary_SSDKShare
    {
        // -(void)SSDKSetShareFlags:(NSArray<NSString *> *)flags;
        [Export("SSDKSetShareFlags:")]
        void SSDKSetShareFlags(string[] flags);

        // -(void)SSDKSetupShareParamsByText:(NSString *)text images:(id)images url:(NSURL *)url title:(NSString *)title type:(SSDKContentType)type;
        [Export("SSDKSetupShareParamsByText:images:url:title:type:")]
        void SSDKSetupShareParamsByText([NullAllowed]string text, [NullAllowed]NSObject images, [NullAllowed]NSUrl url, string title, SSDKContentType type);

        // -(void)SSDKSetupWeChatParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url thumbImage:(id)thumbImage image:(id)image musicFileURL:(NSURL *)musicFileURL extInfo:(NSString *)extInfo fileData:(id)fileData emoticonData:(id)emoticonData sourceFileExtension:(NSString *)fileExtension sourceFileData:(id)sourceFileData type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupWeChatParamsByText:title:url:thumbImage:image:musicFileURL:extInfo:fileData:emoticonData:sourceFileExtension:sourceFileData:type:forPlatformSubType:")]
        void SSDKSetupWeChatParamsByText([NullAllowed]string text, [NullAllowed]string title, [NullAllowed]NSUrl url, [NullAllowed]NSObject thumbImage, [NullAllowed]NSObject image, [NullAllowed]NSUrl musicFileURL, [NullAllowed]string extInfo, [NullAllowed]NSObject fileData, [NullAllowed]NSObject emoticonData, [NullAllowed]string fileExtension, [NullAllowed]NSObject sourceFileData, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupWeChatMiniProgramShareParamsByTitle:(NSString *)title description:(NSString *)description webpageUrl:(NSURL *)webpageUrl path:(NSString *)path thumbImage:(id)thumbImage hdThumbImage:(id)hdThumbImage userName:(NSString *)userName withShareTicket:(BOOL)withShareTicket miniProgramType:(NSUInteger)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupWeChatMiniProgramShareParamsByTitle:description:webpageUrl:path:thumbImage:hdThumbImage:userName:withShareTicket:miniProgramType:forPlatformSubType:")]
        void SSDKSetupWeChatMiniProgramShareParamsByTitle(string title, string description, NSUrl webpageUrl, string path, NSObject thumbImage, NSObject hdThumbImage, string userName, bool withShareTicket, nuint type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupQQParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url audioFlashURL:(NSURL *)audioFlashURL videoFlashURL:(NSURL *)videoFlashURL thumbImage:(id)thumbImage images:(id)images type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupQQParamsByText:title:url:audioFlashURL:videoFlashURL:thumbImage:images:type:forPlatformSubType:")]
        void SSDKSetupQQParamsByText(string text, [NullAllowed]string title, [NullAllowed]NSUrl url, [NullAllowed]NSUrl audioFlashURL, [NullAllowed]NSUrl videoFlashURL, [NullAllowed]NSObject thumbImage, [NullAllowed]NSObject images, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupQQParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url thumbImage:(id)thumbImage image:(id)image type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType __attribute__((deprecated("discard form v4.2.0")));
        //[Export("SSDKSetupQQParamsByText:title:url:thumbImage:image:type:forPlatformSubType:")]
        //void SSDKSetupQQParamsByText(string text, string title, NSUrl url, NSObject thumbImage, NSObject image, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupSinaWeiboShareParamsByText:(NSString *)text title:(NSString *)title images:(id)images video:(NSString *)video url:(NSURL *)url latitude:(double)latitude longitude:(double)longitude objectID:(NSString *)objectID isShareToStory:(BOOL)shareToStory type:(SSDKContentType)type;
        [Export("SSDKSetupSinaWeiboShareParamsByText:title:images:video:url:latitude:longitude:objectID:isShareToStory:type:")]
        void SSDKSetupSinaWeiboShareParamsByText(string text, [NullAllowed]string title, [NullAllowed]NSObject images, [NullAllowed]string video, [NullAllowed]NSUrl url, double latitude, double longitude, [NullAllowed]string objectID, bool shareToStory, SSDKContentType type);

        // -(void)SSDKSetupFacebookParamsByText:(NSString *)text image:(id)image url:(NSURL *)url urlTitle:(NSString *)title urlName:(NSString *)urlName attachementUrl:(NSURL *)attachementUrl type:(SSDKContentType)type __attribute__((deprecated("discard form v4.2.0")));
        //[Export("SSDKSetupFacebookParamsByText:image:url:urlTitle:urlName:attachementUrl:type:")]
        //void SSDKSetupFacebookParamsByText(string text, NSObject image, NSUrl url, string title, string urlName, NSUrl attachementUrl, SSDKContentType type);

        // -(void)SSDKSetupFacebookParamsByText:(NSString *)text image:(id)image url:(NSURL *)url urlTitle:(NSString *)title urlName:(NSString *)urlName attachementUrl:(NSURL *)attachementUrl hashtag:(NSString *)hashtag quote:(NSString *)quote type:(SSDKContentType)type;
        [Export("SSDKSetupFacebookParamsByText:image:url:urlTitle:urlName:attachementUrl:hashtag:quote:type:")]
        void SSDKSetupFacebookParamsByText(string text, NSObject image, NSUrl url, string title, string urlName, NSUrl attachementUrl, string hashtag, string quote, SSDKContentType type);

        // -(void)SSDKSetupFacebookMessengerParamsByImage:(id)image gif:(id)gif audio:(id)audio video:(id)video type:(SSDKContentType)type;
        [Export("SSDKSetupFacebookMessengerParamsByImage:gif:audio:video:type:")]
        void SSDKSetupFacebookMessengerParamsByImage(NSObject image, NSObject gif, NSObject audio, NSObject video, SSDKContentType type);

        // -(void)SSDKSetupFacebookMessengerParamsByTitle:(NSString *)title url:(NSURL *)url quoteText:(NSString *)text images:(id)images gif:(id)gif audio:(id)audio video:(id)video type:(SSDKContentType)type;
        [Export("SSDKSetupFacebookMessengerParamsByTitle:url:quoteText:images:gif:audio:video:type:")]
        void SSDKSetupFacebookMessengerParamsByTitle(string title, NSUrl url, string text, NSObject images, NSObject gif, NSObject audio, NSObject video, SSDKContentType type);

        // -(void)SSDKSetupTwitterParamsByText:(NSString *)text images:(id)images video:(NSURL *)video latitude:(double)latitude longitude:(double)longitude type:(SSDKContentType)type;
        [Export("SSDKSetupTwitterParamsByText:images:video:latitude:longitude:type:")]
        void SSDKSetupTwitterParamsByText(string text, NSObject images, NSUrl video, double latitude, double longitude, SSDKContentType type);

        // -(void)SSDKSetupTwitterParamsByText:(NSString *)text images:(id)images latitude:(double)latitude longitude:(double)longitude type:(SSDKContentType)type __attribute__((deprecated("Discard form v4.2.0, using "SSDKSetupTwitterParamsByText:images:video:latitude:longitude:type:" instead.")));
        //[Export("SSDKSetupTwitterParamsByText:images:latitude:longitude:type:")]
        //void SSDKSetupTwitterParamsByText(string text, NSObject images, double latitude, double longitude, SSDKContentType type);

        // -(void)SSDKSetupTwitterParamsByText:(NSString *)text video:(NSURL *)video latitude:(double)latitude longitude:(double)longitude tag:(NSString *)str __attribute__((deprecated("Discard form v4.2.0, using "SSDKSetupTwitterParamsByText:images:video:latitude:longitude:type:" instead.")));
        //[Export("SSDKSetupTwitterParamsByText:video:latitude:longitude:tag:")]
        //void SSDKSetupTwitterParamsByText(string text, NSUrl video, double latitude, double longitude, string str);

        // -(void)SSDKSetupInstagramByImage:(id)image menuDisplayPoint:(CGPoint)point;
        [Export("SSDKSetupInstagramByImage:menuDisplayPoint:")]
        void SSDKSetupInstagramByImage(NSObject image, CGPoint point);

        // -(void)SSDKSetupInstagramByVideo:(NSURL *)video;
        [Export("SSDKSetupInstagramByVideo:")]
        void SSDKSetupInstagramByVideo(NSUrl video);

        // -(void)SSDKSetupDingTalkParamsByText:(NSString *)text image:(id)image title:(NSString *)title url:(NSURL *)url type:(SSDKContentType)type;
        [Export("SSDKSetupDingTalkParamsByText:image:title:url:type:")]
        void SSDKSetupDingTalkParamsByText(string text, NSObject image, string title, NSUrl url, SSDKContentType type);

        // -(void)SSDKSetupAliSocialParamsByText:(NSString *)text image:(id)image title:(NSString *)title url:(NSURL *)url type:(SSDKContentType)type platformType:(SSDKPlatformType)platformType;
        [Export("SSDKSetupAliSocialParamsByText:image:title:url:type:platformType:")]
        void SSDKSetupAliSocialParamsByText(string text, NSObject image, string title, NSUrl url, SSDKContentType type, SSDKPlatformType platformType);

        // -(void)SSDKSetupPinterestParamsByImage:(id)image desc:(NSString *)desc url:(NSURL *)url boardName:(NSString *)boardName;
        [Export("SSDKSetupPinterestParamsByImage:desc:url:boardName:")]
        void SSDKSetupPinterestParamsByImage(NSObject image, string desc, NSUrl url, string boardName);

        // -(void)SSDKSetupDouBanParamsByText:(NSString *)text image:(id)image title:(NSString *)title url:(NSURL *)url urlDesc:(NSString *)urlDesc type:(SSDKContentType)type;
        [Export("SSDKSetupDouBanParamsByText:image:title:url:urlDesc:type:")]
        void SSDKSetupDouBanParamsByText(string text, NSObject image, string title, NSUrl url, string urlDesc, SSDKContentType type);

        // -(void)SSDKSetupDropboxParamsByAttachment:(id)attachment;
        [Export("SSDKSetupDropboxParamsByAttachment:")]
        void SSDKSetupDropboxParamsByAttachment(NSObject attachment);

        // -(void)SSDKSetupYiXinParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url thumbImage:(id)thumbImage image:(id)image musicFileURL:(NSURL *)musicFileURL extInfo:(NSString *)extInfo fileData:(id)fileData comment:(NSString *)comment toUserId:(NSString *)userId type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupYiXinParamsByText:title:url:thumbImage:image:musicFileURL:extInfo:fileData:comment:toUserId:type:forPlatformSubType:")]
        void SSDKSetupYiXinParamsByText(string text, string title, NSUrl url, NSObject thumbImage, NSObject image, NSUrl musicFileURL, string extInfo, NSObject fileData, string comment, string userId, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupFlickrParamsByText:(NSString *)text image:(id)image title:(NSString *)title tags:(NSArray *)tags isPublic:(BOOL)isPublic isFriend:(BOOL)isFriend isFamily:(BOOL)isFamily safetyLevel:(NSInteger)safetyLevel contentType:(NSInteger)contentType hidden:(NSInteger)hidden;
        [Export("SSDKSetupFlickrParamsByText:image:title:tags:isPublic:isFriend:isFamily:safetyLevel:contentType:hidden:")]
        void SSDKSetupFlickrParamsByText(string text, NSObject image, string title, NSObject[] tags, bool isPublic, bool isFriend, bool isFamily, nint safetyLevel, nint contentType, nint hidden);

        // -(void)SSDKSetupInstapaperParamsByUrl:(NSURL *)url title:(NSString *)title desc:(NSString *)desc content:(NSString *)content isPrivateFromSource:(BOOL)isPrivateFromSource folderId:(NSInteger)folderId resolveFinalUrl:(BOOL)resolveFinalUrl;
        [Export("SSDKSetupInstapaperParamsByUrl:title:desc:content:isPrivateFromSource:folderId:resolveFinalUrl:")]
        void SSDKSetupInstapaperParamsByUrl(NSUrl url, string title, string desc, string content, bool isPrivateFromSource, nint folderId, bool resolveFinalUrl);

        // -(void)SSDKSetupLineParamsByText:(NSString *)text image:(id)image type:(SSDKContentType)type;
        [Export("SSDKSetupLineParamsByText:image:type:")]
        void SSDKSetupLineParamsByText(string text, NSObject image, SSDKContentType type);

        // -(void)SSDKSetupEvernoteParamsByText:(NSString *)text images:(id)images video:(NSURL *)video title:(NSString *)title notebook:(NSString *)notebook tags:(NSArray *)tags platformType:(SSDKPlatformType)platformType;
        [Export("SSDKSetupEvernoteParamsByText:images:video:title:notebook:tags:platformType:")]
        void SSDKSetupEvernoteParamsByText(string text, NSObject images, NSUrl video, string title, string notebook, NSObject[] tags, SSDKPlatformType platformType);

        // -(void)SSDKSetupEvernoteParamsByText:(NSString *)text images:(id)images title:(NSString *)title notebook:(NSString *)notebook tags:(NSArray *)tags platformType:(SSDKPlatformType)platformType __attribute__((deprecated("discard form v4.2.0")));
        //[Export("SSDKSetupEvernoteParamsByText:images:title:notebook:tags:platformType:")]
        //void SSDKSetupEvernoteParamsByText(string text, NSObject images, string title, string notebook, NSObject[] tags, SSDKPlatformType platformType);

        // -(void)SSDKSetupGooglePlusParamsByText:(NSString *)text url:(NSURL *)url type:(SSDKContentType)type;
        [Export("SSDKSetupGooglePlusParamsByText:url:type:")]
        void SSDKSetupGooglePlusParamsByText(string text, NSUrl url, SSDKContentType type);

        // -(void)SSDKSetupKaKaoParamsByText:(NSString *)text images:(id)images title:(NSString *)title url:(NSURL *)url permission:(NSString *)permission enableShare:(BOOL)enableShare imageSize:(CGSize)imageSize appButtonTitle:(NSString *)appButtonTitle androidExecParam:(NSDictionary *)androidExecParam androidMarkParam:(NSString *)androidMarkParam iphoneExecParams:(NSDictionary *)iphoneExecParams iphoneMarkParam:(NSString *)iphoneMarkParam ipadExecParams:(NSDictionary *)ipadExecParams ipadMarkParam:(NSString *)ipadMarkParam type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType __attribute__((deprecated("Discard form v4.2.0. Using 'SSDKSetupKaKaoParamsByTitle:desc:imageURL:url:templateId:templateArgs:' instead.")));
        //[Export("SSDKSetupKaKaoParamsByText:images:title:url:permission:enableShare:imageSize:appButtonTitle:androidExecParam:androidMarkParam:iphoneExecParams:iphoneMarkParam:ipadExecParams:ipadMarkParam:type:forPlatformSubType:")]
        //void SSDKSetupKaKaoParamsByText(string text, NSObject images, string title, NSUrl url, string permission, bool enableShare, CGSize imageSize, string appButtonTitle, NSDictionary androidExecParam, string androidMarkParam, NSDictionary iphoneExecParams, string iphoneMarkParam, NSDictionary ipadExecParams, string ipadMarkParam, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupKaKaoTalkParamsByUrl:(NSURL *)url templateId:(NSString *)templateId templateArgs:(NSDictionary *)templateArgs;
        [Export("SSDKSetupKaKaoTalkParamsByUrl:templateId:templateArgs:")]
        void SSDKSetupKaKaoTalkParamsByUrl(NSUrl url, string templateId, NSDictionary templateArgs);

        // -(void)SSDKSetupKakaoStoryParamsByContent:(NSString *)content title:(NSString *)title images:(id)images url:(NSURL *)url permission:(int)permission sharable:(BOOL)sharable androidExecParam:(NSDictionary *)androidExecParam iosExecParam:(NSDictionary *)iosExecParam;
        [Export("SSDKSetupKakaoStoryParamsByContent:title:images:url:permission:sharable:androidExecParam:iosExecParam:")]
        void SSDKSetupKakaoStoryParamsByContent(string content, string title, NSObject images, NSUrl url, int permission, bool sharable, NSDictionary androidExecParam, NSDictionary iosExecParam);

        // -(void)SSDKSetupLinkedInParamsByText:(NSString *)text image:(id)image url:(NSURL *)url title:(NSString *)title urlDesc:(NSString *)urlDesc visibility:(NSString *)visibility type:(SSDKContentType)type;
        [Export("SSDKSetupLinkedInParamsByText:image:url:title:urlDesc:visibility:type:")]
        void SSDKSetupLinkedInParamsByText(string text, NSObject image, NSUrl url, string title, string urlDesc, string visibility, SSDKContentType type);

        // -(void)SSDKSetupTumblrParamsByText:(NSString *)text image:(id)image url:(NSURL *)url title:(NSString *)title blogName:(NSString *)blogName type:(SSDKContentType)type;
        [Export("SSDKSetupTumblrParamsByText:image:url:title:blogName:type:")]
        void SSDKSetupTumblrParamsByText(string text, NSObject image, NSUrl url, string title, string blogName, SSDKContentType type);

        // -(void)SSDKSetupMeiPaiParamsByUrl:(NSURL *)url contentType:(SSDKContentType)type;
        [Export("SSDKSetupMeiPaiParamsByUrl:contentType:")]
        void SSDKSetupMeiPaiParamsByUrl(NSUrl url, SSDKContentType type);

        // -(void)SSDKSetupMeiPaiParamsByUrl:(NSURL *)url type:(SSDKContentType)type __attribute__((deprecated("Discard form v4.2.0")));
        //[Export("SSDKSetupMeiPaiParamsByUrl:type:")]
        //void SSDKSetupMeiPaiParamsByUrl(NSUrl url, SSDKContentType type);

        // -(void)SSDKSetupPocketParamsByUrl:(NSURL *)url title:(NSString *)title tags:(id)tags tweetId:(NSString *)tweetId;
        [Export("SSDKSetupPocketParamsByUrl:title:tags:tweetId:")]
        void SSDKSetupPocketParamsByUrl(NSUrl url, string title, NSObject tags, string tweetId);

        // -(void)SSDKSetupSMSParamsByText:(NSString *)text title:(NSString *)title images:(id)images attachments:(id)attachments recipients:(NSArray *)recipients type:(SSDKContentType)type;
        [Export("SSDKSetupSMSParamsByText:title:images:attachments:recipients:type:")]
        void SSDKSetupSMSParamsByText(string text, string title, NSObject images, NSObject attachments, NSObject[] recipients, SSDKContentType type);

        // -(void)SSDKSetupCopyParamsByText:(NSString *)text images:(id)images url:(NSURL *)url type:(SSDKContentType)type;
        [Export("SSDKSetupCopyParamsByText:images:url:type:")]
        void SSDKSetupCopyParamsByText(string text, NSObject images, NSUrl url, SSDKContentType type);

        // -(void)SSDKSetupKaiXinParamsByText:(NSString *)text image:(id)image type:(SSDKContentType)type;
        [Export("SSDKSetupKaiXinParamsByText:image:type:")]
        void SSDKSetupKaiXinParamsByText(string text, NSObject image, SSDKContentType type);

        // -(void)SSDKSetupMingDaoParamsByText:(NSString *)text image:(id)image url:(NSURL *)url title:(NSString *)title type:(SSDKContentType)type;
        [Export("SSDKSetupMingDaoParamsByText:image:url:title:type:")]
        void SSDKSetupMingDaoParamsByText(string text, NSObject image, NSUrl url, string title, SSDKContentType type);

        // -(void)SSDKSetupVKontakteParamsByText:(NSString *)text images:(id)images url:(NSURL *)url groupId:(NSString *)groupId friendsOnly:(BOOL)friendsOnly latitude:(double)latitude longitude:(double)longitude type:(SSDKContentType)type;
        [Export("SSDKSetupVKontakteParamsByText:images:url:groupId:friendsOnly:latitude:longitude:type:")]
        void SSDKSetupVKontakteParamsByText(string text, NSObject images, NSUrl url, string groupId, bool friendsOnly, double latitude, double longitude, SSDKContentType type);

        // -(void)SSDKSetupYouTubeParamsByVideo:(id)video title:(NSString *)title description:(NSString *)description tags:(id)tags privacyStatus:(SSDKPrivacyStatus)privacyStatus;
        [Export("SSDKSetupYouTubeParamsByVideo:title:description:tags:privacyStatus:")]
        void SSDKSetupYouTubeParamsByVideo(NSObject video, string title, string description, NSObject tags, SSDKPrivacyStatus privacyStatus);

        // -(void)SSDKSetupYouTubeParamsByVideo:(id)video parts:(NSString *)parts jsonString:(NSString *)jsonString;
        [Export("SSDKSetupYouTubeParamsByVideo:parts:jsonString:")]
        void SSDKSetupYouTubeParamsByVideo(NSObject video, string parts, string jsonString);

        // -(void)SSDKSetupWhatsAppParamsByText:(NSString *)text image:(id)image audio:(id)audio video:(id)video menuDisplayPoint:(CGPoint)point type:(SSDKContentType)type;
        [Export("SSDKSetupWhatsAppParamsByText:image:audio:video:menuDisplayPoint:type:")]
        void SSDKSetupWhatsAppParamsByText(string text, NSObject image, NSObject audio, NSObject video, CGPoint point, SSDKContentType type);

        // -(void)SSDKSetupTencentWeiboShareParamsByText:(NSString *)text images:(id)images latitude:(double)latitude longitude:(double)longitude type:(SSDKContentType)type;
        [Export("SSDKSetupTencentWeiboShareParamsByText:images:latitude:longitude:type:")]
        void SSDKSetupTencentWeiboShareParamsByText(string text, NSObject images, double latitude, double longitude, SSDKContentType type);

        // -(void)SSDKSetupMailParamsByText:(NSString *)text title:(NSString *)title images:(id)images attachments:(id)attachments recipients:(NSArray *)recipients ccRecipients:(NSArray *)ccRecipients bccRecipients:(NSArray *)bccRecipients type:(SSDKContentType)type;
        [Export("SSDKSetupMailParamsByText:title:images:attachments:recipients:ccRecipients:bccRecipients:type:")]
        void SSDKSetupMailParamsByText(string text, string title, NSObject images, NSObject attachments, NSObject[] recipients, NSObject[] ccRecipients, NSObject[] bccRecipients, SSDKContentType type);

        // -(void)SSDKSetupRenRenParamsByText:(NSString *)text image:(id)image url:(NSURL *)url albumId:(NSString *)albumId type:(SSDKContentType)type;
        [Export("SSDKSetupRenRenParamsByText:image:url:albumId:type:")]
        void SSDKSetupRenRenParamsByText(string text, NSObject image, NSUrl url, string albumId, SSDKContentType type);

        // -(void)SSDKSetupYouDaoNoteParamsByText:(NSString *)text images:(id)images title:(NSString *)title source:(NSString *)source author:(NSString *)author notebook:(NSString *)notebook;
        [Export("SSDKSetupYouDaoNoteParamsByText:images:title:source:author:notebook:")]
        void SSDKSetupYouDaoNoteParamsByText(string text, NSObject images, string title, string source, string author, string notebook);

        // -(void)SSDKSetupTelegramParamsByText:(NSString *)text image:(id)image audio:(NSURL *)audio video:(NSURL *)video file:(NSURL *)file menuDisplayPoint:(CGPoint)point type:(SSDKContentType)type;
        [Export("SSDKSetupTelegramParamsByText:image:audio:video:file:menuDisplayPoint:type:")]
        void SSDKSetupTelegramParamsByText(string text, NSObject image, NSUrl audio, NSUrl video, NSUrl file, CGPoint point, SSDKContentType type);

        // -(void)SSDKEnableUseClientShare __attribute__((deprecated("Discard form v4.2.0")));
        //[Export("SSDKEnableUseClientShare")]
        //void SSDKEnableUseClientShare();

        // -(void)SSDKEnableExtensionShare __attribute__((deprecated("Discard form v4.2.0")));
        //[Export("SSDKEnableExtensionShare")]
        //void SSDKEnableExtensionShare();
    }

    // @interface ShareSDK : NSObject
    [BaseType(typeof(NSObject), Name = "ShareSDK")]
    interface ShareSDK
    {
        // +(void)registPlatforms:(void (^)(SSDKRegister *))importHandler;
        [Static]
        [Export("registPlatforms:")]
        void RegistPlatforms(Action<SSDKRegister> importHandler);

        // +(SSDKSession *)authorize:(SSDKPlatformType)platformType settings:(NSDictionary *)settings onStateChanged:(SSDKAuthorizeStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("authorize:settings:onStateChanged:")]
        SSDKSession Authorize(SSDKPlatformType platformType, [NullAllowed]NSDictionary settings, [NullAllowed]Action<SSDKResponseState, SSDKUser, NSError> stateChangedHandler);

        // +(BOOL)hasAuthorized:(SSDKPlatformType)platformTypem;
        [Static]
        [Export("hasAuthorized:")]
        bool HasAuthorized(SSDKPlatformType platformTypem);

        // +(void)cancelAuthorize:(SSDKPlatformType)platformType result:(void (^)(NSError *))result;
        [Static]
        [Export("cancelAuthorize:result:")]
        void CancelAuthorize(SSDKPlatformType platformType, [NullAllowed]Action<NSError> result);

        // +(SSDKSession *)getUserInfo:(SSDKPlatformType)platformType onStateChanged:(SSDKGetUserStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("getUserInfo:onStateChanged:")]
        SSDKSession GetUserInfo(SSDKPlatformType platformType, [NullAllowed]Action<SSDKResponseState, SSDKUser, NSError> stateChangedHandler);

        // +(SSDKSession *)share:(SSDKPlatformType)platformType parameters:(NSMutableDictionary *)parameters onStateChanged:(SSDKShareStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("share:parameters:onStateChanged:")]
        SSDKSession Share(SSDKPlatformType platformType, NSMutableDictionary parameters, [NullAllowed]Action<SSDKResponseState, NSDictionary, SSDKContentEntity, NSError> stateChangedHandler);

        // +(void)registerActivePlatforms:(NSArray *)activePlatforms onImport:(SSDKImportHandler)importHandler onConfiguration:(SSDKConfigurationHandler)configurationHandler __attribute__((deprecated("Discard form v4.2.0. Use 'registPlatforms:' instead.")));
        //[Static]
        //[Export("registerActivePlatforms:onImport:onConfiguration:")]
        //void RegisterActivePlatforms(NSObject[] activePlatforms, SSDKImportHandler importHandler, SSDKConfigurationHandler configurationHandler);

        // +(void)cancelAuthorize:(SSDKPlatformType)platformType __attribute__((deprecated("Discard form v4.2.0. Use 'cancelAuthorize:result:' instead.")));
        //[Static]
        //[Export("cancelAuthorize:")]
        //void CancelAuthorize(SSDKPlatformType platformType);
    }

    //@interface ShareSDK(Base)
    [Category]
    [BaseType(typeof(ShareSDK))]
    interface ShareSDK_Base
    {
        // +(NSString *)sdkVersion;
        [Static]
        [Export("sdkVersion")]
        string SdkVersion { get; }

        // +(NSDictionary *)configWithPlatform:(SSDKPlatformType)platform;
        [Static]
        [Export("configWithPlatform:")]
        NSDictionary ConfigWithPlatform(SSDKPlatformType platform);

        // +(NSMutableArray *)activePlatforms;
        [Static]
        [Export("activePlatforms")]
        NSMutableArray ActivePlatforms { get; }

        // +(SSDKSession *)getUserInfo:(SSDKPlatformType)platformType condition:(SSDKUserQueryCondition *)condition onStateChanged:(SSDKGetUserStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("getUserInfo:condition:onStateChanged:")]
        SSDKSession GetUserInfo(SSDKPlatformType platformType, SSDKUserQueryCondition condition, [NullAllowed]Action<SSDKResponseState, SSDKUser, NSError> stateChangedHandler);

        // +(void)recordShareEventWithPlatform:(SSDKPlatformType)platformType eventType:(SSDKShareEventType)eventType;
        [Static]
        [Export("recordShareEventWithPlatform:eventType:")]
        void RecordShareEventWithPlatform(SSDKPlatformType platformType, SSDKShareEventType eventType);

        // +(void)enableAutomaticRecordingEvent:(BOOL)record;
        [Static]
        [Export("enableAutomaticRecordingEvent:")]
        void EnableAutomaticRecordingEvent(bool record);

        // +(void)authorize:(SSDKPlatformType)platformType settings:(NSDictionary *)settings onViewDisplay:(SSDKAuthorizeViewDisplayHandler)viewDisplayHandler onStateChanged:(SSDKAuthorizeStateChangedHandler)stateChangedHandler __attribute__((deprecated("Discard form v4.2.0")));
        //[Static]
        //[Export("authorize:settings:onViewDisplay:onStateChanged:")]
        //void Authorize(SSDKPlatformType platformType, NSDictionary settings, SSDKAuthorizeViewDisplayHandler viewDisplayHandler, SSDKAuthorizeStateChangedHandler stateChangedHandler);

        // +(void)getUserInfo:(SSDKPlatformType)platformType conditional:(SSDKUserQueryCondition *)conditional onAuthorize:(SSDKNeedAuthorizeHandler)authorizeHandler onStateChanged:(SSDKGetUserStateChangedHandler)stateChangedHandler __attribute__((deprecated("Discard form v4.2.0")));
        //[Static]
        //[Export("getUserInfo:conditional:onAuthorize:onStateChanged:")]
        //void GetUserInfo(SSDKPlatformType platformType, SSDKUserQueryCondition conditional, SSDKNeedAuthorizeHandler authorizeHandler, SSDKGetUserStateChangedHandler stateChangedHandler);

        // +(void)share:(SSDKPlatformType)platformType parameters:(NSMutableDictionary *)parameters onAuthorize:(SSDKNeedAuthorizeHandler)authorizeHandler onStateChanged:(SSDKShareStateChangedHandler)stateChangedHandler __attribute__((deprecated("Discard form v4.2.0")));
        //[Static]
        //[Export("share:parameters:onAuthorize:onStateChanged:")]
        //void Share(SSDKPlatformType platformType, NSMutableDictionary parameters, SSDKNeedAuthorizeHandler authorizeHandler, SSDKShareStateChangedHandler stateChangedHandler);
    }

    // @interface SSDKAuthViewStyle : NSObject
    [BaseType(typeof(NSObject), Name = "SSDKAuthViewStyle")]
    interface SSDKAuthViewStyle
    {
        // +(void)setNavigationBarBackgroundImage:(UIImage *)image;
        [Static]
        [Export("setNavigationBarBackgroundImage:")]
        void SetNavigationBarBackgroundImage(UIImage image);

        // +(void)setNavigationBarBackgroundColor:(UIColor *)color;
        [Static]
        [Export("setNavigationBarBackgroundColor:")]
        void SetNavigationBarBackgroundColor(UIColor color);

        // +(void)setTitle:(NSString *)title;
        [Static]
        [Export("setTitle:")]
        void SetTitle(string title);

        // +(void)setTitleColor:(UIColor *)color;
        [Static]
        [Export("setTitleColor:")]
        void SetTitleColor(UIColor color);

        // +(void)setCancelButtonLabel:(NSString *)label;
        [Static]
        [Export("setCancelButtonLabel:")]
        void SetCancelButtonLabel(string label);

        // +(void)setCancelButtonLabelColor:(UIColor *)color;
        [Static]
        [Export("setCancelButtonLabelColor:")]
        void SetCancelButtonLabelColor(UIColor color);

        // +(void)setCancelButtonImage:(UIImage *)image;
        [Static]
        [Export("setCancelButtonImage:")]
        void SetCancelButtonImage(UIImage image);

        // +(void)setCancelButtonLeftMargin:(CGFloat)margin;
        [Static]
        [Export("setCancelButtonLeftMargin:")]
        void SetCancelButtonLeftMargin(nfloat margin);

        // +(void)setRightButton:(UIButton *)button;
        [Static]
        [Export("setRightButton:")]
        void SetRightButton(UIButton button);

        // +(void)setRightButtonRightMargin:(CGFloat)margin;
        [Static]
        [Export("setRightButtonRightMargin:")]
        void SetRightButtonRightMargin(nfloat margin);

        // +(void)setSupportedInterfaceOrientation:(UIInterfaceOrientationMask)toInterfaceOrientation;
        [Static]
        [Export("setSupportedInterfaceOrientation:")]
        void SetSupportedInterfaceOrientation(UIInterfaceOrientationMask toInterfaceOrientation);

        // +(void)setStatusBarStyle:(UIStatusBarStyle)style;
        [Static]
        [Export("setStatusBarStyle:")]
        void SetStatusBarStyle(UIStatusBarStyle style);
    }

    // @interface SSDKContentEntity : MOBFDataModel
    [BaseType(typeof(NSObject), Name = "SSDKContentEntity")]
    interface SSDKContentEntity
    {
        // @property (nonatomic, strong) id cid;
        [Export("cid", ArgumentSemantic.Strong)]
        NSObject Cid { get; set; }

        // @property (copy, nonatomic) NSString * text;
        [Export("text")]
        string Text { get; set; }

        // @property (retain, nonatomic) NSMutableArray * images;
        [Export("images", ArgumentSemantic.Retain)]
        NSMutableArray Images { get; set; }

        // @property (retain, nonatomic) NSMutableArray * urls;
        [Export("urls", ArgumentSemantic.Retain)]
        NSMutableArray Urls { get; set; }

        // @property (retain, nonatomic) NSDictionary * rawData;
        [Export("rawData", ArgumentSemantic.Retain)]
        NSDictionary RawData { get; set; }
    }

    // @interface SSDKCredential : MOBFDataModel
    [BaseType(typeof(NSObject), Name = "SSDKCredential")]
    interface SSDKCredential
    {
        // @property (copy, nonatomic) NSString * authCode;
        [Export("authCode")]
        string AuthCode { get; set; }

        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * token;
        [Export("token")]
        string Token { get; set; }

        // @property (copy, nonatomic) NSString * secret;
        [Export("secret")]
        string Secret { get; set; }

        // @property (assign, nonatomic) NSTimeInterval expired;
        [Export("expired")]
        double Expired { get; set; }

        // @property (nonatomic) SSDKCredentialType type;
        [Export("type", ArgumentSemantic.Assign)]
        SSDKCredentialType Type { get; set; }

        // @property (nonatomic, strong) NSDictionary * rawData;
        [Export("rawData", ArgumentSemantic.Strong)]
        NSDictionary RawData { get; set; }

        // @property (readonly, nonatomic) BOOL available;
        [Export("available")]
        bool Available { get; }
    }

    [Static]
    partial interface SSDKImageFormat
    {
        // extern NSString *const SSDKImageFormatJpeg;
        [Field("SSDKImageFormatJpeg", "__Internal")]
        NSString Jpeg { get; }

        // extern NSString *const SSDKImageFormatPng;
        [Field("SSDKImageFormatPng", "__Internal")]
        NSString Png { get; }

        // extern NSString *const SSDKImageSettingQualityKey;
        [Field("SSDKImageSettingQualityKey", "__Internal")]
        NSString QualityKey { get; }
    }

    // @interface SSDKImage : NSObject
    [BaseType(typeof(NSObject), Name = "SSDKImage")]
    interface SSDKImage
    {
        // @property (nonatomic, strong) NSURL * URL;
        [Export("URL", ArgumentSemantic.Strong)]
        NSUrl URL { get; set; }

        // +(instancetype)imageWithObject:(id)object;
        [Static]
        [Export("imageWithObject:")]
        SSDKImage ImageWithObject(NSObject @object);

        // -(id)initWithURL:(NSURL *)URL;
        [Export("initWithURL:")]
        IntPtr Constructor(NSUrl URL);

        // -(id)initWithImage:(UIImage *)image format:(NSString *)format settings:(NSDictionary *)settings;
        [Export("initWithImage:format:settings:")]
        IntPtr Constructor(UIImage image, string format, NSDictionary settings);

        // -(void)getNativeImage:(void (^)(UIImage *))handler;
        [Export("getNativeImage:")]
        void GetNativeImage([NullAllowed]Action<UIImage> handler);

        // -(void)getNativeImageData:(void (^)(NSData *))handler;
        [Export("getNativeImageData:")]
        void GetNativeImageData([NullAllowed]Action<NSData> handler);

        // +(void)getImage:(NSString *)imagePath thumbImagePath:(NSString *)thumbImagePath result:(void (^)(NSData *, NSData *))handler;
        [Static]
        [Export("getImage:thumbImagePath:result:")]
        void GetImage(string imagePath, string thumbImagePath, [NullAllowed]Action<NSData, NSData> handler);

        // +(NSData *)checkThumbImageSize:(NSData *)thumbImageData;
        [Static]
        [Export("checkThumbImageSize:")]
        NSData CheckThumbImageSize(NSData thumbImageData);
    }

    // @interface SSDKRegister : NSObject
    [BaseType(typeof(NSObject), Name = "SSDKRegister")]
    interface SSDKRegister
    {
        // @property (readonly, nonatomic, strong) NSMutableDictionary * platformsInfo;
        [Export("platformsInfo", ArgumentSemantic.Strong)]
        NSMutableDictionary PlatformsInfo { get; }

        // -(void)setupSinaWeiboWithAppkey:(NSString *)appkey appSecret:(NSString *)appSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupSinaWeiboWithAppkey:appSecret:redirectUrl:")]
        void SetupSinaWeiboWithAppkey(string appkey, string appSecret, string redirectUrl);

        // -(void)setupWeChatWithAppId:(NSString *)appId appSecret:(NSString *)appSecret;
        [Export("setupWeChatWithAppId:appSecret:")]
        void SetupWeChatWithAppId(string appId, string appSecret);

        // -(void)setupQQWithAppId:(NSString *)appId appkey:(NSString *)appkey;
        [Export("setupQQWithAppId:appkey:")]
        void SetupQQWithAppId(string appId, string appkey);

        // -(void)setupTwitterWithKey:(NSString *)key secret:(NSString *)secret redirectUrl:(NSString *)redirectUrl;
        [Export("setupTwitterWithKey:secret:redirectUrl:")]
        void SetupTwitterWithKey(string key, string secret, string redirectUrl);

        // -(void)setupFacebookWithAppkey:(NSString *)appkey appSecret:(NSString *)appSecret displayName:(NSString *)displayName;
        [Export("setupFacebookWithAppkey:appSecret:displayName:")]
        void SetupFacebookWithAppkey(string appkey, string appSecret, string displayName);

        // -(void)setupTencentWeiboWithAppkey:(NSString *)appkey appSecret:(NSString *)appSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupTencentWeiboWithAppkey:appSecret:redirectUrl:")]
        void SetupTencentWeiboWithAppkey(string appkey, string appSecret, string redirectUrl);

        // -(void)setupYiXinByAppId:(NSString *)appId appSecret:(NSString *)appSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupYiXinByAppId:appSecret:redirectUrl:")]
        void SetupYiXinByAppId(string appId, string appSecret, string redirectUrl);

        // -(void)setupEvernoteByConsumerKey:(NSString *)consumerKey consumerSecret:(NSString *)consumerSecret sandbox:(BOOL)sandbox;
        [Export("setupEvernoteByConsumerKey:consumerSecret:sandbox:")]
        void SetupEvernoteByConsumerKey(string consumerKey, string consumerSecret, bool sandbox);

        // -(void)setupDouBanWithApikey:(NSString *)apikey appSecret:(NSString *)appSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupDouBanWithApikey:appSecret:redirectUrl:")]
        void SetupDouBanWithApikey(string apikey, string appSecret, string redirectUrl);

        // -(void)setupRenRenWithAppId:(NSString *)appId appKey:(NSString *)appKey secretKey:(NSString *)secretKey authType:(SSDKAuthorizeType)authType;
        [Export("setupRenRenWithAppId:appKey:secretKey:authType:")]
        void SetupRenRenWithAppId(string appId, string appKey, string secretKey, SSDKAuthorizeType authType);

        // -(void)setupKaiXinByApiKey:(NSString *)apiKey secretKey:(NSString *)secretKey redirectUrl:(NSString *)redirectUrl;
        [Export("setupKaiXinByApiKey:secretKey:redirectUrl:")]
        void SetupKaiXinByApiKey(string apiKey, string secretKey, string redirectUrl);

        // -(void)setupPocketWithConsumerKey:(NSString *)consumerKey redirectUrl:(NSString *)redirectUrl;
        [Export("setupPocketWithConsumerKey:redirectUrl:")]
        void SetupPocketWithConsumerKey(string consumerKey, string redirectUrl);

        // -(void)setupGooglePlusByClientID:(NSString *)clientId clientSecret:(NSString *)clientSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupGooglePlusByClientID:clientSecret:redirectUrl:")]
        void SetupGooglePlusByClientID(string clientId, string clientSecret, string redirectUrl);

        // -(void)setupInstagramWithClientId:(NSString *)clientId clientSecret:(NSString *)clientSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupInstagramWithClientId:clientSecret:redirectUrl:")]
        void SetupInstagramWithClientId(string clientId, string clientSecret, string redirectUrl);

        // -(void)setupLinkedInByApiKey:(NSString *)apiKey secretKey:(NSString *)secretKey redirectUrl:(NSString *)redirectUrl;
        [Export("setupLinkedInByApiKey:secretKey:redirectUrl:")]
        void SetupLinkedInByApiKey(string apiKey, string secretKey, string redirectUrl);

        // -(void)setupTumblrByConsumerKey:(NSString *)consumerKey consumerSecret:(NSString *)consumerSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupTumblrByConsumerKey:consumerSecret:redirectUrl:")]
        void SetupTumblrByConsumerKey(string consumerKey, string consumerSecret, string redirectUrl);

        // -(void)setupFlickrWithApiKey:(NSString *)apiKey apiSecret:(NSString *)apiSecret;
        [Export("setupFlickrWithApiKey:apiSecret:")]
        void SetupFlickrWithApiKey(string apiKey, string apiSecret);

        // -(void)setupYouDaoNoteWithConsumerKey:(NSString *)consumerKey consumerSecret:(NSString *)consumerSecret oauthCallback:(NSString *)oauthCallback;
        [Export("setupYouDaoNoteWithConsumerKey:consumerSecret:oauthCallback:")]
        void SetupYouDaoNoteWithConsumerKey(string consumerKey, string consumerSecret, string oauthCallback);

        // -(void)setupAliSocialWithAppId:(NSString *)appId;
        [Export("setupAliSocialWithAppId:")]
        void SetupAliSocialWithAppId(string appId);

        // -(void)setupPinterestByClientId:(NSString *)clientId;
        [Export("setupPinterestByClientId:")]
        void SetupPinterestByClientId(string clientId);

        // -(void)setupKaKaoWithAppkey:(NSString *)appkey restApiKey:(NSString *)restApiKey redirectUrl:(NSString *)redirectUrl;
        [Export("setupKaKaoWithAppkey:restApiKey:redirectUrl:")]
        void SetupKaKaoWithAppkey(string appkey, string restApiKey, string redirectUrl);

        // -(void)setupDropboxWithAppKey:(NSString *)appId appSecret:(NSString *)appSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupDropboxWithAppKey:appSecret:redirectUrl:")]
        void SetupDropboxWithAppKey(string appId, string appSecret, string redirectUrl);

        // -(void)setupVKontakteWithApplicationId:(NSString *)applicationId secretKey:(NSString *)secretKey authType:(SSDKAuthorizeType)authType;
        [Export("setupVKontakteWithApplicationId:secretKey:authType:")]
        void SetupVKontakteWithApplicationId(string applicationId, string secretKey, SSDKAuthorizeType authType);

        // -(void)setupInstapaperWithConsumerKey:(NSString *)consumerKey consumerSecret:(NSString *)consumerSecret;
        [Export("setupInstapaperWithConsumerKey:consumerSecret:")]
        void SetupInstapaperWithConsumerKey(string consumerKey, string consumerSecret);

        // -(void)setupDingTalkWithAppId:(NSString *)appId;
        [Export("setupDingTalkWithAppId:")]
        void SetupDingTalkWithAppId(string appId);

        // -(void)setupMeiPaiWithAppkey:(NSString *)appkey;
        [Export("setupMeiPaiWithAppkey:")]
        void SetupMeiPaiWithAppkey(string appkey);

        // -(void)setupYouTubeWithClientId:(NSString *)clientId clientSecret:(NSString *)clientSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupYouTubeWithClientId:clientSecret:redirectUrl:")]
        void SetupYouTubeWithClientId(string clientId, string clientSecret, string redirectUrl);

        // -(void)setupLineAuthType:(SSDKAuthorizeType)authType;
        [Export("setupLineAuthType:")]
        void SetupLineAuthType(SSDKAuthorizeType authType);

        // -(void)setupSMSOpenCountryList:(BOOL)open;
        [Export("setupSMSOpenCountryList:")]
        void SetupSMSOpenCountryList(bool open);

        // -(void)setupMingDaoByAppKey:(NSString *)appKey appSecret:(NSString *)appSecret redirectUrl:(NSString *)redirectUrl;
        [Export("setupMingDaoByAppKey:appSecret:redirectUrl:")]
        void SetupMingDaoByAppKey(string appKey, string appSecret, string redirectUrl);

        // -(void)setupCMCCByAppId:(NSString *)appid appKey:(NSString *)appkey displayUI:(BOOL)displayUI;
        [Export("setupCMCCByAppId:appKey:displayUI:")]
        void SetupCMCCByAppId(string appid, string appkey, bool displayUI);

        // -(void)setupTelegramByBotToken:(NSString *)botToken botDomain:(NSString *)botDomain;
        [Export("setupTelegramByBotToken:botDomain:")]
        void SetupTelegramByBotToken(string botToken, string botDomain);

        // -(void)setupRedditByAppKey:(NSString *)appkey redirectUri:(NSString *)redirectUri;
        [Export("setupRedditByAppKey:redirectUri:")]
        void SetupRedditByAppKey(string appkey, string redirectUri);

        // -(void)setupESurfingByAppKey:(NSString *)appkey appSecret:(NSString *)appSecret appName:(NSString *)appName;
        [Export("setupESurfingByAppKey:appSecret:appName:")]
        void SetupESurfingByAppKey(string appkey, string appSecret, string appName);
    }

    // @interface SSDKSession : NSObject
    [BaseType(typeof(NSObject), Name = "SSDKSession")]
    interface SSDKSession
    {
        // @property (readonly, assign, nonatomic) BOOL isCancelled;
        [Export("isCancelled")]
        bool IsCancelled { get; }

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @interface SSDKUser : MOBFDataModel
    [BaseType(typeof(NSObject), Name = "SSDKUser")]
    interface SSDKUser
    {
        // @property (nonatomic) SSDKPlatformType platformType;
        [Export("platformType", ArgumentSemantic.Assign)]
        SSDKPlatformType PlatformType { get; set; }

        // @property (nonatomic, strong) SSDKCredential * credential;
        [Export("credential", ArgumentSemantic.Strong)]
        SSDKCredential Credential { get; set; }

        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * nickname;
        [Export("nickname")]
        string Nickname { get; set; }

        // @property (copy, nonatomic) NSString * icon;
        [Export("icon")]
        string Icon { get; set; }

        // @property (nonatomic) NSInteger gender;
        [Export("gender")]
        nint Gender { get; set; }

        // @property (copy, nonatomic) NSString * url;
        [Export("url")]
        string Url { get; set; }

        // @property (copy, nonatomic) NSString * aboutMe;
        [Export("aboutMe")]
        string AboutMe { get; set; }

        // @property (nonatomic) NSInteger verifyType;
        [Export("verifyType")]
        nint VerifyType { get; set; }

        // @property (copy, nonatomic) NSString * verifyReason;
        [Export("verifyReason")]
        string VerifyReason { get; set; }

        // @property (nonatomic, strong) NSDate * birthday;
        [Export("birthday", ArgumentSemantic.Strong)]
        NSDate Birthday { get; set; }

        // @property (nonatomic) NSInteger followerCount;
        [Export("followerCount")]
        nint FollowerCount { get; set; }

        // @property (nonatomic) NSInteger friendCount;
        [Export("friendCount")]
        nint FriendCount { get; set; }

        // @property (nonatomic) NSInteger shareCount;
        [Export("shareCount")]
        nint ShareCount { get; set; }

        // @property (nonatomic) NSTimeInterval regAt;
        [Export("regAt")]
        double RegAt { get; set; }

        // @property (nonatomic) NSInteger level;
        [Export("level")]
        nint Level { get; set; }

        // @property (retain, nonatomic) NSArray * educations;
        [Export("educations", ArgumentSemantic.Retain)]
        NSObject[] Educations { get; set; }

        // @property (retain, nonatomic) NSArray * works;
        [Export("works", ArgumentSemantic.Retain)]
        NSObject[] Works { get; set; }

        // @property (nonatomic, strong) NSDictionary * rawData;
        [Export("rawData", ArgumentSemantic.Strong)]
        NSDictionary RawData { get; set; }
    }

    // @interface SSDKUserQueryCondition : MOBFDataModel
    [BaseType(typeof(NSObject), Name = "SSDKUserQueryCondition")]
    interface SSDKUserQueryCondition
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * userName;
        [Export("userName")]
        string UserName { get; set; }

        // @property (copy, nonatomic) NSString * path;
        [Export("path")]
        string Path { get; set; }
    }

    /// <summary>
    /// 授权状态变化回调处理器
    /// </summary>
    // typedef void(^SSDKAuthorizeStateChangedHandler) (SSDKResponseState state, SSDKUser *user, NSError *error);
    //delegate void SSDKAuthorizeStateChangedHandler(SSDKResponseState state, SSDKUser user, NSError error);

    /// <summary>
    /// 获取用户状态变更回调处理器
    /// </summary>
    // typedef void(^SSDKGetUserStateChangedHandler) (SSDKResponseState state, SSDKUser *user, NSError *error);
    //delegate void SSDKGetUserStateChangedHandler(SSDKResponseState state, SSDKUser user, NSError error);

    /// <summary>
    /// 分享内容状态变更回调处理器
    /// </summary>
    // typedef void(^SSDKShareStateChangedHandler) (SSDKResponseState state, NSDictionary *userData, SSDKContentEntity *contentEntity,  NSError *error);
    //delegate void SSDKShareStateChangedHandler(SSDKResponseState state, NSDictionary userData, SSDKContentEntity contentEntity, NSError error);
}
