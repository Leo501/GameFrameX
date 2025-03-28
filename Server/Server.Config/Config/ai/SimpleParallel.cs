//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;
using Server.Config.Core;


namespace cfg.ai
{
public sealed partial class SimpleParallel :  ai.ComposeNode 
{
    public SimpleParallel(JsonElement _json)  : base(_json) 
    {
        FinishMode = (ai.EFinishMode)_json.GetProperty("finish_mode").GetInt32();
        MainTask = ai.Task.DeserializeTask(_json.GetProperty("main_task"));
        BackgroundNode = ai.FlowNode.DeserializeFlowNode(_json.GetProperty("background_node"));
        PostInit();
    }

    public SimpleParallel(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, ai.EFinishMode finish_mode, ai.Task main_task, ai.FlowNode background_node )  : base(id,node_name,decorators,services) 
    {
        this.FinishMode = finish_mode;
        this.MainTask = main_task;
        this.BackgroundNode = background_node;
        PostInit();
    }

    public static SimpleParallel DeserializeSimpleParallel(JsonElement _json)
    {
        return new ai.SimpleParallel(_json);
    }

    public ai.EFinishMode FinishMode { get; private set; }
    public ai.Task MainTask { get; private set; }
    public ai.FlowNode BackgroundNode { get; private set; }

    public const int __ID__ = -1952582529;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        MainTask?.Resolve(_tables);
        BackgroundNode?.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        MainTask?.TranslateText(translator);
        BackgroundNode?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + StringUtil.CollectionToString(Services) + ","
        + "FinishMode:" + FinishMode + ","
        + "MainTask:" + MainTask + ","
        + "BackgroundNode:" + BackgroundNode + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
