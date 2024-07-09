
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

public sealed partial class TestScriptableObject : Luban.BeanBase
{
    public TestScriptableObject(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        Desc = (string)_obj.GetValue("desc");
        Rate = (float)_obj.GetValue("rate");
        Num = (int)_obj.GetValue("num");
        V2 = vec2.Deserializevec2(_obj.GetValue("v2"));
        V3 = vec3.Deserializevec3(_obj.GetValue("v3"));
        V4 = vec4.Deserializevec4(_obj.GetValue("v4"));
    }

    public static TestScriptableObject DeserializeTestScriptableObject(JToken _buf)
    {
        return new test.TestScriptableObject(_buf);
    }

    public readonly int Id;
    public readonly string Desc;
    public readonly float Rate;
    public readonly int Num;
    public readonly vec2 V2;
    public readonly vec3 V3;
    public readonly vec4 V4;


    public const int __ID__ = -1896814350;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "desc:" + Desc + ","
        + "rate:" + Rate + ","
        + "num:" + Num + ","
        + "v2:" + V2 + ","
        + "v3:" + V3 + ","
        + "v4:" + V4 + ","
        + "}";
    }
}
}

