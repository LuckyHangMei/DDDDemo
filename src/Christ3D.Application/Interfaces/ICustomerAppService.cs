using Christ3D.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Application.Interfaces
{
    /// <summary>
    /// 用来存放我们的对外服务接口，
    /// 然后添加 Customer服务接口类，这里要说明下，在应用层对外接口中，
    /// 我们就不需要定义泛型基类了，因为已经没有必要，甚至是无法抽象的
    ///  并继承IDisposable，显式释放资源
    /// 注意这里我们使用的对象，是视图对象模型
    /// </summary>
    public interface ICustomerAppService: IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(Guid id);
        void Update(CustomerViewModel customerViewModel);
        void Remove(Guid id);
    }
}
