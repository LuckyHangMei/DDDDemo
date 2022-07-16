namespace Christ3D.WebApi.Models
{
    /// <summary>
    /// 持久化虚拟类
    /// </summary>
    public class ErrCustomerDao
    {
        public static ErrCustomer GetCustomer(string id)
        {
            return new ErrCustomer() { Id = "1", Name = "Christ", Email = "Christ@123.com" };
        }


        public static string SaveCustomer(ErrCustomer customer)
        {
            return "保存成功";
        }
    }
}
