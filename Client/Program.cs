using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        /// <summary>
        /// Из этого приложения попробуем обратиться к веб-сервису
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string forExample = GetString("https://localhost:7144/example");
        }
        public static string GetString(string reqUrl)
        {
            string res = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    res = client.GetAsync(reqUrl).Result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception)
            {

            }
            return res;
        }
    }
}
