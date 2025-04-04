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
public abstract partial class Node :  BeanBase 
{
    public Node(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        NodeName = _json.GetProperty("node_name").GetString();
        PostInit();
    }

    public Node(int id, string node_name ) 
    {
        this.Id = id;
        this.NodeName = node_name;
        PostInit();
    }

    public static Node DeserializeNode(JsonElement _json)
    {
        switch (_json.GetProperty("$type").GetString())
        {
            case "UeSetDefaultFocus": return new ai.UeSetDefaultFocus(_json);
            case "ExecuteTimeStatistic": return new ai.ExecuteTimeStatistic(_json);
            case "ChooseTarget": return new ai.ChooseTarget(_json);
            case "KeepFaceTarget": return new ai.KeepFaceTarget(_json);
            case "GetOwnerPlayer": return new ai.GetOwnerPlayer(_json);
            case "UpdateDailyBehaviorProps": return new ai.UpdateDailyBehaviorProps(_json);
            case "UeLoop": return new ai.UeLoop(_json);
            case "UeCooldown": return new ai.UeCooldown(_json);
            case "UeTimeLimit": return new ai.UeTimeLimit(_json);
            case "UeBlackboard": return new ai.UeBlackboard(_json);
            case "UeForceSuccess": return new ai.UeForceSuccess(_json);
            case "IsAtLocation": return new ai.IsAtLocation(_json);
            case "DistanceLessThan": return new ai.DistanceLessThan(_json);
            case "Sequence": return new ai.Sequence(_json);
            case "Selector": return new ai.Selector(_json);
            case "SimpleParallel": return new ai.SimpleParallel(_json);
            case "UeWait": return new ai.UeWait(_json);
            case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_json);
            case "MoveToTarget": return new ai.MoveToTarget(_json);
            case "ChooseSkill": return new ai.ChooseSkill(_json);
            case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_json);
            case "MoveToLocation": return new ai.MoveToLocation(_json);
            case "DebugPrint": return new ai.DebugPrint(_json);
            default: throw new SerializationException();
        }
    }

    public int Id { get; private set; }
    public string NodeName { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
