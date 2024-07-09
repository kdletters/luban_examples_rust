
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

public sealed partial class UeWait : ai.Task
{
    public UeWait(JToken _buf)  : base(_buf) 
    {
        JObject _obj = _buf as JObject;
        WaitTime = (float)_obj.GetValue("wait_time");
        RandomDeviation = (float)_obj.GetValue("random_deviation");
    }

    public static UeWait DeserializeUeWait(JToken _buf)
    {
        return new ai.UeWait(_buf);
    }

    public readonly float WaitTime;
    public readonly float RandomDeviation;


    public const int __ID__ = -512994101;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(Decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(Services) + ","
        + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
        + "waitTime:" + WaitTime + ","
        + "randomDeviation:" + RandomDeviation + ","
        + "}";
    }
}
}

