
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

public partial struct DemoE2
{
    public DemoE2(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        {if (_obj.TryGetValue("y1", out var _j)) { Y1 = (int)_j; } else { Y1 = null; } }
        Y2 = (bool)_obj.GetValue("y2");
    }

    public static DemoE2 DeserializeDemoE2(JToken _buf)
    {
        return new test.DemoE2(_buf);
    }

    public readonly int? Y1;
    public readonly bool Y2;



    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "y1:" + Y1 + ","
        + "y2:" + Y2 + ","
        + "}";
    }
}
}
