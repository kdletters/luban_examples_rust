
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.ai
{

public sealed partial class IsNotSet : ai.KeyQueryOperator
{
    public IsNotSet(JToken _buf)  : base(_buf) 
    {
        JObject _obj = _buf as JObject;
    }

    public static IsNotSet DeserializeIsNotSet(JToken _buf)
    {
        return new ai.IsNotSet(_buf);
    }



    public const int __ID__ = 790736255;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
}
}

