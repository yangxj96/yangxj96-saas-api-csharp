using System.Text.Json;

namespace yangxj96_serve_demo.Configuration.JsonConverter
{
    /// <summary>
    /// 日期时间格式格式化
    /// </summary>
    public class DateTimeJsonConverter : System.Text.Json.Serialization.JsonConverter<DateTime>
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
                return DateTime.ParseExact(reader.GetString(), _format, null);
            }
            catch (Exception e)
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
}
