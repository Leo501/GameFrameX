//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{
public sealed partial class UeLoop :  ai.Decorator 
{
    public UeLoop(JsonElement _json)  : base(_json) 
    {
        NumLoops = _json.GetProperty("num_loops").GetInt32();
        InfiniteLoop = _json.GetProperty("infinite_loop").GetBoolean();
        InfiniteLoopTimeoutTime = _json.GetProperty("infinite_loop_timeout_time").GetSingle();
        PostInit();
    }

    public UeLoop(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, int num_loops, bool infinite_loop, float infinite_loop_timeout_time )  : base(id,node_name,flow_abort_mode) 
    {
        this.NumLoops = num_loops;
        this.InfiniteLoop = infinite_loop;
        this.InfiniteLoopTimeoutTime = infinite_loop_timeout_time;
        PostInit();
    }

    public static UeLoop DeserializeUeLoop(JsonElement _json)
    {
        return new ai.UeLoop(_json);
    }

    public int NumLoops { get; private set; }
    public bool InfiniteLoop { get; private set; }
    public float InfiniteLoopTimeoutTime { get; private set; }

    public const int __ID__ = -513308166;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "NumLoops:" + NumLoops + ","
        + "InfiniteLoop:" + InfiniteLoop + ","
        + "InfiniteLoopTimeoutTime:" + InfiniteLoopTimeoutTime + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
