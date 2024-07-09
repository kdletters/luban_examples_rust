
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.common
{

public sealed partial class OneDayTimeRange : Luban.BeanBase
{
    public OneDayTimeRange(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        StartTime = common.TimeOfDay.DeserializeTimeOfDay(_obj.GetValue("start_time"));
        EndTime = common.TimeOfDay.DeserializeTimeOfDay(_obj.GetValue("end_time"));
    }

    public static OneDayTimeRange DeserializeOneDayTimeRange(JToken _buf)
    {
        return new common.OneDayTimeRange(_buf);
    }

    public readonly common.TimeOfDay StartTime;
    public readonly common.TimeOfDay EndTime;


    public const int __ID__ = 1628814743;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        StartTime?.ResolveRef(tables);
        EndTime?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "startTime:" + StartTime + ","
        + "endTime:" + EndTime + ","
        + "}";
    }
}
}

