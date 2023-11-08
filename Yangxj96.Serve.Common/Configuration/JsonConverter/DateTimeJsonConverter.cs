using System.Text.Json;
using System.Text.Json.Serialization;

namespace Yangxj96.Serve.Common.Configuration.JsonConverter;

/// <summary>
/// 日期时间格式格式化
/// </summary>
public class DateTimeJsonConverter : JsonConverter<DateTime>
{
    private readonly string _format;

    public DateTimeJsonConverter(string format)
    {
        _format = format;
    }

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            return DateTime.ParseExact(reader.GetString() ?? throw new InvalidOperationException(), _format, null);
        }
        catch (System.Exception e)
        {
            _ = e.ToString();
            return DateTime.MinValue;
        }
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_format));
    }
}