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


namespace cfg.test
{
public abstract partial class DemoDynamic :  BeanBase 
{
    public DemoDynamic(JsonElement _json) 
    {
        X1 = _json.GetProperty("x1").GetInt32();
        PostInit();
    }

    public DemoDynamic(int x1 ) 
    {
        this.X1 = x1;
        PostInit();
    }

    public static DemoDynamic DeserializeDemoDynamic(JsonElement _json)
    {
        switch (_json.GetProperty("$type").GetString())
        {
            case "DemoD2": return new test.DemoD2(_json);
            case "DemoE1": return new test.DemoE1(_json);
            case "test.login.RoleInfo": return new test.login.RoleInfo(_json);
            case "DemoD5": return new test.DemoD5(_json);
            default: throw new SerializationException();
        }
    }

    public int X1 { get; private set; }


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
        + "X1:" + X1 + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
