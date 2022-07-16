using Christ3D.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Christ3D.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// 保存顾客方法:add & update
        /// 错误示范
        /// 1、saveCustomer() 方法的业务意图不明确，当时我们为了贪图功能的强大，把注意力都放到了技术上，从而忽略了业务核心。
         //2、saveCustomer() 方法的实现本来就增加了潜在的复杂性，虽然看着强大了，可是复杂度却直线向上。
        ///3、Customer 顾客领域对象根本不是对象，充其量就是一个数据持有者，仅仅是把我们的数据从持久化的数据库中拿出来到内容的一个工具。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="birthDate"></param>
        
        [HttpPost]
        public void saveCustomer(string id, string name, string email, string birthDate)
        {
            ErrCustomer customer = ErrCustomerDao.GetCustomer(id);
            if (customer == null)
            {
                customer = new ErrCustomer();
                customer.Id = id;
            }

            if (name != null)
            {
                customer.Name = name;
            }
            if (email != null)
            {
                customer.Email = email;
            }

            //...还有其他属性

            ErrCustomerDao.SaveCustomer(customer);
        }
    }
}