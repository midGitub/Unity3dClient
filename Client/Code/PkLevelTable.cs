//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PkLevelTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PkLevelTable")]
  public partial class PkLevelTable : global::ProtoBuf.IExtensible
  {
    public PkLevelTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _PkLevelType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"PkLevelType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int PkLevelType
    {
      get { return _PkLevelType; }
      set { _PkLevelType = value; }
    }
    private int _Level;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private int _MinPkValue;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"MinPkValue", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MinPkValue
    {
      get { return _MinPkValue; }
      set { _MinPkValue = value; }
    }
    private string _Path;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Path
    {
      get { return _Path; }
      set { _Path = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}