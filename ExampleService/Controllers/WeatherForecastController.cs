using ExampleService.Model;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;

namespace ExampleService.Controllers
{
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet, Route("example")] // ��������� ��������� - HttpGet - ����������,
                                    // ��� ��� ����� ����� ����������� HTTP �������.
                                    // �������, ������� ����� ����� � ����� ������
                                    // ����� ��������� "example"
        /// <summary>
        /// ������� �����, ������� ����� ���������� ��� ������ �����,
        /// ������� �� �������
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
        /// �������� �����, ������� ����� ���������� ���� ������
        /// � � �������� ��������� ���������� �������������
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet, Route("example/{id}")] // ��� ������ ����� ������
                                         // ����������� ����� �������� �������������
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
        /// �������� �����, ������� ����� ��������� ���������
        /// � ���������� �� ���������
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        /*[Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("example/{id}/{name}")] // ��� ������ ����� ������
                                                                                                   // ����������� ����� �������� �������������
        public IHttpActionResult NewExample(int id, string name)
        {
            return (IHttpActionResult)Ok();

        }*/
    }
}