
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

public sealed partial class Path : Luban.BeanBase
{
    public Path(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        Res = (string)_obj.GetValue("res");
    }

    public static Path DeserializePath(JToken _buf)
    {
        return new test.Path(_buf);
    }

    public readonly int Id;
    public readonly string Res;


    public const int __ID__ = -1226450911;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "res:" + Res + ","
        + "}";
    }
}
}

