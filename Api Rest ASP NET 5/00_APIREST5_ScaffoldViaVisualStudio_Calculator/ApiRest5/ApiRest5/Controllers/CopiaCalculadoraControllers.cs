using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CopiaCalculadoraControllers : Controller
    {
        private readonly ILogger<CopiaCalculadoraControllers> _logger;

        public CopiaCalculadoraControllers(ILogger<CopiaCalculadoraControllers> logger)
        {
            _logger = logger;
        }
        /*
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            var Url = HttpContext.Request.Query;            

            if (Isnumric(firstNumber) && Isnumric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        */

        /*
            DESAFIO!!!
        
            IMPLEMENTAR AS DEMIAS OPERAÇÕES
            
            * Subtração
            * Multiplicação
            * Divisão
            * Média
            * Raiz Quadrada
        */

        [HttpGet("{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Calc(string calc, string firstNumber, string secondNumber)
        {
            calc = HttpContext.Request.Path.Value.ToString();

            if (calc.Contains("sub"))
            {
                var resultado = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(resultado.ToString());
            }
            else if (calc.Contains("mul"))
            {
                var resultado = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(resultado.ToString());
            }
            else if (calc.Contains("div"))
            {
                var resultado = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(resultado.ToString());
            }
            else if (calc.Contains("sum"))
            {
                var resultado = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(resultado.ToString());
            }
            return BadRequest("Invalid Input");
        }


        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool Isnumric(string strNumber)
        {
            double number;
            bool isNumer = double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumer;
        }
    }
}

