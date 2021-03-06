// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: proto/internal_application.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Samples.V1 {

  /// <summary>Holder for reflection information generated from proto/internal_application.proto</summary>
  public static partial class InternalApplicationReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/internal_application.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InternalApplicationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBwcm90by9pbnRlcm5hbF9hcHBsaWNhdGlvbi5wcm90bxILY29tLnNhbXBs",
            "ZXMiMQoYQXBwbGljYXRpb25TdGF0dXNSZXF1ZXN0EhUKDWFwcGxpY2F0aW9u",
            "SWQYASABKAUiXgoZQXBwbGljYXRpb25TdGF0dXNSZXNwb25zZRIQCghzdGF0",
            "dXNJZBgBIAEoBRIZChFhcHBsaWNhdGlvblN0YXR1cxgCIAEoCRIUCgxjdXJy",
            "ZW50Tm90ZXMYAyABKAkygwEKGkludGVybmFsQXBwbGljYXRpb25TZXJ2aWNl",
            "EmUKFEdldEFwcGxpY2F0aW9uU3RhdHVzEiUuY29tLnNhbXBsZXMuQXBwbGlj",
            "YXRpb25TdGF0dXNSZXF1ZXN0GiYuY29tLnNhbXBsZXMuQXBwbGljYXRpb25T",
            "dGF0dXNSZXNwb25zZUIRqgIOQ29tLlNhbXBsZXMuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Samples.V1.ApplicationStatusRequest), global::Com.Samples.V1.ApplicationStatusRequest.Parser, new[]{ "ApplicationId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Samples.V1.ApplicationStatusResponse), global::Com.Samples.V1.ApplicationStatusResponse.Parser, new[]{ "StatusId", "ApplicationStatus", "CurrentNotes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ApplicationStatusRequest : pb::IMessage<ApplicationStatusRequest> {
    private static readonly pb::MessageParser<ApplicationStatusRequest> _parser = new pb::MessageParser<ApplicationStatusRequest>(() => new ApplicationStatusRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicationStatusRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Samples.V1.InternalApplicationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicationStatusRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicationStatusRequest(ApplicationStatusRequest other) : this() {
      applicationId_ = other.applicationId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicationStatusRequest Clone() {
      return new ApplicationStatusRequest(this);
    }

    /// <summary>Field number for the "applicationId" field.</summary>
    public const int ApplicationIdFieldNumber = 1;
    private int applicationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ApplicationId {
      get { return applicationId_; }
      set {
        applicationId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicationStatusRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicationStatusRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ApplicationId != other.ApplicationId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ApplicationId != 0) hash ^= ApplicationId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ApplicationId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ApplicationId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ApplicationId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ApplicationId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicationStatusRequest other) {
      if (other == null) {
        return;
      }
      if (other.ApplicationId != 0) {
        ApplicationId = other.ApplicationId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ApplicationId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ApplicationStatusResponse : pb::IMessage<ApplicationStatusResponse> {
    private static readonly pb::MessageParser<ApplicationStatusResponse> _parser = new pb::MessageParser<ApplicationStatusResponse>(() => new ApplicationStatusResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicationStatusResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Samples.V1.InternalApplicationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicationStatusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicationStatusResponse(ApplicationStatusResponse other) : this() {
      statusId_ = other.statusId_;
      applicationStatus_ = other.applicationStatus_;
      currentNotes_ = other.currentNotes_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicationStatusResponse Clone() {
      return new ApplicationStatusResponse(this);
    }

    /// <summary>Field number for the "statusId" field.</summary>
    public const int StatusIdFieldNumber = 1;
    private int statusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StatusId {
      get { return statusId_; }
      set {
        statusId_ = value;
      }
    }

    /// <summary>Field number for the "applicationStatus" field.</summary>
    public const int ApplicationStatusFieldNumber = 2;
    private string applicationStatus_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApplicationStatus {
      get { return applicationStatus_; }
      set {
        applicationStatus_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "currentNotes" field.</summary>
    public const int CurrentNotesFieldNumber = 3;
    private string currentNotes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrentNotes {
      get { return currentNotes_; }
      set {
        currentNotes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicationStatusResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicationStatusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusId != other.StatusId) return false;
      if (ApplicationStatus != other.ApplicationStatus) return false;
      if (CurrentNotes != other.CurrentNotes) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StatusId != 0) hash ^= StatusId.GetHashCode();
      if (ApplicationStatus.Length != 0) hash ^= ApplicationStatus.GetHashCode();
      if (CurrentNotes.Length != 0) hash ^= CurrentNotes.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StatusId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusId);
      }
      if (ApplicationStatus.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ApplicationStatus);
      }
      if (CurrentNotes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CurrentNotes);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StatusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusId);
      }
      if (ApplicationStatus.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApplicationStatus);
      }
      if (CurrentNotes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrentNotes);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicationStatusResponse other) {
      if (other == null) {
        return;
      }
      if (other.StatusId != 0) {
        StatusId = other.StatusId;
      }
      if (other.ApplicationStatus.Length != 0) {
        ApplicationStatus = other.ApplicationStatus;
      }
      if (other.CurrentNotes.Length != 0) {
        CurrentNotes = other.CurrentNotes;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            StatusId = input.ReadInt32();
            break;
          }
          case 18: {
            ApplicationStatus = input.ReadString();
            break;
          }
          case 26: {
            CurrentNotes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
