using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Application.ViewModels
{
    public class StudentViewModel
    {
        public Guid? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get;  set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get;  set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get;  set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate { get;  set; }
    }
}
