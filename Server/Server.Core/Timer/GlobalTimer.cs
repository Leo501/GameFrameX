﻿using Server.Core.Actors;
using Server.DBServer;
using Server.Extension;
using Server.Setting;

namespace Server.Core.Timer
{
    public static class GlobalTimer
    {
        /// <summary>
        /// 日志记录器
        /// </summary>
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 循环任务
        /// </summary>
        private static Task LoopTask;

        /// <summary>
        /// 是否正在工作
        /// </summary>
        public static volatile bool working = false;

        /// <summary>
        /// 开始全局定时
        /// </summary>
        public static void Start()
        {
            working = true;
            LoopTask = Task.Run(Loop);
            Log.Info($"初始化全局定时完成");
        }

        /// <summary>
        /// 循环执行的方法
        /// </summary>
        private static async Task Loop()
        {
            var nextSaveTime = NextSaveTime();
            var saveInterval = TimeSpan.FromMilliseconds(GlobalConst.SAVE_INTERVAL_IN_MilliSECONDS);
            var ONCE_DELAY = TimeSpan.FromMilliseconds(200);

            while (working)
            {
                Log.Info($"下次定时回存时间 {nextSaveTime}");

                while (DateTime.Now < nextSaveTime && working)
                {
                    await Task.Delay(ONCE_DELAY);
                }

                if (!working)
                    break;

                var startTime = DateTime.Now;

                await GameDb.TimerSave();

                var cost = (DateTime.Now - startTime).TotalMilliseconds;
                Log.Info($"定时回存完成 耗时: {cost:f4}ms");

                await ActorMgr.CheckIdle();

                do
                {
                    nextSaveTime = nextSaveTime.Add(saveInterval);
                } while (DateTime.Now > nextSaveTime);
            }
        }

        /// <summary>
        /// 计算下次回存时间
        /// </summary>
        /// <returns>下次回存时间</returns>
        private static DateTime NextSaveTime()
        {
            var now = DateTime.Now;
            var t = now.Date.AddHours(now.Hour);

            while (t < now)
            {
                t = t.AddMilliseconds(GlobalConst.SAVE_INTERVAL_IN_MilliSECONDS);
            }

            int serverId = GlobalSettings.ServerId;
            int a = serverId % 1000;
            int b = a % GlobalConst.MAGIC;
            int c = GlobalConst.SAVE_INTERVAL_IN_MilliSECONDS / GlobalConst.MAGIC;
            int r = ThreadLocalRandom.Current.Next(0, c);
            int delay = b * c + r;
            t = t.AddMilliseconds(delay);

            if ((t - now).TotalMilliseconds > GlobalConst.SAVE_INTERVAL_IN_MilliSECONDS)
            {
                t = t.AddMilliseconds(-GlobalConst.SAVE_INTERVAL_IN_MilliSECONDS);
            }

            return t;
        }

        /// <summary>
        /// 停止全局定时
        /// </summary>
        public static async Task Stop()
        {
            working = false;
            await LoopTask;
            await GameDb.SaveAll();
            GameDb.Close();
            Log.Info($"停止全局定时完成");
        }
    }
}