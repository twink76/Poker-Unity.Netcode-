// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: clientsHandler.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LobbyService.Grpc {

  /// <summary>Holder for reflection information generated from clientsHandler.proto</summary>
  public static partial class ClientsHandlerReflection {

    #region Descriptor
    /// <summary>File descriptor for clientsHandler.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientsHandlerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRjbGllbnRzSGFuZGxlci5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5",
            "LnByb3RvIiEKEEdldEd1aWRzUmVzcG9uc2USDQoFZ3VpZHMYASADKAkiIwoT",
            "R2V0TG9iYnlJbmZvUmVxdWVzdBIMCgRndWlkGAEgASgJIn0KFEdldExvYmJ5",
            "SW5mb1Jlc3BvbnNlEhkKEXB1YmxpY19pcF9hZGRyZXNzGAEgASgJEgwKBHBv",
            "cnQYAiABKAUSEQoJbWF4X3NlYXRzGAMgASgFEhUKDXBsYXllcnNfY291bnQY",
            "BCABKAUSEgoKbG9iYnlfbmFtZRgFIAEoCTKEAQoOQ2xpZW50c0hhbmRsZXIS",
            "NQoIR2V0R3VpZHMSFi5nb29nbGUucHJvdG9idWYuRW1wdHkaES5HZXRHdWlk",
            "c1Jlc3BvbnNlEjsKDEdldExvYmJ5SW5mbxIULkdldExvYmJ5SW5mb1JlcXVl",
            "c3QaFS5HZXRMb2JieUluZm9SZXNwb25zZUIUqgIRTG9iYnlTZXJ2aWNlLkdy",
            "cGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LobbyService.Grpc.GetGuidsResponse), global::LobbyService.Grpc.GetGuidsResponse.Parser, new[]{ "Guids" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LobbyService.Grpc.GetLobbyInfoRequest), global::LobbyService.Grpc.GetLobbyInfoRequest.Parser, new[]{ "Guid" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LobbyService.Grpc.GetLobbyInfoResponse), global::LobbyService.Grpc.GetLobbyInfoResponse.Parser, new[]{ "PublicIpAddress", "Port", "MaxSeats", "PlayersCount", "LobbyName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetGuidsResponse : pb::IMessage<GetGuidsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetGuidsResponse> _parser = new pb::MessageParser<GetGuidsResponse>(() => new GetGuidsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetGuidsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LobbyService.Grpc.ClientsHandlerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGuidsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGuidsResponse(GetGuidsResponse other) : this() {
      guids_ = other.guids_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGuidsResponse Clone() {
      return new GetGuidsResponse(this);
    }

    /// <summary>Field number for the "guids" field.</summary>
    public const int GuidsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_guids_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> guids_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Guids {
      get { return guids_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetGuidsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetGuidsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!guids_.Equals(other.guids_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= guids_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      guids_.WriteTo(output, _repeated_guids_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      guids_.WriteTo(ref output, _repeated_guids_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += guids_.CalculateSize(_repeated_guids_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetGuidsResponse other) {
      if (other == null) {
        return;
      }
      guids_.Add(other.guids_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            guids_.AddEntriesFrom(input, _repeated_guids_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            guids_.AddEntriesFrom(ref input, _repeated_guids_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetLobbyInfoRequest : pb::IMessage<GetLobbyInfoRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetLobbyInfoRequest> _parser = new pb::MessageParser<GetLobbyInfoRequest>(() => new GetLobbyInfoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetLobbyInfoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LobbyService.Grpc.ClientsHandlerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLobbyInfoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLobbyInfoRequest(GetLobbyInfoRequest other) : this() {
      guid_ = other.guid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLobbyInfoRequest Clone() {
      return new GetLobbyInfoRequest(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
    private string guid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Guid {
      get { return guid_; }
      set {
        guid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetLobbyInfoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetLobbyInfoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Guid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Guid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Guid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Guid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Guid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Guid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetLobbyInfoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Guid = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Guid = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetLobbyInfoResponse : pb::IMessage<GetLobbyInfoResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetLobbyInfoResponse> _parser = new pb::MessageParser<GetLobbyInfoResponse>(() => new GetLobbyInfoResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetLobbyInfoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LobbyService.Grpc.ClientsHandlerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLobbyInfoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLobbyInfoResponse(GetLobbyInfoResponse other) : this() {
      publicIpAddress_ = other.publicIpAddress_;
      port_ = other.port_;
      maxSeats_ = other.maxSeats_;
      playersCount_ = other.playersCount_;
      lobbyName_ = other.lobbyName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLobbyInfoResponse Clone() {
      return new GetLobbyInfoResponse(this);
    }

    /// <summary>Field number for the "public_ip_address" field.</summary>
    public const int PublicIpAddressFieldNumber = 1;
    private string publicIpAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PublicIpAddress {
      get { return publicIpAddress_; }
      set {
        publicIpAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 2;
    private int port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "max_seats" field.</summary>
    public const int MaxSeatsFieldNumber = 3;
    private int maxSeats_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxSeats {
      get { return maxSeats_; }
      set {
        maxSeats_ = value;
      }
    }

    /// <summary>Field number for the "players_count" field.</summary>
    public const int PlayersCountFieldNumber = 4;
    private int playersCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PlayersCount {
      get { return playersCount_; }
      set {
        playersCount_ = value;
      }
    }

    /// <summary>Field number for the "lobby_name" field.</summary>
    public const int LobbyNameFieldNumber = 5;
    private string lobbyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LobbyName {
      get { return lobbyName_; }
      set {
        lobbyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetLobbyInfoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetLobbyInfoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PublicIpAddress != other.PublicIpAddress) return false;
      if (Port != other.Port) return false;
      if (MaxSeats != other.MaxSeats) return false;
      if (PlayersCount != other.PlayersCount) return false;
      if (LobbyName != other.LobbyName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PublicIpAddress.Length != 0) hash ^= PublicIpAddress.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      if (MaxSeats != 0) hash ^= MaxSeats.GetHashCode();
      if (PlayersCount != 0) hash ^= PlayersCount.GetHashCode();
      if (LobbyName.Length != 0) hash ^= LobbyName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (PublicIpAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PublicIpAddress);
      }
      if (Port != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Port);
      }
      if (MaxSeats != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxSeats);
      }
      if (PlayersCount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PlayersCount);
      }
      if (LobbyName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(LobbyName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PublicIpAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PublicIpAddress);
      }
      if (Port != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Port);
      }
      if (MaxSeats != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxSeats);
      }
      if (PlayersCount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PlayersCount);
      }
      if (LobbyName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(LobbyName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PublicIpAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicIpAddress);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      if (MaxSeats != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxSeats);
      }
      if (PlayersCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayersCount);
      }
      if (LobbyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LobbyName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetLobbyInfoResponse other) {
      if (other == null) {
        return;
      }
      if (other.PublicIpAddress.Length != 0) {
        PublicIpAddress = other.PublicIpAddress;
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      if (other.MaxSeats != 0) {
        MaxSeats = other.MaxSeats;
      }
      if (other.PlayersCount != 0) {
        PlayersCount = other.PlayersCount;
      }
      if (other.LobbyName.Length != 0) {
        LobbyName = other.LobbyName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PublicIpAddress = input.ReadString();
            break;
          }
          case 16: {
            Port = input.ReadInt32();
            break;
          }
          case 24: {
            MaxSeats = input.ReadInt32();
            break;
          }
          case 32: {
            PlayersCount = input.ReadInt32();
            break;
          }
          case 42: {
            LobbyName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            PublicIpAddress = input.ReadString();
            break;
          }
          case 16: {
            Port = input.ReadInt32();
            break;
          }
          case 24: {
            MaxSeats = input.ReadInt32();
            break;
          }
          case 32: {
            PlayersCount = input.ReadInt32();
            break;
          }
          case 42: {
            LobbyName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
