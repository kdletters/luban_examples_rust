
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.tag
{

public sealed partial class TestTag : Luban.BeanBase
{
    public TestTag(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        Value = (string)_obj.GetValue("value");
    }

    public static TestTag DeserializeTestTag(JToken _buf)
    {
        return new tag.TestTag(_buf);
    }

    public readonly int Id;
    public readonly string Value;


    public const int __ID__ = 1742933812;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "value:" + Value + ","
        + "}";
    }
}
}

