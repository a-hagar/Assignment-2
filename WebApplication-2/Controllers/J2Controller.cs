using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_2.Controllers
{
    public class J2Controller : ApiController
    {  /// <summary>
       ///  Finding the total number of ways two dice can add to 10
       /// </summary>

       /// <example>
       /// GET  api/J1//Menu/{burger}/{m}
       /// "There are [total] total ways to get a sum of 10"
       /// </example> 


        [HttpGet]
        [Route("api/J1/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
           


            string message = "There are " + m + " ways to get the sum of 10";
            return message;
        }


    }
}
