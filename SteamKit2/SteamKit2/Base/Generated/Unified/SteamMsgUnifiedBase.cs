//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_unified_base.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoResponse")]
  public partial class NoResponse : global::ProtoBuf.IExtensible
  {
    public NoResponse() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EProtoExecutionSite", EnumPassthru=true)]
    public enum EProtoExecutionSite
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProtoExecutionSiteUnknown", Value=0)]
      k_EProtoExecutionSiteUnknown = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EProtoExecutionSiteSteamClient", Value=2)]
      k_EProtoExecutionSiteSteamClient = 2
    }
  
}
#pragma warning restore 1591
