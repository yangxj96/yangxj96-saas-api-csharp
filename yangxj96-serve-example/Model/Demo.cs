using SqlSugar;

namespace yangxj96_serve_example.Model
{
    [SugarTable("Demos")]
    public class Demo
    {
        /// <summary>
        /// id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        ///  名称
        /// </summary>
        [SugarColumn(ColumnName = "Name")]
        public string? Name { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 是否删除了
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}