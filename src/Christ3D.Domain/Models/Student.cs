using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Domain.Models
{
    /// <summary>
    /// 实体，领域模型，一个模型对应一个仓储，这里我用定义了空接口IAggregateRoot，代表这是聚合根
    /// </summary>
    public class Student:Entity,IAggregateRoot
    {
       
        protected Student()
        {
        }
        public Student(Guid id, string name, string email, string phone, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
           // Address = address;
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; private set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate { get; private set; }

        /// <summary>
        /// 户籍
        /// </summary>
        //public Address Address { get; private set; }
    }
}
