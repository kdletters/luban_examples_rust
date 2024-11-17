
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.ai
{
public sealed partial class Blackboard : Luban.BeanBase
{
    public Blackboard(JsonElement _buf) 
    {
        Name = _buf.GetProperty("name").GetString();
        Desc = _buf.GetProperty("desc").GetString();
        ParentName = _buf.GetProperty("parent_name").GetString();
        ParentName_Ref = null;
        { var __json0 = _buf.GetProperty("keys"); Keys = new System.Collections.Generic.List<ai.BlackboardKey>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { ai.BlackboardKey __v0;  __v0 = ai.BlackboardKey.DeserializeBlackboardKey(__e0);  Keys.Add(__v0); }   }
    }

    public static Blackboard DeserializeBlackboard(JsonElement _buf)
    {
        return new ai.Blackboard(_buf);
    }

    public readonly string Name;
    public readonly string Desc;
    public readonly string ParentName;
    public ai.Blackboard ParentName_Ref;
    public readonly System.Collections.Generic.List<ai.BlackboardKey> Keys;
   
    public const int __ID__ = 1576193005;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        ParentName_Ref = tables.TbBlackboard.GetOrDefault(ParentName);
        foreach (var _e in Keys) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "parentName:" + ParentName + ","
        + "keys:" + Luban.StringUtil.CollectionToString(Keys) + ","
        + "}";
    }
}

}
