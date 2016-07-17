// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Map.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from Settings/Map.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MapReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Map.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTZXR0aW5ncy9NYXAucHJvdG8SE1BPR09Qcm90b3MuU2V0dGluZ3MihwIK",
            "A01hcBIdChVwb2tlbW9uX3Zpc2libGVfcmFuZ2UYASABKAESHQoVcG9rZV9u",
            "YXZfcmFuZ2VfbWV0ZXJzGAIgASgBEh4KFmVuY291bnRlcl9yYW5nZV9tZXRl",
            "cnMYAyABKAESKwojZ2V0X21hcF9vYmplY3RzX21pbl9yZWZyZXNoX3NlY29u",
            "ZHMYBCABKAISKwojZ2V0X21hcF9vYmplY3RzX21heF9yZWZyZXNoX3NlY29u",
            "ZHMYBSABKAISKwojZ2V0X21hcF9vYmplY3RzX21pbl9kaXN0YW5jZV9tZXRl",
            "cnMYBiABKAISGwoTZ29vZ2xlX21hcHNfYXBpX2tleRgHIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Map), global::POGOProtos.Settings.Map.Parser, new[]{ "PokemonVisibleRange", "PokeNavRangeMeters", "EncounterRangeMeters", "GetMapObjectsMinRefreshSeconds", "GetMapObjectsMaxRefreshSeconds", "GetMapObjectsMinDistanceMeters", "GoogleMapsApiKey" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Map : pb::IMessage<Map> {
    private static readonly pb::MessageParser<Map> _parser = new pb::MessageParser<Map>(() => new Map());
    public static pb::MessageParser<Map> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.MapReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Map() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Map(Map other) : this() {
      pokemonVisibleRange_ = other.pokemonVisibleRange_;
      pokeNavRangeMeters_ = other.pokeNavRangeMeters_;
      encounterRangeMeters_ = other.encounterRangeMeters_;
      getMapObjectsMinRefreshSeconds_ = other.getMapObjectsMinRefreshSeconds_;
      getMapObjectsMaxRefreshSeconds_ = other.getMapObjectsMaxRefreshSeconds_;
      getMapObjectsMinDistanceMeters_ = other.getMapObjectsMinDistanceMeters_;
      googleMapsApiKey_ = other.googleMapsApiKey_;
    }

    public Map Clone() {
      return new Map(this);
    }

    /// <summary>Field number for the "pokemon_visible_range" field.</summary>
    public const int PokemonVisibleRangeFieldNumber = 1;
    private double pokemonVisibleRange_;
    public double PokemonVisibleRange {
      get { return pokemonVisibleRange_; }
      set {
        pokemonVisibleRange_ = value;
      }
    }

    /// <summary>Field number for the "poke_nav_range_meters" field.</summary>
    public const int PokeNavRangeMetersFieldNumber = 2;
    private double pokeNavRangeMeters_;
    public double PokeNavRangeMeters {
      get { return pokeNavRangeMeters_; }
      set {
        pokeNavRangeMeters_ = value;
      }
    }

    /// <summary>Field number for the "encounter_range_meters" field.</summary>
    public const int EncounterRangeMetersFieldNumber = 3;
    private double encounterRangeMeters_;
    public double EncounterRangeMeters {
      get { return encounterRangeMeters_; }
      set {
        encounterRangeMeters_ = value;
      }
    }

    /// <summary>Field number for the "get_map_objects_min_refresh_seconds" field.</summary>
    public const int GetMapObjectsMinRefreshSecondsFieldNumber = 4;
    private float getMapObjectsMinRefreshSeconds_;
    public float GetMapObjectsMinRefreshSeconds {
      get { return getMapObjectsMinRefreshSeconds_; }
      set {
        getMapObjectsMinRefreshSeconds_ = value;
      }
    }

    /// <summary>Field number for the "get_map_objects_max_refresh_seconds" field.</summary>
    public const int GetMapObjectsMaxRefreshSecondsFieldNumber = 5;
    private float getMapObjectsMaxRefreshSeconds_;
    public float GetMapObjectsMaxRefreshSeconds {
      get { return getMapObjectsMaxRefreshSeconds_; }
      set {
        getMapObjectsMaxRefreshSeconds_ = value;
      }
    }

    /// <summary>Field number for the "get_map_objects_min_distance_meters" field.</summary>
    public const int GetMapObjectsMinDistanceMetersFieldNumber = 6;
    private float getMapObjectsMinDistanceMeters_;
    public float GetMapObjectsMinDistanceMeters {
      get { return getMapObjectsMinDistanceMeters_; }
      set {
        getMapObjectsMinDistanceMeters_ = value;
      }
    }

    /// <summary>Field number for the "google_maps_api_key" field.</summary>
    public const int GoogleMapsApiKeyFieldNumber = 7;
    private string googleMapsApiKey_ = "";
    public string GoogleMapsApiKey {
      get { return googleMapsApiKey_; }
      set {
        googleMapsApiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Map);
    }

    public bool Equals(Map other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonVisibleRange != other.PokemonVisibleRange) return false;
      if (PokeNavRangeMeters != other.PokeNavRangeMeters) return false;
      if (EncounterRangeMeters != other.EncounterRangeMeters) return false;
      if (GetMapObjectsMinRefreshSeconds != other.GetMapObjectsMinRefreshSeconds) return false;
      if (GetMapObjectsMaxRefreshSeconds != other.GetMapObjectsMaxRefreshSeconds) return false;
      if (GetMapObjectsMinDistanceMeters != other.GetMapObjectsMinDistanceMeters) return false;
      if (GoogleMapsApiKey != other.GoogleMapsApiKey) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (PokemonVisibleRange != 0D) hash ^= PokemonVisibleRange.GetHashCode();
      if (PokeNavRangeMeters != 0D) hash ^= PokeNavRangeMeters.GetHashCode();
      if (EncounterRangeMeters != 0D) hash ^= EncounterRangeMeters.GetHashCode();
      if (GetMapObjectsMinRefreshSeconds != 0F) hash ^= GetMapObjectsMinRefreshSeconds.GetHashCode();
      if (GetMapObjectsMaxRefreshSeconds != 0F) hash ^= GetMapObjectsMaxRefreshSeconds.GetHashCode();
      if (GetMapObjectsMinDistanceMeters != 0F) hash ^= GetMapObjectsMinDistanceMeters.GetHashCode();
      if (GoogleMapsApiKey.Length != 0) hash ^= GoogleMapsApiKey.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonVisibleRange != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(PokemonVisibleRange);
      }
      if (PokeNavRangeMeters != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(PokeNavRangeMeters);
      }
      if (EncounterRangeMeters != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(EncounterRangeMeters);
      }
      if (GetMapObjectsMinRefreshSeconds != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(GetMapObjectsMinRefreshSeconds);
      }
      if (GetMapObjectsMaxRefreshSeconds != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(GetMapObjectsMaxRefreshSeconds);
      }
      if (GetMapObjectsMinDistanceMeters != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(GetMapObjectsMinDistanceMeters);
      }
      if (GoogleMapsApiKey.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(GoogleMapsApiKey);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PokemonVisibleRange != 0D) {
        size += 1 + 8;
      }
      if (PokeNavRangeMeters != 0D) {
        size += 1 + 8;
      }
      if (EncounterRangeMeters != 0D) {
        size += 1 + 8;
      }
      if (GetMapObjectsMinRefreshSeconds != 0F) {
        size += 1 + 4;
      }
      if (GetMapObjectsMaxRefreshSeconds != 0F) {
        size += 1 + 4;
      }
      if (GetMapObjectsMinDistanceMeters != 0F) {
        size += 1 + 4;
      }
      if (GoogleMapsApiKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GoogleMapsApiKey);
      }
      return size;
    }

    public void MergeFrom(Map other) {
      if (other == null) {
        return;
      }
      if (other.PokemonVisibleRange != 0D) {
        PokemonVisibleRange = other.PokemonVisibleRange;
      }
      if (other.PokeNavRangeMeters != 0D) {
        PokeNavRangeMeters = other.PokeNavRangeMeters;
      }
      if (other.EncounterRangeMeters != 0D) {
        EncounterRangeMeters = other.EncounterRangeMeters;
      }
      if (other.GetMapObjectsMinRefreshSeconds != 0F) {
        GetMapObjectsMinRefreshSeconds = other.GetMapObjectsMinRefreshSeconds;
      }
      if (other.GetMapObjectsMaxRefreshSeconds != 0F) {
        GetMapObjectsMaxRefreshSeconds = other.GetMapObjectsMaxRefreshSeconds;
      }
      if (other.GetMapObjectsMinDistanceMeters != 0F) {
        GetMapObjectsMinDistanceMeters = other.GetMapObjectsMinDistanceMeters;
      }
      if (other.GoogleMapsApiKey.Length != 0) {
        GoogleMapsApiKey = other.GoogleMapsApiKey;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            PokemonVisibleRange = input.ReadDouble();
            break;
          }
          case 17: {
            PokeNavRangeMeters = input.ReadDouble();
            break;
          }
          case 25: {
            EncounterRangeMeters = input.ReadDouble();
            break;
          }
          case 37: {
            GetMapObjectsMinRefreshSeconds = input.ReadFloat();
            break;
          }
          case 45: {
            GetMapObjectsMaxRefreshSeconds = input.ReadFloat();
            break;
          }
          case 53: {
            GetMapObjectsMinDistanceMeters = input.ReadFloat();
            break;
          }
          case 58: {
            GoogleMapsApiKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
