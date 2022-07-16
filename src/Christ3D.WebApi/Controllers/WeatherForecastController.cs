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
        /// ����˿ͷ���:add & update
        /// ����ʾ��
        /// 1��saveCustomer() ������ҵ����ͼ����ȷ����ʱ����Ϊ��̰ͼ���ܵ�ǿ�󣬰�ע�������ŵ��˼����ϣ��Ӷ�������ҵ����ġ�
         //2��saveCustomer() ������ʵ�ֱ�����������Ǳ�ڵĸ����ԣ���Ȼ����ǿ���ˣ����Ǹ��Ӷ�ȴֱ�����ϡ�
        ///3��Customer �˿��������������Ƕ��󣬳���������һ�����ݳ����ߣ������ǰ����ǵ����ݴӳ־û������ݿ����ó��������ݵ�һ�����ߡ�
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

            //...������������

            ErrCustomerDao.SaveCustomer(customer);
        }
    }
}