using ExampleService.Model;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;

namespace ExampleService.Controllers
{
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet, Route("example")] // ”казываем аттрибуты - HttpGet - показывает,
                                    // что наш метод будет обрабытвать HTTP запросы.
                                    // ћаршрут, который будет вести к этому методу
                                    // будет называтс€ "example"
        /// <summary>
        /// —оздаем метод, который будет возвращать нам список машин,
        /// которых мы описали
        /// </summary>
        public IEnumerable<ExampleWeb> Examples()
        {
            ExampleWeb audiExample = new()
            {
                Name = "AUDI",
                Id = 1
            };

            ExampleWeb mercedesExample = new()
            {
                Name = "MERCESES",
                Id = 2
            };

            List<ExampleWeb> listExample = new()
            {
                audiExample,
                mercedesExample
            };

            return listExample;
        }

        /// <summary>
        /// —оздадим метод, который будет возвращать одну машину
        /// и в качестве параметра возвращать идентификатор
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet, Route("example/{id}")] // при вызове этого метода
                                         // ќЅя«ј“≈Ћ№Ќќ нужно передать идентификатор
        public ExampleWeb Example(int id)
        {
            ExampleWeb mercedesExample = new()
            {
                Name = "MERCESES",
                Id = id
            };

            return mercedesExample;
        }

        /// <summary>
        /// —оздадим метод, который будет —„»“џ¬ј“№ параметры
        /// и возвращать их результат
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        /*[Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("example/{id}/{name}")] // при вызове этого метода
                                                                                                   // ќЅя«ј“≈Ћ№Ќќ нужно передать идентификатор
        public IHttpActionResult NewExample(int id, string name)
        {
            return (IHttpActionResult)Ok();

        }*/
    }
}