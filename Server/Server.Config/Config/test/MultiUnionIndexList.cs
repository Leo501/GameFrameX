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
public sealed partial class MultiUnionIndexList :  BeanBase 
{
    public MultiUnionIndexList(JsonElement _json) 
    {
        Id1 = _json.GetProperty("id1").GetInt32();
        Id2 = _json.GetProperty("id2").GetInt64();
        Id3 = _json.GetProperty("id3").GetString();
        Num = _json.GetProperty("num").GetInt32();
        Desc = _json.GetProperty("desc").GetString();
        PostInit();
    }

    public MultiUnionIndexList(int id1, long id2, string id3, int num, string desc ) 
    {
        this.Id1 = id1;
        this.Id2 = id2;
        this.Id3 = id3;
        this.Num = num;
        this.Desc = desc;
        PostInit();
    }

    public static MultiUnionIndexList DeserializeMultiUnionIndexList(JsonElement _json)
    {
        return new test.MultiUnionIndexList(_json);
    }

    public int Id1 { get; private set; }
    public long Id2 { get; private set; }
    public string Id3 { get; private set; }
    public int Num { get; private set; }
    public string Desc { get; private set; }

    public const int __ID__ = 1966847134;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id1:" + Id1 + ","
        + "Id2:" + Id2 + ","
        + "Id3:" + Id3 + ","
        + "Num:" + Num + ","
        + "Desc:" + Desc + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
