﻿using System.Collections.Concurrent;
using Server.Core.Actors.Impl;
using Server.Core.Comps;
using Server.Core.Hotfix.Agent;
using Server.Core.Timer;

namespace Server.Core.Actors
{
    public sealed class Actor
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        private readonly ConcurrentDictionary<Type, BaseComp> compDic = new ConcurrentDictionary<Type, BaseComp>();

        public long Id { get; init; }

        public ActorType Type { get; init; }

        public WorkerActor WorkerActor { get; init; }

        public bool AutoRecycle { get; private set; } = false;

        public HashSet<long> ScheduleIdSet = new HashSet<long>();

        public void SetAutoRecycle(bool autoRecycle)
        {
            Tell(() => { AutoRecycle = autoRecycle; });
        }

        public async Task<T> GetCompAgent<T>() where T : IComponentAgent
        {
            return (T) await GetCompAgent(typeof(T));
        }

        public async Task<IComponentAgent> GetCompAgent(Type agentType)
        {
            var compType = agentType.BaseType.GetGenericArguments()[0];
            var comp = compDic.GetOrAdd(compType, GetOrAddFactory);
            var agent = comp.GetAgent(agentType);
            if (!comp.IsActive)
            {
                async Task Worker()
                {
                    await comp.Active();
                    agent.Active();
                }

                await SendAsyncWithoutCheck(Worker);
            }

            return agent;
        }

        private BaseComp GetOrAddFactory(Type k)
        {
            return ComponentRegister.NewComp(this, k);
        }

        public const int TIME_OUT = int.MaxValue;

        public Actor(long id, ActorType type)
        {
            Id = id;
            Type = type;
            WorkerActor = new WorkerActor(id);

            if (type == ActorType.Player)
            {
                Tell(() => SetAutoRecycle(true));
            }
            else
            {
                Tell(() => ComponentRegister.ActiveComps(this));
            }
        }

        public async Task CrossDay(int openServerDay)
        {
            Log.Debug($"actor跨天 id:{Id} type:{Type}");
            foreach (var comp in compDic.Values)
            {
                var agent = comp.GetAgent();
                if (agent is ICrossDay crossDay)
                {
                    // 使用try-catch缩小异常影响范围
                    try
                    {
                        await crossDay.OnCrossDay(openServerDay);
                    }
                    catch (Exception e)
                    {
                        Log.Error($"{agent.GetType().FullName}跨天失败 actorId:{Id} actorType:{Type} 异常：\n{e}");
                    }
                }
            }
        }

        internal bool ReadyToDeactive => compDic.Values.All(item => item.ReadyToInactive);

        internal async Task SaveAllState()
        {
            foreach (var item in compDic)
            {
                await item.Value.SaveState();
            }
        }

        public async Task DeActive()
        {
            foreach (var item in compDic.Values)
            {
                await item.Inactive();
            }
        }

        #region actor 入队

        public void Tell(Action work, int timeout = TIME_OUT)
        {
            WorkerActor.Tell(work, timeout);
        }

        public void Tell(Func<Task> work, int timeout = TIME_OUT)
        {
            WorkerActor.Tell(work, timeout);
        }

        public Task SendAsync(Action work, int timeout = TIME_OUT)
        {
            return WorkerActor.SendAsync(work, timeout);
        }

        public Task<T> SendAsync<T>(Func<T> work, int timeout = TIME_OUT)
        {
            return WorkerActor.SendAsync(work, timeout);
        }

        public Task SendAsync(Func<Task> work, int timeout = TIME_OUT)
        {
            return WorkerActor.SendAsync(work, timeout);
        }

        public Task SendAsyncWithoutCheck(Func<Task> work, int timeout = TIME_OUT)
        {
            return WorkerActor.SendAsync(work, timeout, false);
        }

        public Task<T> SendAsync<T>(Func<Task<T>> work, int timeout = TIME_OUT)
        {
            return WorkerActor.SendAsync(work, timeout);
        }

        #endregion

        public override string ToString()
        {
            return $"{base.ToString()}_{Type}_{Id}";
        }

        public void ClearAgent()
        {
            foreach (var comp in compDic.Values)
            {
                comp.ClearCacheAgent();
            }
        }
    }
}