using Christ3D.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Domain.Models
{
    /// <summary>
    /// 值对象
    /// </summary>
    public class Address:ValueObject<Address>
    {
        /// 省份
        /// </summary>
        public string Province { get; private set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; private set; }
    }
}
