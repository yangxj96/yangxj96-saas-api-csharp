using System.Text.Json.Serialization;
using SqlSugar;
using yangxj96_serve_example.Configuration.JsonConverter;

namespace yangxj96_serve_example.Common;

public class BaseEntity
{
    /// <summary>
    /// 主键ID
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true)]
    [JsonConverter(typeof(LongJsonConverter))]
    public long Id { get; init; }

    /// <summary>
    /// 创建人
    /// </summary>
    [SugarColumn(ColumnName = "created_user")]
    [JsonIgnore]
    public long CreatedUser { get; set; } = 0;

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "created_time", InsertServerTime = true)]
    [JsonIgnore]
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 最后修改人,默认0
    /// </summary>
    [SugarColumn(ColumnName = "updated_user")]
    [JsonIgnore]
    public long UpdatedUser { get; set; } = 0;

    /// <summary>
    /// 最后修改时间
    /// </summary>
    [SugarColumn(ColumnName = "updated_time", UpdateServerTime = true)]
    [JsonIgnore]
    public DateTime UpdatedTime { get; set; }

    /// <summary>
    /// 是否删除
    /// </summary>
    [SugarColumn(ColumnName = "deleted")]
    [JsonIgnore]
    public DateTime Deleted { get; set; } 
}