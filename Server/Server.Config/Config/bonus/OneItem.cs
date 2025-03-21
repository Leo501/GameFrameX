//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.bonus
{
public sealed partial class OneItem :  bonus.Bonus 
{
    public OneItem(JsonElement _json)  : base(_json) 
    {
        ItemId = _json.GetProperty("item_id").GetInt32();
        PostInit();
    }

    public OneItem(int item_id )  : base() 
    {
        this.ItemId = item_id;
        PostInit();
    }

    public static OneItem DeserializeOneItem(JsonElement _json)
    {
        return new bonus.OneItem(_json);
    }

    public int ItemId { get; private set; }
    public item.Item ItemId_Ref { get; private set; }

    public const int __ID__ = -1649658966;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
