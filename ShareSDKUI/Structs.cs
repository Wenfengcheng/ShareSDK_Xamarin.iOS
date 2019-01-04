using System;
using ObjCRuntime;

namespace ShareSDK.UI
{
    [Native]
    public enum SSUIActionSheetStyle : long
    {
        /// <summary>
        /// 系统类型，默认
        /// </summary>
        System = 0,
        /// <summary>
        /// 简洁类型
        /// </summary>
        Simple = 1
    }

    [Native]
    public enum SSUIItemAlignment : ulong
    {
        Left,
        Center,
        Right
    }
}
