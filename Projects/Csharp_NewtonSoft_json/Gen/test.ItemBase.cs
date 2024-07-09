
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

public abstract partial class ItemBase : Luban.BeanBase
{
    public ItemBase(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Id = (int)_obj.GetValue("id");
        Name = (string)_obj.GetValue("name");
        Desc = (string)_obj.GetValue("desc");
    }

    public static ItemBase DeserializeItemBase(JToken _buf)
    {
        var _obj=_buf as JObject;
        switch (_obj.GetValue("$type").ToString())
        {
            case "Item": return new test.Item(_buf);
            case "Equipment": return new test.Equipment(_buf);
            case "Decorator": return new test.Decorator(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly int Id;
    public readonly string Name;
    public readonly string Desc;



    public virtual void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "}";
    }
}
}

