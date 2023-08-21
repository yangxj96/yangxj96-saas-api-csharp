using System.Text.Json;
using System.Text.Json.Serialization;

namespace yangxj96_serve_example.Configuration.JsonConverter;

public class LongJsonConverter : JsonConverter<long>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(long) == typeToConvert;
    }

    public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetInt64();
    }

    public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}