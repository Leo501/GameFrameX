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
public sealed partial class UeTimeLimit :  ai.Decorator 
{
    public UeTimeLimit(JsonElement _json)  : base(_json) 
    {
        LimitTime = _json.GetProperty("limit_time").GetSingle();
        PostInit();
    }

    public UeTimeLimit(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, float limit_time )  : base(id,node_name,flow_abort_mode) 
    {
        this.LimitTime = limit_time;
        PostInit();
    }

    public static UeTimeLimit DeserializeUeTimeLimit(JsonElement _json)
    {
        return new ai.UeTimeLimit(_json);
    }

    public float LimitTime { get; private set; }

    public const int __ID__ = 338469720;
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
        + "LimitTime:" + LimitTime + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
