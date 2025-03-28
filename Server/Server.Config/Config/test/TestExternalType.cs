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
public sealed partial class TestExternalType :  BeanBase 
{
    public TestExternalType(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        AudioType = (test.AudioType)_json.GetProperty("audio_type").GetInt32();
        Color = test.Color.DeserializeColor(_json.GetProperty("color"));
        { var __json0 = _json.GetProperty("audio_types"); AudioTypes = new System.Collections.Generic.List<test.AudioType>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.AudioType __v0;  __v0 = (test.AudioType)__e0.GetInt32();  AudioTypes.Add(__v0); }   }
        { var __json0 = _json.GetProperty("colors"); Colors = new System.Collections.Generic.List<test.Color>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.Color __v0;  __v0 = test.Color.DeserializeColor(__e0);  Colors.Add(__v0); }   }
        PostInit();
    }

    public TestExternalType(int id, test.AudioType audio_type, test.Color color, System.Collections.Generic.List<test.AudioType> audio_types, System.Collections.Generic.List<test.Color> colors ) 
    {
        this.Id = id;
        this.AudioType = audio_type;
        this.Color = color;
        this.AudioTypes = audio_types;
        this.Colors = colors;
        PostInit();
    }

    public static TestExternalType DeserializeTestExternalType(JsonElement _json)
    {
        return new test.TestExternalType(_json);
    }

    public int Id { get; private set; }
    public test.AudioType AudioType { get; private set; }
    public test.Color Color { get; private set; }
    public System.Collections.Generic.List<test.AudioType> AudioTypes { get; private set; }
    public System.Collections.Generic.List<test.Color> Colors { get; private set; }

    public const int __ID__ = -990826157;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Color?.Resolve(_tables);
        foreach(var _e in Colors) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Color?.TranslateText(translator);
        foreach(var _e in Colors) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "AudioType:" + AudioType + ","
        + "Color:" + Color + ","
        + "AudioTypes:" + StringUtil.CollectionToString(AudioTypes) + ","
        + "Colors:" + StringUtil.CollectionToString(Colors) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
