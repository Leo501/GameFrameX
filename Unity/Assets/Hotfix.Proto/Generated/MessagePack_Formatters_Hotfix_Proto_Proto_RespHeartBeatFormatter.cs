// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Hotfix.Proto.Proto
{
    public sealed class RespHeartBeatFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Hotfix.Proto.Proto.RespHeartBeat>
    {
        // Timestamp
        private static global::System.ReadOnlySpan<byte> GetSpan_Timestamp() => new byte[1 + 9] { 169, 84, 105, 109, 101, 115, 116, 97, 109, 112 };

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::Hotfix.Proto.Proto.RespHeartBeat value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNil();
                return;
            }

            writer.WriteMapHeader(1);
            writer.WriteRaw(GetSpan_Timestamp());
            writer.Write(value.Timestamp);
        }

        public global::Hotfix.Proto.Proto.RespHeartBeat Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            var length = reader.ReadMapHeader();
            var ____result = new global::Hotfix.Proto.Proto.RespHeartBeat();

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.Internal.CodeGenHelpers.ReadStringSpan(ref reader);
                switch (stringKey.Length)
                {
                    default:
                    FAIL:
                      reader.Skip();
                      continue;
                    case 9:
                        if (!global::System.MemoryExtensions.SequenceEqual(stringKey, GetSpan_Timestamp().Slice(1))) { goto FAIL; }

                        ____result.Timestamp = reader.ReadInt64();
                        continue;

                }
            }

            reader.Depth--;
            return ____result;
        }
    }

}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
