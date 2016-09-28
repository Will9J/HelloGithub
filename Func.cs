using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huibo.Liaoyuan.Server.Core.Entities
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Func : EntityBase
    {
        /// <summary>
        /// 角色编号
        /// </summary>
        [Key]  //DatabaseGenerated为取消自增长编号
        public int FuncID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [StringLength(50)]
        [Required]
        public string FuncName{ get; set; }

        /// <summary>
        /// 父级部门编号
        /// </summary>
        [Required]
        public int ParentID { get; set; }

        /// <summary>
        /// 权限类型：菜单、功能
        /// </summary>
        [StringLength(100)]
        [Required]
        public string FuncType { get; set; }
        /// <summary>
        /// 权限级别：1,2,3
        /// </summary>
        [Required]
        public int FuncLevel { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        [StringLength(100)]
        public string LinkUrl   { get; set; }
        /// <summary>
        /// 系统权限标识名称
        /// </summary>
        [StringLength(50)]
        [Required]
        public string FuncSystemName    { get; set; }
    
    }
}
