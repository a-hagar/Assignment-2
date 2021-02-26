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
       ///  Finding the total number of ways two dice, regardless of sides, can roll a sum of 10
       ///  m = total sides for dice 1, n = total sides for dice 2
       /// </summary>

       /// <example>
       /// GET api/J2/DiceGame/6/6
       /// "There are 3 total ways to get a sum of 10"
       /// </example> 


        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            //the two dice where its sides are decided by id
            int dice1 = m;
            int dice2 = n;

            //counts the number of times the sum of 10 is rolled
            int count10 = 0;

            //initial loop for dice1, 
            // i starts at 1 to avoid a single die rolling on a 10
            for (int i = 1; i <= dice1; i++)
            {
                //loop for dice2
                // j starts at 1 to avoid a single die rolling on a 10
                for (int j = 1; j <= dice2; j++)
                {
                    //if statement that counts when i and j roll on the sum of 10
                    if (i + j == 10)
                    {
                        count10++;
                    }
                }
            }

            string message = "There are " + count10 + " ways to get the sum of 10";

            return message;
        }


    }
}
