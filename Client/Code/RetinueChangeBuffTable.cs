//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RetinueChangeBuffTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RetinueChangeBuffTable")]
  public partial class RetinueChangeBuffTable : global::ProtoBuf.IExtensible
  {
    public RetinueChangeBuffTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _GroupID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"GroupID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int GroupID
    {
      get { return _GroupID; }
      set { _GroupID = value; }
    }
    private ProtoTable.RetinueChangeBuffTable.eShowType _ShowType;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ShowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.RetinueChangeBuffTable.eShowType ShowType
    {
      get { return _ShowType; }
      set { _ShowType = value; }
    }
    private int _DataType;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DataType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int DataType
    {
      get { return _DataType; }
      set { _DataType = value; }
    }
    private int _DataID;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"DataID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int DataID
    {
      get { return _DataID; }
      set { _DataID = value; }
    }
    private int _StarLevel;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"StarLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int StarLevel
    {
      get { return _StarLevel; }
      set { _StarLevel = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _Occu = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(7, Name=@"Occu", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> Occu
    {
      get { return _Occu; }
    }
  
    private int _LockSkillCount;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"LockSkillCount", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int LockSkillCount
    {
      get { return _LockSkillCount; }
      set { _LockSkillCount = value; }
    }
    private int _DataNum;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"DataNum", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int DataNum
    {
      get { return _DataNum; }
      set { _DataNum = value; }
    }
    private int _Weight;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Weight", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Weight
    {
      get { return _Weight; }
      set { _Weight = value; }
    }
    private int _Fix1;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Fix1", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Fix1
    {
      get { return _Fix1; }
      set { _Fix1 = value; }
    }
    private int _Fix2;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Fix2", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Fix2
    {
      get { return _Fix2; }
      set { _Fix2 = value; }
    }
    private int _Fix2Num;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Fix2Num", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Fix2Num
    {
      get { return _Fix2Num; }
      set { _Fix2Num = value; }
    }
    private int _FixMax;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"FixMax", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int FixMax
    {
      get { return _FixMax; }
      set { _FixMax = value; }
    }
    private int _FixMin;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"FixMin", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int FixMin
    {
      get { return _FixMin; }
      set { _FixMin = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"eShowType")]
    public enum eShowType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_HIDE", Value=0)]
      ST_HIDE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_SPECIALSKILL", Value=3)]
      ST_SPECIALSKILL = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_MAINSKILL", Value=2)]
      ST_MAINSKILL = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_HELPSKILLS", Value=1)]
      ST_HELPSKILLS = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}