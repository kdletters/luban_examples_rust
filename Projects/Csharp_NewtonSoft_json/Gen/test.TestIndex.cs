
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.test
{

public sealed partial class TestIndex : Luban.BeanBase
{
    public TestIndex(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        { var __json0 = _obj.GetValue("eles"); Eles = new System.Collections.Generic.List<test.DemoType1>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { test.DemoType1 __v0;  __v0 = test.DemoType1.DeserializeDemoType1(__e0);  Eles.Add(__v0); }   }
        foreach(var _v in Eles)
        { 
            Eles_Index.Add(_v.X1, _v);
        }
    }

    public static TestIndex DeserializeTestIndex(JToken _buf)
    {
        return new test.TestIndex(_buf);
    }

    public readonly int Id;
    public readonly System.Collections.Generic.List<test.DemoType1> Eles;
    public readonly System.Collections.Generic.Dictionary<int, test.DemoType1> Eles_Index = new System.Collections.Generic.Dictionary<int, test.DemoType1>();


    public const int __ID__ = 1941154020;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        foreach (var _e in Eles) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "eles:" + Luban.StringUtil.CollectionToString(Eles) + ","
        + "}";
    }
}
}

