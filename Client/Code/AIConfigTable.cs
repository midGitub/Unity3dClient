//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: AIConfigTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AIConfigTable")]
  public partial class AIConfigTable : global::ProtoBuf.IExtensible
  {
    public AIConfigTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _JobID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"JobID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int JobID
    {
      get { return _JobID; }
      set { _JobID = value; }
    }
    private int _AIType;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"AIType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int AIType
    {
      get { return _AIType; }
      set { _AIType = value; }
    }
    private int _AIAttackDelay;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"AIAttackDelay", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int AIAttackDelay
    {
      get { return _AIAttackDelay; }
      set { _AIAttackDelay = value; }
    }
    private int _AIDestinationChangeTerm;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"AIDestinationChangeTerm", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int AIDestinationChangeTerm
    {
      get { return _AIDestinationChangeTerm; }
      set { _AIDestinationChangeTerm = value; }
    }
    private int _AIThinkTargetTerm;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"AIThinkTargetTerm", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int AIThinkTargetTerm
    {
      get { return _AIThinkTargetTerm; }
      set { _AIThinkTargetTerm = value; }
    }
    private string _AIActionPath;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"AIActionPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AIActionPath
    {
      get { return _AIActionPath; }
      set { _AIActionPath = value; }
    }
    private string _AIDestinationSelectPath;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"AIDestinationSelectPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AIDestinationSelectPath
    {
      get { return _AIDestinationSelectPath; }
      set { _AIDestinationSelectPath = value; }
    }
    private string _AIEventPath;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"AIEventPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AIEventPath
    {
      get { return _AIEventPath; }
      set { _AIEventPath = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}