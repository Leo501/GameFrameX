//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.item
{
public sealed partial class InteractionItem :  item.ItemExtra 
{
    public InteractionItem(JsonElement _json)  : base(_json) 
    {
        { if (_json.TryGetProperty("attack_num", out var _j) && _j.ValueKind != JsonValueKind.Null) { AttackNum = _j.GetInt32(); } else { AttackNum = null; } }
        HoldingStaticMesh = _json.GetProperty("holding_static_mesh").GetString();
        HoldingStaticMeshMat = _json.GetProperty("holding_static_mesh_mat").GetString();
        PostInit();
    }

    public InteractionItem(int id, int? attack_num, string holding_static_mesh, string holding_static_mesh_mat )  : base(id) 
    {
        this.AttackNum = attack_num;
        this.HoldingStaticMesh = holding_static_mesh;
        this.HoldingStaticMeshMat = holding_static_mesh_mat;
        PostInit();
    }

    public static InteractionItem DeserializeInteractionItem(JsonElement _json)
    {
        return new item.InteractionItem(_json);
    }

    public int? AttackNum { get; private set; }
    public string HoldingStaticMesh { get; private set; }
    public string HoldingStaticMeshMat { get; private set; }

    public const int __ID__ = 640937802;
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
        + "AttackNum:" + AttackNum + ","
        + "HoldingStaticMesh:" + HoldingStaticMesh + ","
        + "HoldingStaticMeshMat:" + HoldingStaticMeshMat + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
