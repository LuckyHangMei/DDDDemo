using Christ3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Domain.Interfaces
{
    /// <summary>
    /// 某个领域模型对应的特定的仓储接口
    /// 注意，这里我们用到的业务对象，是领域对象
    /// </summary>
    public interface ICustomerRepository:IRepository<Customer>
    {
        //一些Customer独有的接口
        Customer GetByEmail(string email);
    }
}
