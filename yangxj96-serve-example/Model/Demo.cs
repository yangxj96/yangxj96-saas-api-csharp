using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yangxj96_serve_example.Model
{
    public class Demo
    {
        /// <summary>
        /// id
        /// </summary>
        [Display(Name = "ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        ///  名称
        /// </summary>
        [Display(Name = "名称"), Required(ErrorMessage = "请输入名称"), MaxLength(50, ErrorMessage = "名称长度不能超过50个字符")]
        public string? Name { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [Display(Name = "详情"), Required(ErrorMessage = "请输入详情"), MaxLength(150, ErrorMessage = "详情长度不能超过150个字符")]
        public string? Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 是否删除了
        /// </summary>
        [Required(ErrorMessage = "请输入是否删除")]
        public bool IsDeleted { get; set; }
    }
}