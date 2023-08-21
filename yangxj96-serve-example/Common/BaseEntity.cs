using System.Text.Json.Serialization;
using SqlSugar;

namespace yangxj96_serve_example.Common;

public class BaseEntity
{
    /// <summary>
    /// 主键ID
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true)]
    public long? Id { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    [SugarColumn(ColumnName = "created_by")]
    [JsonIgnore]
    public long CreatedBy { get; set; } = 0;

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "created_time",InsertServerTime = true)]
    [JsonIgnore]
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 最后修改人,默认0
    /// </summary>
    [SugarColumn(ColumnName = "updated_by")]
    [JsonIgnore]
    public long UpdatedBy { get; set; } = 0;

    /// <summary>
    /// 最后修改时间
    /// </summary>
    [SugarColumn(ColumnName = "updated_time",UpdateServerTime = true)]
    [JsonIgnore]
    public DateTime UpdatedTime { get; set; }

    /// <summary>
    /// 是否删除
    /// </summary>
    [SugarColumn(ColumnName = "deleted")]
    [JsonIgnore]
    public bool Deleted { get; set; } = false;
}