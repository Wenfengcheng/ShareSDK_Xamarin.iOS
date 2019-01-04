using System;
using Foundation;
using ObjCRuntime;

namespace ShareSDK.Extension
{
    // @interface Extension
    [Category]
    [BaseType(typeof(ShareSDK))]
    interface Extension
    {
        // +(BOOL)isClientInstalled:(id)platformType;
        [Static]
        [Export("isClientInstalled:")]
        bool IsClientInstalled(NSObject platformType);

        // +(id)currentUser:(id)platformType;
        [Static]
        [Export("currentUser:")]
        NSObject CurrentUser(NSObject platformType);

        // +(void)setCurrentUser:(id)user forPlatformType:(id)platformType;
        [Static]
        [Export("setCurrentUser:forPlatformType:")]
        void SetCurrentUser(NSObject user, NSObject platformType);

        // +(id)userByRawData:(NSDictionary *)userRawData credential:(NSDictionary *)credentialRawData forPlatformType:(id)platformType;
        [Static]
        [Export("userByRawData:credential:forPlatformType:")]
        NSObject UserByRawData(NSDictionary userRawData, NSDictionary credentialRawData, NSObject platformType);

        // +(void)addFriend:(id)platformType user:(id)user onStateChanged:(SSDKAddFriendStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("addFriend:user:onStateChanged:")]
        void AddFriend(NSObject platformType, NSObject user, [NullAllowed]Action<SSDKResponseState, SSDKUser, NSError> stateChangedHandler);

        // +(void)getFriends:(id)platformType cursor:(NSUInteger)cursor size:(NSUInteger)size onStateChanged:(SSDKGetFriendsStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("getFriends:cursor:size:onStateChanged:")]
        void GetFriends(NSObject platformType, nuint cursor, nuint size, [NullAllowed]Action<SSDKResponseState, SSEFriendsPaging, NSError> stateChangedHandler);

        // +(void)callApi:(id)type url:(NSString *)url method:(NSString *)method parameters:(NSMutableDictionary *)parameters headers:(NSMutableDictionary *)headers onStateChanged:(SSDKCallApiStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("callApi:url:method:parameters:headers:onStateChanged:")]
        void CallApi(NSObject type, string url, string method, NSMutableDictionary parameters, NSMutableDictionary headers, [NullAllowed]Action<SSDKResponseState, NSObject, NSError> stateChangedHandler);
    }

    // @interface SSEBaseUser : MOBFDataModel
    [BaseType(typeof(NSObject), Name = "SSEBaseUser")]
    interface SSEBaseUser
    {
        // @property (copy, nonatomic) NSString * linkId;
        [Export("linkId")]
        string LinkId { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary * socialUsers;
        [Export("socialUsers", ArgumentSemantic.Strong)]
        NSMutableDictionary SocialUsers { get; set; }

        // -(void)updateInfo:(id)data;
        [Export("updateInfo:")]
        void UpdateInfo(NSObject data);
    }

    // @interface SSEFriendsPaging : MOBFDataModel
    [BaseType(typeof(NSObject), Name = "SSEFriendsPaging")]
    interface SSEFriendsPaging
    {
        // @property (nonatomic) NSInteger prevCursor;
        [Export("prevCursor")]
        nint PrevCursor { get; set; }

        // @property (nonatomic) NSInteger nextCursor;
        [Export("nextCursor")]
        nint NextCursor { get; set; }

        // @property (nonatomic) NSUInteger total;
        [Export("total")]
        nuint Total { get; set; }

        // @property (nonatomic) BOOL hasNext;
        [Export("hasNext")]
        bool HasNext { get; set; }

        // @property (nonatomic, strong) NSArray * users;
        [Export("users", ArgumentSemantic.Strong)]
        NSObject[] Users { get; set; }
    }

    // @interface SSEShareHelper : NSObject
    [BaseType(typeof(NSObject), Name = "SSEShareHelper")]
    interface SSEShareHelper
    {
        // +(void)screenCaptureShare:(SSEScreenCaptureWillShareHandler)willShareHandler onStateChanged:(id)stateChangedHandler;
        [Static]
        [Export("screenCaptureShare:onStateChanged:")]
        void ScreenCaptureShare([NullAllowed]Action<SSDKImage, SSEShareHandler> willShareHandler, [NullAllowed]Action<SSDKResponseState, NSDictionary, SSDKContentEntity, NSError> stateChangedHandler);

        // +(void)beginShakeShare:(void (^)(void))beginShakeHandler onEndSake:(void (^)(void))endShakeHandler onWillShareHandler:(SSEShakeWillShareHandler)willShareHandler onStateChanged:(id)stateChangedHandler;
        [Static]
        [Export("beginShakeShare:onEndSake:onWillShareHandler:onStateChanged:")]
        void BeginShakeShare([NullAllowed]Action beginShakeHandler, [NullAllowed]Action endShakeHandler, [NullAllowed]Action<SSEShareHandler> willShareHandler, [NullAllowed]Action<SSDKResponseState, NSDictionary, SSDKContentEntity, NSError> stateChangedHandler);

        // +(void)endShakeShare;
        [Static]
        [Export("endShakeShare")]
        void EndShakeShare();
    }

    // @interface SSEThirdPartyLoginHelper : NSObject
    [BaseType(typeof(NSObject), Name = "SSEThirdPartyLoginHelper")]
    interface SSEThirdPartyLoginHelper
    {
        // +(void)loginByPlatform:(id)platform onUserSync:(SSEUserSyncHandler)userSyncHandler onLoginResult:(SSELoginResultHandler)loginResultHandler;
        [Static]
        [Export("loginByPlatform:onUserSync:onLoginResult:")]
        void LoginByPlatform(NSObject platform, [NullAllowed]Action<SSDKUser, SSEUserAssociateHandler> userSyncHandler, [NullAllowed]Action<SSDKResponseState, SSEBaseUser, NSError> loginResultHandler);

        // +(BOOL)logout:(SSEBaseUser *)user;
        [Static]
        [Export("logout:")]
        bool Logout(SSEBaseUser user);

        // +(SSEBaseUser *)currentUser;
        [Static]
        [Export("currentUser")]
        SSEBaseUser CurrentUser { get; }

        // +(BOOL)changeUser:(SSEBaseUser *)user;
        [Static]
        [Export("changeUser:")]
        bool ChangeUser(SSEBaseUser user);

        // +(NSDictionary *)users;
        [Static]
        [Export("users")]
        NSDictionary Users { get; }

        // +(void)setUserClass:(Class)userClass;
        [Static]
        [Export("setUserClass:")]
        void SetUserClass(SSEBaseUser userClass);
    }

    // @interface SSEUserManager : NSObject
    [BaseType(typeof(NSObject), Name = "SSEUserManager")]
    interface SSEUserManager
    {
        // @property (copy, nonatomic) NSString * currentUserLinkId;
        [Export("currentUserLinkId")]
        string CurrentUserLinkId { get; set; }

        // @property (readonly, nonatomic, strong) NSDictionary * users;
        [Export("users", ArgumentSemantic.Strong)]
        NSDictionary Users { get; }

        // +(instancetype)defaultManager;
        [Static]
        [Export("defaultManager")]
        SSEUserManager DefaultManager();

        // -(void)addUser:(SSEBaseUser *)user;
        [Export("addUser:")]
        void AddUser(SSEBaseUser user);

        // -(void)removeUser:(SSEBaseUser *)user;
        [Export("removeUser:")]
        void RemoveUser(SSEBaseUser user);

        // -(void)save;
        [Export("save")]
        void Save();
    }

    /// <summary>
    /// 分享事件处理器
    /// </summary>
    //typedef void (^SSEShareHandler) (SSDKPlatformType platformType, NSMutableDictionary* parameters);
    delegate void SSEShareHandler(ulong platformType, NSMutableDictionary parameters);

    /// <summary>
    /// 屏幕截图将要分享事件处理器
    /// </summary>
    // typedef void(^SSEScreenCaptureWillShareHandler) (SSDKImage *image, SSEShareHandler shareHandler);
    //delegate void SSEScreenCaptureWillShareHandler(SSDKImage image, SSEShareHandler shareHandler);

    /// <summary>
    /// 摇一摇将要分享事件处理器
    /// </summary>
    // typedef void(^SSEShakeWillShareHandler) (SSEShareHandler shareHandler);
    //unsafe delegate void SSEShakeWillShareHandler(SSEShareHandler shareHandler);

    /// <summary>
    /// 一键分享内容状态变更回调处理器
    /// </summary>
    // typedef void(^SSEOneKeyShareStateChangeHandler) (SSDKPlatformType platformType, SSDKResponseState state, NSDictionary *userData, SSDKContentEntity *contentEntity, NSError *error, BOOL end);
    //unsafe delegate void SSEOneKeyShareStateChangeHandler(SSDKPlatformType platformType, SSDKResponseState state, NSDictionary userData, SSDKContentEntity contentEntity, NSError error, bool end);

    /// <summary>
    /// 用户关联事件处理器
    /// </summary>
    // typedef void (^SSEUserAssociateHandler) (NSString *linkId, SSDKUser *user, id userData);
    unsafe delegate void SSEUserAssociateHandler(string linkId, NSObject user, NSObject userData);

    /// <summary>
    /// 用户同步事件处理器
    /// </summary>
    // typedef void (^SSEUserSyncHandler) (SSDKUser *user, SSEUserAssociateHandler associateHandler);
    //unsafe delegate void SSEUserSyncHandler(SSDKUser user, SSEUserAssociateHandler associateHandler);

    /// <summary>
    /// 用户登录返回事件处理器
    /// </summary>
    // typedef void (^SSELoginResultHandler) (SSDKResponseState state, SSEBaseUser *user, NSError *error);
    //unsafe delegate void SSELoginResultHandler(SSDKResponseState state, SSEBaseUser user, NSError error);

    /// <summary>
    /// 添加/关注好友状态变更回调处理器
    /// </summary>
    // typedef void(^SSDKAddFriendStateChangedHandler) (SSDKResponseState state, SSDKUser *user, NSError *error);
    //unsafe delegate void SSDKAddFriendStateChangedHandler(SSDKResponseState state, SSDKUser user, NSError error);

    /// <summary>
    /// 获取好友列表状态变更回调处理器
    /// </summary>
    // typedef void(^SSDKGetFriendsStateChangedHandler) (SSDKResponseState state, SSEFriendsPaging *paging,  NSError *error);
    //unsafe delegate void SSDKGetFriendsStateChangedHandler(SSDKResponseState state, SSEFriendsPaging paging, NSError error);

    /// <summary>
    /// 调用API状态变更回调处理器
    /// </summary>
    // typedef void(^SSDKCallApiStateChangedHandler)(SSDKResponseState state, id data, NSError *error);
    //unsafe delegate void SSDKCallApiStateChangedHandler(SSDKResponseState state, NSObject data, NSError error);
}
