using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogicTestQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogicTest1Controller : ControllerBase
    {
        // GET: api/<LogicTest1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LogicTest1Controller>/5
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            string result = cal1(id);
            return new string[] { result.ToString() };

        }

        // POST api/<LogicTest1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LogicTest1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogicTest1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private string cal1(int number)
        {
            StringBuilder sb = new StringBuilder();
            sb.Remove(0, sb.Length);
            string tmp = "";
            int numberTmp, n;
            //number = 5;
            numberTmp = 0;
            while (numberTmp <= number)
            {
                n = 1;
                for (int i = numberTmp; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Factorial of {0}! = {1}\n", numberTmp, n);
                tmp = String.Format("Factorial of {0}! = {1} ", numberTmp, n);
                sb.Append(tmp);
                sb.Append("<br>");
                numberTmp++;
            }
            return sb.ToString();
        }

        private double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
            {
                return number * factorial_Recursion(number - 1);
            }
        }
    }
}
