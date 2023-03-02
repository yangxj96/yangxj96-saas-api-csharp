namespace yangxj96_serve_example.Model
{
    public class Demo
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
