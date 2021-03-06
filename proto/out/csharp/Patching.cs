// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: patching.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Obsessiveorange.Opxform {

  /// <summary>Holder for reflection information generated from patching.proto</summary>
  public static partial class PatchingReflection {

    #region Descriptor
    /// <summary>File descriptor for patching.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PatchingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5wYXRjaGluZy5wcm90bxIbY29tLm9ic2Vzc2l2ZW9yYW5nZS5vcHhmb3Jt",
            "ImUKBVBhdGNoEhMKC2Jhc2VWZXJzaW9uGAEgASgDEhUKDWJhc2VEb2NMZW5n",
            "dGgYAiABKAMSMAoFZGlmZnMYAyADKAsyIS5jb20ub2JzZXNzaXZlb3Jhbmdl",
            "Lm9weGZvcm0uRGlmZiJPCgREaWZmEg0KBWluZGV4GAEgASgDEhMKC2lzSW5z",
            "ZXJ0aW9uGAIgASgIEg0KBWNvdW50GAMgASgDEhQKDG1vZGlmaWNhdGlvbhgE",
            "IAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Obsessiveorange.Opxform.Patch), global::Com.Obsessiveorange.Opxform.Patch.Parser, new[]{ "BaseVersion", "BaseDocLength", "Diffs" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Obsessiveorange.Opxform.Diff), global::Com.Obsessiveorange.Opxform.Diff.Parser, new[]{ "Index", "IsInsertion", "Count", "Modification" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Patch : pb::IMessage<Patch> {
    private static readonly pb::MessageParser<Patch> _parser = new pb::MessageParser<Patch>(() => new Patch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Patch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Obsessiveorange.Opxform.PatchingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Patch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Patch(Patch other) : this() {
      baseVersion_ = other.baseVersion_;
      baseDocLength_ = other.baseDocLength_;
      diffs_ = other.diffs_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Patch Clone() {
      return new Patch(this);
    }

    /// <summary>Field number for the "baseVersion" field.</summary>
    public const int BaseVersionFieldNumber = 1;
    private long baseVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BaseVersion {
      get { return baseVersion_; }
      set {
        baseVersion_ = value;
      }
    }

    /// <summary>Field number for the "baseDocLength" field.</summary>
    public const int BaseDocLengthFieldNumber = 2;
    private long baseDocLength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BaseDocLength {
      get { return baseDocLength_; }
      set {
        baseDocLength_ = value;
      }
    }

    /// <summary>Field number for the "diffs" field.</summary>
    public const int DiffsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Com.Obsessiveorange.Opxform.Diff> _repeated_diffs_codec
        = pb::FieldCodec.ForMessage(26, global::Com.Obsessiveorange.Opxform.Diff.Parser);
    private readonly pbc::RepeatedField<global::Com.Obsessiveorange.Opxform.Diff> diffs_ = new pbc::RepeatedField<global::Com.Obsessiveorange.Opxform.Diff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.Obsessiveorange.Opxform.Diff> Diffs {
      get { return diffs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Patch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Patch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BaseVersion != other.BaseVersion) return false;
      if (BaseDocLength != other.BaseDocLength) return false;
      if(!diffs_.Equals(other.diffs_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BaseVersion != 0L) hash ^= BaseVersion.GetHashCode();
      if (BaseDocLength != 0L) hash ^= BaseDocLength.GetHashCode();
      hash ^= diffs_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BaseVersion != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BaseVersion);
      }
      if (BaseDocLength != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BaseDocLength);
      }
      diffs_.WriteTo(output, _repeated_diffs_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BaseVersion != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BaseVersion);
      }
      if (BaseDocLength != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BaseDocLength);
      }
      size += diffs_.CalculateSize(_repeated_diffs_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Patch other) {
      if (other == null) {
        return;
      }
      if (other.BaseVersion != 0L) {
        BaseVersion = other.BaseVersion;
      }
      if (other.BaseDocLength != 0L) {
        BaseDocLength = other.BaseDocLength;
      }
      diffs_.Add(other.diffs_);
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
            BaseVersion = input.ReadInt64();
            break;
          }
          case 16: {
            BaseDocLength = input.ReadInt64();
            break;
          }
          case 26: {
            diffs_.AddEntriesFrom(input, _repeated_diffs_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Diff : pb::IMessage<Diff> {
    private static readonly pb::MessageParser<Diff> _parser = new pb::MessageParser<Diff>(() => new Diff());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Diff> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Obsessiveorange.Opxform.PatchingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Diff() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Diff(Diff other) : this() {
      index_ = other.index_;
      isInsertion_ = other.isInsertion_;
      count_ = other.count_;
      modification_ = other.modification_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Diff Clone() {
      return new Diff(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private long index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "isInsertion" field.</summary>
    public const int IsInsertionFieldNumber = 2;
    private bool isInsertion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsInsertion {
      get { return isInsertion_; }
      set {
        isInsertion_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 3;
    private long count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "modification" field.</summary>
    public const int ModificationFieldNumber = 4;
    private string modification_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Modification {
      get { return modification_; }
      set {
        modification_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Diff);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Diff other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (IsInsertion != other.IsInsertion) return false;
      if (Count != other.Count) return false;
      if (Modification != other.Modification) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0L) hash ^= Index.GetHashCode();
      if (IsInsertion != false) hash ^= IsInsertion.GetHashCode();
      if (Count != 0L) hash ^= Count.GetHashCode();
      if (Modification.Length != 0) hash ^= Modification.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Index != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Index);
      }
      if (IsInsertion != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsInsertion);
      }
      if (Count != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Count);
      }
      if (Modification.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Modification);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Index);
      }
      if (IsInsertion != false) {
        size += 1 + 1;
      }
      if (Count != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Count);
      }
      if (Modification.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Modification);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Diff other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0L) {
        Index = other.Index;
      }
      if (other.IsInsertion != false) {
        IsInsertion = other.IsInsertion;
      }
      if (other.Count != 0L) {
        Count = other.Count;
      }
      if (other.Modification.Length != 0) {
        Modification = other.Modification;
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
            Index = input.ReadInt64();
            break;
          }
          case 16: {
            IsInsertion = input.ReadBool();
            break;
          }
          case 24: {
            Count = input.ReadInt64();
            break;
          }
          case 34: {
            Modification = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
