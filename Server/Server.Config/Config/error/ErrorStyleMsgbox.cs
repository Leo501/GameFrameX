//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.error
{
public sealed partial class ErrorStyleMsgbox :  error.ErrorStyle 
{
    public ErrorStyleMsgbox(JsonElement _json)  : base(_json) 
    {
        BtnName = _json.GetProperty("btn_name").GetString();
        Operation = (error.EOperation)_json.GetProperty("operation").GetInt32();
        PostInit();
    }

    public ErrorStyleMsgbox(string btn_name, error.EOperation operation )  : base() 
    {
        this.BtnName = btn_name;
        this.Operation = operation;
        PostInit();
    }

    public static ErrorStyleMsgbox DeserializeErrorStyleMsgbox(JsonElement _json)
    {
        return new error.ErrorStyleMsgbox(_json);
    }

    public string BtnName { get; private set; }
    public error.EOperation Operation { get; private set; }

    public const int __ID__ = -1920482343;
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
        + "BtnName:" + BtnName + ","
        + "Operation:" + Operation + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
