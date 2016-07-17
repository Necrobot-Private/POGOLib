// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/DownloadSettingsAction.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from Settings/DownloadSettingsAction.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DownloadSettingsActionReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/DownloadSettingsAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadSettingsActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTZXR0aW5ncy9Eb3dubG9hZFNldHRpbmdzQWN0aW9uLnByb3RvEhNQT0dP",
            "UHJvdG9zLlNldHRpbmdzIiYKFkRvd25sb2FkU2V0dGluZ3NBY3Rpb24SDAoE",
            "aGFzaBgBIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.DownloadSettingsAction), global::POGOProtos.Settings.DownloadSettingsAction.Parser, new[]{ "Hash" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DownloadSettingsAction : pb::IMessage<DownloadSettingsAction> {
    private static readonly pb::MessageParser<DownloadSettingsAction> _parser = new pb::MessageParser<DownloadSettingsAction>(() => new DownloadSettingsAction());
    public static pb::MessageParser<DownloadSettingsAction> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.DownloadSettingsActionReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DownloadSettingsAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DownloadSettingsAction(DownloadSettingsAction other) : this() {
      hash_ = other.hash_;
    }

    public DownloadSettingsAction Clone() {
      return new DownloadSettingsAction(this);
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 1;
    private string hash_ = "";
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DownloadSettingsAction);
    }

    public bool Equals(DownloadSettingsAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hash != other.Hash) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Hash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Hash);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      return size;
    }

    public void MergeFrom(DownloadSettingsAction other) {
      if (other == null) {
        return;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
