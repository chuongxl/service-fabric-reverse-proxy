// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: v2/rls.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Ratelimit.V2 {

  /// <summary>Holder for reflection information generated from v2/rls.proto</summary>
  public static partial class RlsReflection {

    #region Descriptor
    /// <summary>File descriptor for v2/rls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgx2Mi9ybHMucHJvdG8SGWVudm95LmNvbmZpZy5yYXRlbGltaXQudjIaJGVu",
            "dm95L2FwaS92Mi9jb3JlL2dycGNfc2VydmljZS5wcm90bxoXdmFsaWRhdGUv",
            "dmFsaWRhdGUucHJvdG8ikQEKFlJhdGVMaW1pdFNlcnZpY2VDb25maWcSIwoM",
            "Y2x1c3Rlcl9uYW1lGAEgASgJQgsYAbrpwAMEcgIgAUgAEjYKDGdycGNfc2Vy",
            "dmljZRgCIAEoCzIeLmVudm95LmFwaS52Mi5jb3JlLkdycGNTZXJ2aWNlSABC",
            "GgoRc2VydmljZV9zcGVjaWZpZXISBbjpwAMBQgRaAnYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.GrpcServiceReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig), global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig.Parser, new[]{ "ClusterName", "GrpcService" }, new[]{ "ServiceSpecifier" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Rate limit :ref:`configuration overview &lt;config_rate_limit_service>`.
  /// </summary>
  public sealed partial class RateLimitServiceConfig : pb::IMessage<RateLimitServiceConfig> {
    private static readonly pb::MessageParser<RateLimitServiceConfig> _parser = new pb::MessageParser<RateLimitServiceConfig>(() => new RateLimitServiceConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RateLimitServiceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Ratelimit.V2.RlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitServiceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitServiceConfig(RateLimitServiceConfig other) : this() {
      switch (other.ServiceSpecifierCase) {
        case ServiceSpecifierOneofCase.ClusterName:
          ClusterName = other.ClusterName;
          break;
        case ServiceSpecifierOneofCase.GrpcService:
          GrpcService = other.GrpcService.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitServiceConfig Clone() {
      return new RateLimitServiceConfig(this);
    }

    /// <summary>Field number for the "cluster_name" field.</summary>
    public const int ClusterNameFieldNumber = 1;
    /// <summary>
    /// Specifies the cluster manager cluster name that hosts the rate limit
    /// service. The client will connect to this cluster when it needs to make
    /// rate limit service requests. This field is deprecated and `grpc_service`
    /// should be used instead. The :ref:`Envoy gRPC client
    /// &lt;envoy_api_field_core.GrpcService.envoy_grpc>` will be used when this field is
    /// specified.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterName {
      get { return serviceSpecifierCase_ == ServiceSpecifierOneofCase.ClusterName ? (string) serviceSpecifier_ : ""; }
      set {
        serviceSpecifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        serviceSpecifierCase_ = ServiceSpecifierOneofCase.ClusterName;
      }
    }

    /// <summary>Field number for the "grpc_service" field.</summary>
    public const int GrpcServiceFieldNumber = 2;
    /// <summary>
    /// Specifies the gRPC service that hosts the rate limit service. The client
    /// will connect to this cluster when it needs to make rate limit service
    /// requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V2.Core.GrpcService GrpcService {
      get { return serviceSpecifierCase_ == ServiceSpecifierOneofCase.GrpcService ? (global::Envoy.Api.V2.Core.GrpcService) serviceSpecifier_ : null; }
      set {
        serviceSpecifier_ = value;
        serviceSpecifierCase_ = value == null ? ServiceSpecifierOneofCase.None : ServiceSpecifierOneofCase.GrpcService;
      }
    }

    private object serviceSpecifier_;
    /// <summary>Enum of possible cases for the "service_specifier" oneof.</summary>
    public enum ServiceSpecifierOneofCase {
      None = 0,
      ClusterName = 1,
      GrpcService = 2,
    }
    private ServiceSpecifierOneofCase serviceSpecifierCase_ = ServiceSpecifierOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceSpecifierOneofCase ServiceSpecifierCase {
      get { return serviceSpecifierCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearServiceSpecifier() {
      serviceSpecifierCase_ = ServiceSpecifierOneofCase.None;
      serviceSpecifier_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RateLimitServiceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RateLimitServiceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClusterName != other.ClusterName) return false;
      if (!object.Equals(GrpcService, other.GrpcService)) return false;
      if (ServiceSpecifierCase != other.ServiceSpecifierCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.ClusterName) hash ^= ClusterName.GetHashCode();
      if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.GrpcService) hash ^= GrpcService.GetHashCode();
      hash ^= (int) serviceSpecifierCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.ClusterName) {
        output.WriteRawTag(10);
        output.WriteString(ClusterName);
      }
      if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.GrpcService) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcService);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.ClusterName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterName);
      }
      if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.GrpcService) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcService);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RateLimitServiceConfig other) {
      if (other == null) {
        return;
      }
      switch (other.ServiceSpecifierCase) {
        case ServiceSpecifierOneofCase.ClusterName:
          ClusterName = other.ClusterName;
          break;
        case ServiceSpecifierOneofCase.GrpcService:
          if (GrpcService == null) {
            GrpcService = new global::Envoy.Api.V2.Core.GrpcService();
          }
          GrpcService.MergeFrom(other.GrpcService);
          break;
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
          case 10: {
            ClusterName = input.ReadString();
            break;
          }
          case 18: {
            global::Envoy.Api.V2.Core.GrpcService subBuilder = new global::Envoy.Api.V2.Core.GrpcService();
            if (serviceSpecifierCase_ == ServiceSpecifierOneofCase.GrpcService) {
              subBuilder.MergeFrom(GrpcService);
            }
            input.ReadMessage(subBuilder);
            GrpcService = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code