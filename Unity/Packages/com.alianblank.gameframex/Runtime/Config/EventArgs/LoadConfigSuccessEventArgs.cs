﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFrameX.Event;

namespace GameFrameX.Config
{
    /// <summary>
    /// 加载全局配置成功事件。
    /// </summary>
    public sealed class LoadConfigSuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 加载全局配置成功事件编号。
        /// </summary>
        public static readonly string EventId = typeof(LoadConfigSuccessEventArgs).FullName;

        /// <summary>
        /// 初始化加载全局配置成功事件编号的新实例。
        /// </summary>
        public LoadConfigSuccessEventArgs()
        {
            ConfigAssetName = null;
            Duration = 0f;
            UserData = null;
        }

        /// <summary>
        /// 获取加载全局配置成功事件编号。
        /// </summary>
        public override string Id
        {
            get { return EventId; }
        }

        /// <summary>
        /// 获取全局配置资源名称。
        /// </summary>
        public string ConfigAssetName { get; private set; }

        /// <summary>
        /// 获取加载持续时间。
        /// </summary>
        public float Duration { get; private set; }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData { get; private set; }

        /// <summary>
        /// 创建加载全局配置成功事件。
        /// </summary>
        /// <param name="dataAssetName"></param>
        /// <param name="duration"></param>
        /// <param name="userData"></param>
        /// <returns>创建的加载全局配置成功事件。</returns>
        public static LoadConfigSuccessEventArgs Create(string dataAssetName, float duration, object userData)
        {
            LoadConfigSuccessEventArgs loadConfigSuccessEventArgs = ReferencePool.Acquire<LoadConfigSuccessEventArgs>();
            loadConfigSuccessEventArgs.ConfigAssetName = dataAssetName;
            loadConfigSuccessEventArgs.Duration = duration;
            loadConfigSuccessEventArgs.UserData = userData;
            return loadConfigSuccessEventArgs;
        }

        /// <summary>
        /// 清理加载全局配置成功事件。
        /// </summary>
        public override void Clear()
        {
            ConfigAssetName = null;
            Duration = 0f;
            UserData = null;
        }
    }
}