//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WarpStoneMasterTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WarpStoneMasterTable")]
  public partial class WarpStoneMasterTable : global::ProtoBuf.IExtensible
  {
    public WarpStoneMasterTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _TotalLevel;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"TotalLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int TotalLevel
    {
      get { return _TotalLevel; }
      set { _TotalLevel = value; }
    }
    private int _BufferID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BufferID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BufferID
    {
      get { return _BufferID; }
      set { _BufferID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}