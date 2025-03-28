//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{


public sealed partial class TbTestNull
{
    private readonly Dictionary<int, test.TestNull> _dataMap;
    private readonly List<test.TestNull> _dataList;
    
    public TbTestNull(JsonElement _json)
    {
        _dataMap = new Dictionary<int, test.TestNull>();
        _dataList = new List<test.TestNull>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.TestNull.DeserializeTestNull(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.TestNull> DataMap => _dataMap;
    public List<test.TestNull> DataList => _dataList;

    public test.TestNull GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestNull Get(int key) => _dataMap[key];
    public test.TestNull this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    

    partial void PostInit();
    partial void PostResolve();
}

}