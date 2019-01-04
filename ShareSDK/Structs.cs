using ObjCRuntime;

namespace ShareSDK
{
    /// <summary>
    /// 平台类型
    /// </summary>
    [Native]
    public enum SSDKPlatformType : ulong
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 新浪微博
        /// </summary>
        SinaWeibo = 1,
        /// <summary>
        /// 腾讯微博
        /// </summary>
        TencentWeibo = 2,
        /// <summary>
        /// 豆瓣
        /// </summary>
        DouBan = 5,
        /// <summary>
        /// QQ空间
        /// </summary>
        QZone = 6,
        /// <summary>
        /// 人人网
        /// </summary>
        Renren = 7,
        /// <summary>
        /// 开心网
        /// </summary>
        Kaixin = 8,
        /// <summary>
        /// Facebook
        /// </summary>
        Facebook = 10,
        /// <summary>
        /// Twitter
        /// </summary>
        Twitter = 11,
        /// <summary>
        /// 印象笔记
        /// </summary>
        YinXiang = 12,
        /// <summary>
        /// Google+
        /// </summary>
        GooglePlus = 14,
        /// <summary>
        /// Instagram
        /// </summary>
        Instagram = 15,
        /// <summary>
        /// LinkedIn
        /// </summary>
        LinkedIn = 16,
        /// <summary>
        /// Tumblr
        /// </summary>
        Tumblr = 17,
        /// <summary>
        /// 邮件
        /// </summary>
        Mail = 18,
        /// <summary>
        /// 短信
        /// </summary>
        SMS = 19,
        /// <summary>
        /// 打印
        /// </summary>
        Print = 20,
        /// <summary>
        /// 拷贝
        /// </summary>
        Copy = 21,
        /// <summary>
        /// 微信好友
        /// </summary>
        WechatSession = 22,
        /// <summary>
        /// 微信朋友圈
        /// </summary>
        WechatTimeline = 23,
        /// <summary>
        /// QQ好友
        /// </summary>
        QQFriend = 24,
        /// <summary>
        /// Instapaper
        /// </summary>
        Instapaper = 25,
        /// <summary>
        /// Pocket
        /// </summary>
        Pocket = 26,
        /// <summary>
        /// 有道云笔记
        /// </summary>
        YouDaoNote = 27,
        /// <summary>
        /// Pinterest
        /// </summary>
        Pinterest = 30,
        /// <summary>
        /// Flickr
        /// </summary>
        Flickr = 34,
        /// <summary>
        /// Dropbox
        /// </summary>
        Dropbox = 35,
        /// <summary>
        /// VKontakte
        /// </summary>
        VKontakte = 36,
        /// <summary>
        /// 微信收藏
        /// </summary>
        WechatFav = 37,
        /// <summary>
        /// 易信好友
        /// </summary>
        YiXinSession = 38,
        /// <summary>
        /// 易信朋友圈
        /// </summary>
        YiXinTimeline = 39,
        /// <summary>
        /// 易信收藏
        /// </summary>
        YiXinFav = 40,
        /// <summary>
        /// 明道
        /// </summary>
        MingDao = 41,
        /// <summary>
        /// Line
        /// </summary>
        Line = 42,
        /// <summary>
        /// WhatsApp
        /// </summary>
        WhatsApp = 43,
        /// <summary>
        /// KaKao Talk
        /// </summary>
        KakaoTalk = 44,
        /// <summary>
        /// KaKao Story
        /// </summary>
        KakaoStory = 45,
        /// <summary>
        /// Facebook Messenger
        /// </summary>
        FacebookMessenger = 46,
        /// <summary>
        /// Telegram
        /// </summary>
        Telegram = 47,
        /// <summary>
        /// 支付宝好友
        /// </summary>
        AliSocial = 50,
        /// <summary>
        /// 支付宝朋友圈
        /// </summary>
        AliSocialTimeline = 51,
        /// <summary>
        /// 钉钉
        /// </summary>
        DingTalk = 52,
        /// <summary>
        /// youtube
        /// </summary>
        YouTube = 53,
        /// <summary>
        /// 美拍
        /// </summary>
        MeiPai = 54,
        /// <summary>
        /// 中国移动
        /// </summary>
        CMCC = 55,
        /// <summary>
        /// Reddit
        /// </summary>
        Reddit = 56,
        /// <summary>
        /// 天翼
        /// </summary>
        ESurfing = 57,
        /// <summary>
        /// Facebook账户系统
        /// </summary>
        FacebookAccount = 58,
        /// <summary>
        /// 易信
        /// </summary>
        YiXin = 994,
        /// <summary>
        /// KaKao
        /// </summary>
        Kakao = 995,
        /// <summary>
        /// 印象笔记国际版
        /// </summary>
        Evernote = 996,
        /// <summary>
        /// 微信平台
        /// </summary>
        Wechat = 997,
        /// <summary>
        /// QQ平台
        /// </summary>
        QQ = 998,
        /// <summary>
        /// 任意平台
        /// </summary>
        Any = 999
    }

    /// <summary>
    /// 印象笔记服务器类型
    /// </summary>
    [Native]
    public enum SSDKEvernoteHostType : ulong
    {
        /// <summary>
        /// 沙箱
        /// </summary>
        Sandbox = 0,
        /// <summary>
        /// 印象笔记
        /// </summary>
        CN = 1,
        /// <summary>
        /// Evernote International
        /// </summary>
        US = 2
    }

    /// <summary>
    /// 回调状态
    /// </summary>
    [Native]
    public enum SSDKResponseState : ulong
    {
        /// <summary>
        /// 开始
        /// </summary>
        Begin = 0,
        /// <summary>
        /// 成功
        /// </summary>
        Success = 1,
        /// <summary>
        /// 失败
        /// </summary>
        Fail = 2,
        /// <summary>
        /// 取消
        /// </summary>
        Cancel = 3,
        /// <summary>
        /// 视频文件上传
        /// </summary>
        Upload = 4
    }

    /// <summary>
    /// 内容类型
    /// </summary>
    [Native]
    public enum SSDKContentType : ulong
    {
        /// <summary>
        /// 自动适配类型，视传入的参数来决定
        /// </summary>
        Auto = 0,
        /// <summary>
        /// 文本
        /// </summary>
        Text = 1,
        /// <summary>
        /// 图片
        /// </summary>
        Image = 2,
        /// <summary>
        /// 网页
        /// </summary>
        WebPage = 3,
        /// <summary>
        /// 应用
        /// </summary>
        App = 4,
        /// <summary>
        /// 音频
        /// </summary>
        Audio = 5,
        /// <summary>
        /// 视频
        /// </summary>
        Video = 6,
        /// <summary>
        /// 文件类型(暂时仅微信可用)
        /// </summary>
        File = 7,
        /// <summary>
        /// 图片类型 仅FacebookMessage 分享图片并需要明确结果时 注此类型分享后不会显示应用名称与icon
        /// </summary>
        FBMessageImages = 8,
        /// <summary>
        /// 图片类型 仅FacebookMessage 分享视频并需要明确结果时 注此类型分享后不会显示应用名称与icon
        /// </summary>
        FBMessageVideo = 9,
        /// <summary>
        /// 小程序分享(暂时仅微信可用)
        /// </summary>
        MiniProgram = 10
    }

    /// <summary>
    /// 授权方式
    /// </summary>
    [Native]
    public enum SSDKAuthorizeType : ulong
    {
        /// <summary>
        /// SSO授权
        /// </summary>
        Sso,
        /// <summary>
        /// 网页授权
        /// </summary>
        Web,
        /// <summary>
        /// SSO＋网页授权
        /// </summary>
        Both
    }

    /// <summary>
    /// 分享行为事件统计
    /// </summary>
    [Native]
    public enum SSDKShareEventType : ulong
    {
        /// <summary>
        /// 打开分享菜单
        /// </summary>
        OpenMenu,
        /// <summary>
        /// 关闭分享菜单
        /// </summary>
        CloseMenu,
        /// <summary>
        /// 打开内容编辑视图
        /// </summary>
        OpenEditor,
        /// <summary>
        /// 分享失败
        /// </summary>
        Failed,
        /// <summary>
        /// 分享取消
        /// </summary>
        Cancel
    }

    /// <summary>
    /// 文件上传状态
    /// </summary>
    [Native]
    public enum SSDKUploadState : ulong
    {
        /// <summary>
        /// 开始上传
        /// </summary>
        Begin = 1,
        /// <summary>
        /// 上传中
        /// </summary>
        Uploading,
        /// <summary>
        /// 结束上传
        /// </summary>
        Finish
    }

    /// <summary>
    /// YouTube 视频的隐私状态
    /// </summary>
    [Native]
    public enum SSDKPrivacyStatus : ulong
    {
        /// <summary>
        /// 私有（只有自己可以观看）
        /// </summary>
        Public = 0,
        /// <summary>
        /// 公开（任何人都可以搜索和观看）
        /// </summary>
        Private = 1,
        /// <summary>
        /// 不公开（知道链接的人可以观看）
        /// </summary>
        Unlisted = 2
    }

    /// <summary>
    /// 授权类型
    /// </summary>
    [Native]
    public enum SSDKCredentialType : ulong
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// OAuth 1.x
        /// </summary>
        OAuth1x = 1,
        /// <summary>
        /// OAuth 2
        /// </summary>
        OAuth2 = 2,
        /// <summary>
        /// 短信
        /// </summary>
        Sms = 3
    }

    /// <summary>
    /// 性别
    /// </summary>
    [Native]
    public enum SSDKGender : ulong
    {
        /// <summary>
        /// 男
        /// </summary>
        Male = 0,
        /// <summary>
        /// 女
        /// </summary>
        Female = 1,
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = 2
    }
}
