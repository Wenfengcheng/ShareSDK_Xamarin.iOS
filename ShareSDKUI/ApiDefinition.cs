using System;
using Foundation;
using ObjCRuntime;
using ShareSDK;
using UIKit;

namespace ShareSDK.UI
{
    //@interface SSUIEditorConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface SSUIEditorConfiguration
    {
        // @property (strong, nonatomic) UIImage *iPhoneNavigationBarBackgroundImage;
        [Export("iPhoneNavigationBarBackgroundImage", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIImage IPhoneNavigationBarBackgroundImage { get; set; }

        //@property (strong, nonatomic) UIColor *iPhoneNavigationBarBackgroundColor;
        [Export("iPhoneNavigationBarBackgroundColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor IPhoneNavigationBarBackgroundColor { get; set; }

        //@property (strong, nonatomic) UIColor *iPadNavigationBarBackgroundColor;
        [Export("iPadNavigationBarBackgroundColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor IPadNavigationBarBackgroundColor { get; set; }

        //@property (strong, nonatomic) UIColor *editorViewBackgroundColor;
        [Export("editorViewBackgroundColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor EditorViewBackgroundColor { get; set; }

        //@property (strong, nonatomic) UIColor *textViewBackgroundColor;
        [Export("textViewBackgroundColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor TextViewBackgroundColor { get; set; }

        //@property (nonatomic, copy) NSString *title;
        [Export("title", ArgumentSemantic = ArgumentSemantic.Copy)]
        string Title { get; set; }

        //@property (strong, nonatomic) UIColor *titleColor;
        [Export("titleColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        //@property (copy, nonatomic) NSString *cancelButtonTitle;
        [Export("cancelButtonTitle", ArgumentSemantic = ArgumentSemantic.Copy)]
        string CancelButtonTitle { get; set; }

        //@property (strong, nonatomic) UIColor *cancelButtonTitleColor;
        [Export("cancelButtonTitleColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor CancelButtonTitleColor { get; set; }

        //@property (strong, nonatomic) UIImage *cancelButtonImage;
        [Export("cancelButtonImage", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIImage CancelButtonImage { get; set; }

        //@property (copy, nonatomic) NSString *shareButtonTitle;
        [Export("shareButtonTitle", ArgumentSemantic = ArgumentSemantic.Copy)]
        string ShareButtonTitle { get; set; }

        //@property (strong, nonatomic) UIColor *shareButtonTitleColor;
        [Export("shareButtonTitleColor", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIColor ShareButtonTitleColor { get; set; }

        //@property (strong, nonatomic) UIImage *shareButtonImage;
        [Export("shareButtonImage", ArgumentSemantic = ArgumentSemantic.Strong)]
        UIImage ShareButtonImage { get; set; }

        //@property (assign, nonatomic) UIInterfaceOrientationMask interfaceOrientationMask;
        [Export("interfaceOrientationMask", ArgumentSemantic = ArgumentSemantic.Assign)]
        UIInterfaceOrientationMask InterfaceOrientationMask { get; set; }

        //@property (assign, nonatomic) UIStatusBarStyle statusBarStyle;
        [Export("statusBarStyle", ArgumentSemantic = ArgumentSemantic.Assign)]
        UIStatusBarStyle StatusBarStyle { get; set; }
    }

    // @interface SSUIPlatformItem : NSObject
    [BaseType(typeof(NSObject))]
    interface SSUIPlatformItem
    {
        // +(instancetype)itemWithPlatformType:(id)platformType;
        [Static]
        [Export("itemWithPlatformType:")]
        SSUIPlatformItem ItemWithPlatformType(SSDKPlatformType platformType);

        // @property (copy, nonatomic) NSString * platformId;
        [Export("platformId")]
        string PlatformId { get; set; }

        // @property (nonatomic, strong) UIImage * iconNormal;
        [Export("iconNormal", ArgumentSemantic.Strong)]
        UIImage IconNormal { get; set; }

        // @property (nonatomic, strong) UIImage * iconSimple;
        [Export("iconSimple", ArgumentSemantic.Strong)]
        UIImage IconSimple { get; set; }

        // @property (nonatomic, strong) NSString * platformName;
        [Export("platformName", ArgumentSemantic.Strong)]
        string PlatformName { get; set; }

        // -(void)addTarget:(id)target action:(SEL)selector;
        [Export("addTarget:action:")]
        void AddTarget(NSObject target, Selector selector);

        // -(void)triggerClick;
        [Export("triggerClick")]
        void TriggerClick();
    }

    // @interface SSUIShareSheetConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface SSUIShareSheetConfiguration
    {
        // @property (assign, nonatomic) SSUIActionSheetStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        SSUIActionSheetStyle Style { get; set; }

        // @property (assign, nonatomic) NSInteger columnPortraitCount;
        [Export("columnPortraitCount", ArgumentSemantic.Assign)]
        nint ColumnPortraitCount { get; set; }

        // @property (assign, nonatomic) NSInteger columnLandscapeCount;
        [Export("columnLandscapeCount", ArgumentSemantic.Assign)]
        nint ColumnLandscapeCount { get; set; }

        // @property (nonatomic, strong) UIColor * shadeColor;
        [Export("shadeColor", ArgumentSemantic.Strong)]
        UIColor ShadeColor { get; set; }

        // @property (nonatomic, strong) UIColor * menuBackgroundColor;
        [Export("menuBackgroundColor", ArgumentSemantic.Strong)]
        UIColor MenuBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * itemTitleColor;
        [Export("itemTitleColor", ArgumentSemantic.Strong)]
        UIColor ItemTitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * itemTitleFont;
        [Export("itemTitleFont", ArgumentSemantic.Strong)]
        UIFont ItemTitleFont { get; set; }

        // @property (getter = isCancelButtonHidden, assign, nonatomic) BOOL cancelButtonHidden;
        [Export("cancelButtonHidden", ArgumentSemantic.Assign)]
        bool CancelButtonHidden { [Bind("isCancelButtonHidden")] get; set; }

        // @property (nonatomic, strong) UIColor * cancelButtonTitleColor;
        [Export("cancelButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * cancelButtonBackgroundColor;
        [Export("cancelButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * pageIndicatorTintColor;
        [Export("pageIndicatorTintColor", ArgumentSemantic.Strong)]
        UIColor PageIndicatorTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * currentPageIndicatorTintColor;
        [Export("currentPageIndicatorTintColor", ArgumentSemantic.Strong)]
        UIColor CurrentPageIndicatorTintColor { get; set; }

        // @property (assign, nonatomic) UIInterfaceOrientationMask interfaceOrientationMask;
        [Export("interfaceOrientationMask", ArgumentSemantic.Assign)]
        UIInterfaceOrientationMask InterfaceOrientationMask { get; set; }

        // @property (assign, nonatomic) UIStatusBarStyle statusBarStyle;
        [Export("statusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle StatusBarStyle { get; set; }

        // @property (assign, nonatomic) SSUIItemAlignment itemAlignment;
        [Export("itemAlignment", ArgumentSemantic.Assign)]
        SSUIItemAlignment ItemAlignment { get; set; }

        // @property (nonatomic, strong) NSArray * directSharePlatforms;
        [Export("directSharePlatforms", ArgumentSemantic.Strong)]
        NSObject[] DirectSharePlatforms { get; set; }
    }

    // @interface SSUI
    [Category]
    [BaseType(typeof(ShareSDK))]
    interface ShareSDK_UI
    {
        // +(id)showShareActionSheet:(UIView *)view customItems:(NSArray *)items shareParams:(NSMutableDictionary *)shareParams sheetConfiguration:(SSUIShareSheetConfiguration *)configuration onStateChanged:(SSUIShareStateChangedHandler)stateChangedHandler;
        [Static]
        [Export("showShareActionSheet:customItems:shareParams:sheetConfiguration:onStateChanged:")]
        NSObject ShowShareActionSheet([NullAllowed]UIView view, [NullAllowed] NSObject[] items, NSMutableDictionary shareParams, [NullAllowed]SSUIShareSheetConfiguration configuration, SSUIShareStateChangedHandler stateChangedHandler);

        // +(void)shareActionSheet:(id)sheet setEditorConfiguration:(SSUIEditorConfiguration *)configuration;
        [Static]
        [Export("shareActionSheet:setEditorConfiguration:")]
        void ShareActionSheet(NSObject sheet, SSUIEditorConfiguration configuration);

        // +(id)showShareEditor:(id)platformType otherPlatforms:(NSArray *)platformTypes shareParams:(NSMutableDictionary *)shareParams editorConfiguration:(SSUIEditorConfiguration *)configuration onStateChanged:(SSUIShareStateChangedHandler)shareStateChangedHandler;
        [Static]
        [Export("showShareEditor:otherPlatforms:shareParams:editorConfiguration:onStateChanged:")]
        NSObject ShowShareEditor(NSObject platformType, NSObject[] platformTypes, NSMutableDictionary shareParams, SSUIEditorConfiguration configuration, SSUIShareStateChangedHandler shareStateChangedHandler);

        // +(void)dismissShareController:(id)controller;
        [Static]
        [Export("dismissShareController:")]
        void DismissShareController(NSObject controller);
    }

    /*
     * 分享状态变更
    typedef void (^SSUIShareStateChangedHandler) (SSDKResponseState state,
                                                  SSDKPlatformType platformType,
                                                  NSDictionary* userData,
                                                  SSDKContentEntity* contentEntity,
                                                  NSError* error,
                                                  BOOL end);
    */
    unsafe delegate void SSUIShareStateChangedHandler(ulong state, ulong platformType, NSDictionary userData, NSObject contentEntity, NSError error, bool end);

}
