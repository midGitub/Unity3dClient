//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: StrengthenTicketTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StrengthenTicketTable")]
  public partial class StrengthenTicketTable : global::ProtoBuf.IExtensible
  {
    public StrengthenTicketTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _Probility;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Probility", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Probility
    {
      get { return _Probility; }
      set { _Probility = value; }
    }
    private int _Level;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private string _desc;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}