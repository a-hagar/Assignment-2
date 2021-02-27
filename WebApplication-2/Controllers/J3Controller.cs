using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// J3 question from the 2009 CCC
        /// link: https://cemc.math.uwaterloo.ca/contests/computing/2009/stage1/juniorEn.pdf#page=6
        
        /// <summary> 
        /// Finding the local times for major Canadian cities based on Ottawa's local time
        /// </summary>

        /// <param name="time"> Ottawa time in 24 hr format from 0 to 2359 </param>

        /// <returns> A list of local times from various Canadian cities  </returns>

        /// <example>
        /// GET api/J3/Timezone/1200
        /// "It is 1200 in Ottawa."
        /// "It is 900 in Victoria."
        /// "It is 1000 in Edmonton."
        /// "It is 1100 in Winnipeg."
        /// "It is 1200 in Toronto."
        /// "It is 1300 in Halifax."
        /// "It is 1330 in St. John's"
        /// </example> 

        [HttpGet]
        [Route("api/J3/Timezone/{time}")]
        public IEnumerable<string> Timezone(int time)
        {

            // if statement that only accepts input from 0 to 2359
            string errorMsg = "Enter a valid time!";

            if (time >= 2400)
            {
                return new string[] { errorMsg };

            } else if (time < 0)
            {
                return new string[] { errorMsg };
            }

            // if statement to round any input 60 mins or more up to the nearest hour
            if (time % 100 >= 60)
            {
                time = time + (100 - time % 100) + time % 10;
            }

            //major Canadian cities local times corresponding with Ottawa time
            int vicTime = time - 300;
            int edmTime = time - 200;
            int winTime = time - 100;
            int torTime = time;
            int halTime = time + 100;
            int stjTime = time + 130;

            // if statement to fix time zones when they go over or under the 24 hr range
            if (vicTime < 0){
                vicTime = vicTime+ 2400;
            }
            if (edmTime < 0)
            {
                edmTime = edmTime + 2400;
            }
            if (winTime < 0)
            {
                winTime = winTime + 2400;
            }
            if (halTime >= 2400)
            {
                halTime = halTime - 2400;
            }
            if (stjTime >= 2400)
            {
                stjTime = stjTime - 2400;
            }

            //if statement that corrects Newfoundland time if it reaches 60 or more minutes
            if (stjTime % 100 >= 60)
            {
                stjTime = stjTime + (100 - stjTime % 100) + stjTime % 10;
            }

            // messages for each city
            string messageOtt = "It is " + time + " in Ottawa.";
            string messageVic = "It is " + vicTime + " in Victoria";
            string messageEdm = "It is " + edmTime + " in Edmonton.";
            string messageWin = "It is " + winTime + " in Winnipeg.";
            string messageTor = "It is " + torTime + " in Toronto.";
            string messageHal = "It is " + halTime + " in Halifax.";
            string messageStj = "It is " + stjTime + " in St. John's.";

            return new string[] { messageOtt, messageVic, messageEdm, messageWin, messageTor, messageHal, messageStj };

            

            }

        }
}
