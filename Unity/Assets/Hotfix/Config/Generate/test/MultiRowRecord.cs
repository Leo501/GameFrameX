//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.test
{
    public sealed partial class MultiRowRecord :  Bright.Config.BeanBase 
    {
        public MultiRowRecord(JSONNode _json) 
        {
            { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
            { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
            { var __json0 = _json["one_rows"]; if(!__json0.IsArray) { throw new SerializationException(); } OneRows = new System.Collections.Generic.List<test.MultiRowType1>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.MultiRowType1 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.MultiRowType1.DeserializeMultiRowType1(__e0);  }  OneRows.Add(__v0); }   }
            { var __json0 = _json["multi_rows1"]; if(!__json0.IsArray) { throw new SerializationException(); } MultiRows1 = new System.Collections.Generic.List<test.MultiRowType1>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.MultiRowType1 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.MultiRowType1.DeserializeMultiRowType1(__e0);  }  MultiRows1.Add(__v0); }   }
            { var __json0 = _json["multi_rows2"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; MultiRows2 = new test.MultiRowType1[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { test.MultiRowType1 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.MultiRowType1.DeserializeMultiRowType1(__e0);  }  MultiRows2[__index0++] = __v0; }   }
            { var __json0 = _json["multi_rows4"]; if(!__json0.IsArray) { throw new SerializationException(); } MultiRows4 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } test.MultiRowType2 _v0;  { if(!__e0[1].IsObject) { throw new SerializationException(); }  _v0 = test.MultiRowType2.DeserializeMultiRowType2(__e0[1]);  }  MultiRows4.Add(_k0, _v0); }   }
            { var __json0 = _json["multi_rows5"]; if(!__json0.IsArray) { throw new SerializationException(); } MultiRows5 = new System.Collections.Generic.List<test.MultiRowType3>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.MultiRowType3 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.MultiRowType3.DeserializeMultiRowType3(__e0);  }  MultiRows5.Add(__v0); }   }
            { var __json0 = _json["multi_rows6"]; if(!__json0.IsArray) { throw new SerializationException(); } MultiRows6 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } test.MultiRowType2 _v0;  { if(!__e0[1].IsObject) { throw new SerializationException(); }  _v0 = test.MultiRowType2.DeserializeMultiRowType2(__e0[1]);  }  MultiRows6.Add(_k0, _v0); }   }
            { var __json0 = _json["multi_rows7"]; if(!__json0.IsArray) { throw new SerializationException(); } MultiRows7 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  MultiRows7.Add(_k0, _v0); }   }
            PostInit();
        }
    
        public MultiRowRecord(int id, string name, System.Collections.Generic.List<test.MultiRowType1> one_rows, System.Collections.Generic.List<test.MultiRowType1> multi_rows1, test.MultiRowType1[] multi_rows2, System.Collections.Generic.Dictionary<int, test.MultiRowType2> multi_rows4, System.Collections.Generic.List<test.MultiRowType3> multi_rows5, System.Collections.Generic.Dictionary<int, test.MultiRowType2> multi_rows6, System.Collections.Generic.Dictionary<int, int> multi_rows7 ) 
        {
            this.Id = id;
            this.Name = name;
            this.OneRows = one_rows;
            this.MultiRows1 = multi_rows1;
            this.MultiRows2 = multi_rows2;
            this.MultiRows4 = multi_rows4;
            this.MultiRows5 = multi_rows5;
            this.MultiRows6 = multi_rows6;
            this.MultiRows7 = multi_rows7;
            PostInit();
        }
    
        public static MultiRowRecord DeserializeMultiRowRecord(JSONNode _json)
        {
            return new test.MultiRowRecord(_json);
        }
    
        public int Id { get; private set; }
        public string Name { get; private set; }
        public System.Collections.Generic.List<test.MultiRowType1> OneRows { get; private set; }
        public System.Collections.Generic.List<test.MultiRowType1> MultiRows1 { get; private set; }
        public test.MultiRowType1[] MultiRows2 { get; private set; }
        public System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows4 { get; private set; }
        public System.Collections.Generic.List<test.MultiRowType3> MultiRows5 { get; private set; }
        public System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows6 { get; private set; }
        public System.Collections.Generic.Dictionary<int, int> MultiRows7 { get; private set; }
    
        public const int __ID__ = -501249394;
        public override int GetTypeId() => __ID__;
    
        public  void Resolve(Dictionary<string, object> _tables)
        {
            foreach(var _e in OneRows) { _e?.Resolve(_tables); }
            foreach(var _e in MultiRows1) { _e?.Resolve(_tables); }
            foreach(var _e in MultiRows2) { _e?.Resolve(_tables); }
            foreach(var _e in MultiRows4.Values) { _e?.Resolve(_tables); }
            foreach(var _e in MultiRows5) { _e?.Resolve(_tables); }
            foreach(var _e in MultiRows6.Values) { _e?.Resolve(_tables); }
            PostResolve();
        }
    
        public  void TranslateText(System.Func<string, string, string> translator)
        {
            foreach(var _e in OneRows) { _e?.TranslateText(translator); }
            foreach(var _e in MultiRows1) { _e?.TranslateText(translator); }
            foreach(var _e in MultiRows2) { _e?.TranslateText(translator); }
            foreach(var _e in MultiRows4.Values) { _e?.TranslateText(translator); }
            foreach(var _e in MultiRows5) { _e?.TranslateText(translator); }
            foreach(var _e in MultiRows6.Values) { _e?.TranslateText(translator); }
        }
    
        public override string ToString()
        {
            return "{ "
            + "Id:" + Id + ","
            + "Name:" + Name + ","
            + "OneRows:" + Bright.Common.StringUtil.CollectionToString(OneRows) + ","
            + "MultiRows1:" + Bright.Common.StringUtil.CollectionToString(MultiRows1) + ","
            + "MultiRows2:" + Bright.Common.StringUtil.CollectionToString(MultiRows2) + ","
            + "MultiRows4:" + Bright.Common.StringUtil.CollectionToString(MultiRows4) + ","
            + "MultiRows5:" + Bright.Common.StringUtil.CollectionToString(MultiRows5) + ","
            + "MultiRows6:" + Bright.Common.StringUtil.CollectionToString(MultiRows6) + ","
            + "MultiRows7:" + Bright.Common.StringUtil.CollectionToString(MultiRows7) + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}