//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FashionComposeTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionComposeTable")]
  public partial class FashionComposeTable : global::ProtoBuf.IExtensible
  {
    public FashionComposeTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _Occu;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Occu", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Occu
    {
      get { return _Occu; }
      set { _Occu = value; }
    }
    private int _Color;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Color
    {
      get { return _Color; }
      set { _Color = value; }
    }
    private int _Part;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Part
    {
      get { return _Part; }
      set { _Part = value; }
    }
    private int _ComposeColor;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ComposeColor", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ComposeColor
    {
      get { return _ComposeColor; }
      set { _ComposeColor = value; }
    }
    private int _Weight;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Weight", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Weight
    {
      get { return _Weight; }
      set { _Weight = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}