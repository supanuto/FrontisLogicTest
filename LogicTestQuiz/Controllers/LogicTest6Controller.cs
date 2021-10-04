using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogicTestQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogicTest6Controller : ControllerBase
    {
        // GET: api/<LogicTest6ControllerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LogicTest6ControllerController>/5
        [HttpGet("{val}")]
        public string Get(string val)
        {     
            return "value";
        }

        // POST api/<LogicTest6ControllerController>
        [HttpPost]
        public IActionResult Post([FromBody] formValueCal _formValueCal)
        {
            
            ActionResult returnResult;
            try
            {
                double result = 0.00;
                Calc _calculator = new Calc();
                result = _calculator.Solve(_formValueCal.calInput);
                returnResult = Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
            return returnResult;
        }

        // PUT api/<LogicTest6ControllerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogicTest6ControllerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        public class formValueCal
        {
            public string calInput { get; set; }
        }


        public class Calc
        {
            public double Solve(string equation)
            {
                // Remove all spaces
                equation = Regex.Replace(equation, @"\s+", "");

                Operation operation = new Operation();
                operation.Parse(equation);

                Console.WriteLine(operation.LeftNumber);
                Console.WriteLine(operation.RightNumber);

                double result = operation.Solve();

                return result;
            }
        }

        public class Operation
        {
            public Operation LeftNumber { get; set; }
            public string Operator { get; set; }
            public Operation RightNumber { get; set; }

            private Regex additionSubtraction = new Regex("[+-]", RegexOptions.RightToLeft);
            private Regex multiplicationDivision = new Regex("[*/]", RegexOptions.RightToLeft);

            public void Parse(string equation)
            {
                var operatorLocation = additionSubtraction.Match(equation);
                if (!operatorLocation.Success)
                {
                    operatorLocation = multiplicationDivision.Match(equation);
                }

                if (operatorLocation.Success)
                {
                    Operator = operatorLocation.Value;

                    LeftNumber = new Operation();
                    LeftNumber.Parse(equation.Substring(0, operatorLocation.Index));

                    RightNumber = new Operation();
                    RightNumber.Parse(equation.Substring(operatorLocation.Index + 1));
                }
                else
                {
                    Operator = "v";
                    result = double.Parse(equation);
                }
            }

            private double result;

            public double Solve()
            {
                switch (Operator)
                {
                    case "v":
                        break;
                    case "+":
                        result = LeftNumber.Solve() + RightNumber.Solve();
                        break;
                    case "-":
                        result = LeftNumber.Solve() - RightNumber.Solve();
                        break;
                    case "*":
                        result = LeftNumber.Solve() * RightNumber.Solve();
                        break;
                    case "/":
                        result = LeftNumber.Solve() / RightNumber.Solve();
                        break;
                    default:
                        throw new Exception("Call Parse first.");
                }

                return result;
            }
        }

    }
}
