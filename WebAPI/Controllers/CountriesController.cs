using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareer1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet("get1")]
        public string[] Get1()
        {
            string[] countries = new string[]{
            "Türkiye", "Azerbaycan", "Fransa", "Japonya", "Brezilya",
            "Kanada", "Avustralya", "Hindistan", "Meksika", "Güney Afrika",
            "İtalya", "İspanya", "Rusya", "Çin", "ABD",
            "İngiltere", "Arjantin", "İsveç", "Norveç", "Güney Kore"
            };

            return countries;
        }

        [HttpGet("get2")]
        public string Get2(int id)
        {
            string[] countries = new string[] {
            "Türkiye", "Azerbaycan", "Fransa", "Japonya", "Brezilya",
            "Kanada", "Avustralya", "Hindistan", "Meksika", "Güney Afrika",
            "İtalya", "İspanya", "Rusya", "Çin", "ABD",
            "İngiltere", "Arjantin", "İsveç", "Norveç", "Güney Kore"
            };
            string result = "";

            if (id < 0 || id >= countries.Length)
            {
                return "Invalid ID";
            }
            else
            {
                for (int i = 0; i < id; i++)
                {

                    result += countries[i] + "\n";

                }
            }
            return result;
        }
    }
}