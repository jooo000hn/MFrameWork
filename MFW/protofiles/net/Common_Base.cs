//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: proto/Common_Base.proto
namespace PCommon_Base
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetHead")]
  public partial class NetHead : global::ProtoBuf.IExtensible
  {
    public NetHead() {}
    
    private int _Cmd = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Cmd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Cmd
    {
      get { return _Cmd; }
      set { _Cmd = value; }
    }
    private int _Index = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private int _Count = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Count
    {
      get { return _Count; }
      set { _Count = value; }
    }
    private int _DataLength = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DataLength", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int DataLength
    {
      get { return _DataLength; }
      set { _DataLength = value; }
    }
    private int _key = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int key
    {
      get { return _key; }
      set { _key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetTransferMsg")]
  public partial class NetTransferMsg : global::ProtoBuf.IExtensible
  {
    public NetTransferMsg() {}
    
    private ulong _id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _cmd = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cmd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cmd
    {
      get { return _cmd; }
      set { _cmd = value; }
    }
    private string _data = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetTransferMsgs")]
  public partial class NetTransferMsgs : global::ProtoBuf.IExtensible
  {
    public NetTransferMsgs() {}
    
    private readonly global::System.Collections.Generic.List<PCommon_Base.NetTransferMsg> _NetTransferMsgs = new global::System.Collections.Generic.List<PCommon_Base.NetTransferMsg>();
    [global::ProtoBuf.ProtoMember(1, Name=@"NetTransferMsgs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PCommon_Base.NetTransferMsg> NetTransferMsgs
    {
      get { return _NetTransferMsgs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerInfo")]
  public partial class PlayerInfo : global::ProtoBuf.IExtensible
  {
    public PlayerInfo() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MTest1")]
  public partial class MTest1 : global::ProtoBuf.IExtensible
  {
    public MTest1() {}
    
    private int _a = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"a", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int a
    {
      get { return _a; }
      set { _a = value; }
    }
    private int _b = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"b", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int b
    {
      get { return _b; }
      set { _b = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MTest2")]
  public partial class MTest2 : global::ProtoBuf.IExtensible
  {
    public MTest2() {}
    
    private int _a = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"a", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int a
    {
      get { return _a; }
      set { _a = value; }
    }
    private int _b = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"b", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int b
    {
      get { return _b; }
      set { _b = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EPublic_CMD")]
    public enum EPublic_CMD
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EPublic_CMD_None", Value=0)]
      EPublic_CMD_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EPublic_CMD_PackTransferMsg", Value=1)]
      EPublic_CMD_PackTransferMsg = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ETest")]
    public enum ETest
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Test1", Value=0)]
      Test1 = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Test2", Value=1)]
      Test2 = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Test3", Value=2)]
      Test3 = 2
    }
  
}