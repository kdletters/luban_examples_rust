
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

public sealed partial class TestMap : Luban.BeanBase
{
    public TestMap(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        Id_Ref = null;
        { var __json0 = _obj.GetValue("x1"); X1 = new System.Collections.Generic.Dictionary<int, int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { int _k0;  _k0 = (int)__e0[0]; int _v0;  _v0 = (int)__e0[1];  X1.Add(_k0, _v0); }   }
        { var __json0 = _obj.GetValue("x2"); X2 = new System.Collections.Generic.Dictionary<long, int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { long _k0;  _k0 = (long)__e0[0]; int _v0;  _v0 = (int)__e0[1];  X2.Add(_k0, _v0); }   }
        { var __json0 = _obj.GetValue("x3"); X3 = new System.Collections.Generic.Dictionary<string, int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { string _k0;  _k0 = (string)__e0[0]; int _v0;  _v0 = (int)__e0[1];  X3.Add(_k0, _v0); }   }
        { var __json0 = _obj.GetValue("x4"); X4 = new System.Collections.Generic.Dictionary<test.DemoEnum, int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { test.DemoEnum _k0;  _k0 = (test.DemoEnum)(int)__e0[0]; int _v0;  _v0 = (int)__e0[1];  X4.Add(_k0, _v0); }   }
    }

    public static TestMap DeserializeTestMap(JToken _buf)
    {
        return new test.TestMap(_buf);
    }

    public readonly int Id;
    public test.TestIndex Id_Ref;
    public readonly System.Collections.Generic.Dictionary<int, int> X1;
    public readonly System.Collections.Generic.Dictionary<long, int> X2;
    public readonly System.Collections.Generic.Dictionary<string, int> X3;
    public readonly System.Collections.Generic.Dictionary<test.DemoEnum, int> X4;


    public const int __ID__ = -543227410;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        Id_Ref = tables.TbTestIndex.GetOrDefault(Id);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + Luban.StringUtil.CollectionToString(X1) + ","
        + "x2:" + Luban.StringUtil.CollectionToString(X2) + ","
        + "x3:" + Luban.StringUtil.CollectionToString(X3) + ","
        + "x4:" + Luban.StringUtil.CollectionToString(X4) + ","
        + "}";
    }
}
}

