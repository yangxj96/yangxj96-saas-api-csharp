using System.ComponentModel.DataAnnotations;

namespace yangxj96_serve_example.Model
{
    public class Demo
    {
        /// <summary>
        /// id
        /// </summary>
        [Display(Name = "ID")]
        public int Id { get; set; }

        /// <summary>
        ///  名称
        /// </summary>
        [Display(Name = "名称")]
        [Required(ErrorMessage = "请输入名称"), MaxLength(50, ErrorMessage = "名称长度不能超过50个字符")]
        public string? Name { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [Display(Name = "详情"), MaxLength(150, ErrorMessage = "详情长度不能超过150个字符")]
        [Required(ErrorMessage = "请输入详情")]
        public string? Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime? CreatedDate { get; set; }
    }
}
