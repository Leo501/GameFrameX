﻿using Server.Core.Hotfix.Agent;
using Server.Utility;

namespace Server.Core.Utility
{
    public interface IAgentCallback
    {
        Task<bool> Invoke(IComponentAgent agent, Param param = null);

        Type CompAgentType();
    }

    public abstract class AgentCallback<TAgent> : IAgentCallback where TAgent : IComponentAgent
    {
        public Type CompAgentType()
        {
            return typeof(TAgent);
        }

        public Task<bool> Invoke(IComponentAgent agent, Param param = null)
        {
            return OnCall((TAgent) agent, param);
        }

        protected abstract Task<bool> OnCall(TAgent comp, Param param);
    }
}