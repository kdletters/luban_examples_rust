
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

public sealed partial class H2 : Luban.BeanBase
{
    public H2(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Z2 = (int)_obj.GetValue("z2");
        Z3 = (int)_obj.GetValue("z3");
    }

    public static H2 DeserializeH2(JToken _buf)
    {
        return new test.H2(_buf);
    }

    public readonly int Z2;
    public readonly int Z3;


    public const int __ID__ = -1422503994;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "z2:" + Z2 + ","
        + "z3:" + Z3 + ","
        + "}";
    }
}
}

