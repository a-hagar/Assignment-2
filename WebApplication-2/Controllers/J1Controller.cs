using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        ///  Adding the calories of order of a burger, drink, side and a dessert, returns the toal calories of an order
        /// </summary>

        /// <example>
        /// GET  api/J1//Menu/{burger}/{drink}/{side}/{dessert}
        /// "Your total calorie count is [total]"
        /// </example> 

        
            [HttpGet]
            [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
            public string Menu(int burger, int drink, int side, int dessert)
            {

                int burger0 = 0;
                int burger1 = 461;
                int burger2 = 431;
                int burger3 = 420;
                int burger4 = 0;
                int [] burgerMenu= { burger0, burger1, burger2, burger3, burger4};
                var burgerOrder = burgerMenu[burger];

                int drink0 = 0;
                int drink1 = 130;
                int drink2 = 160;
                int drink3 = 118;
                int drink4 = 0;
                int[] drinkMenu = { drink0, drink1, drink2, drink3, drink4 };
                var drinkOrder = drinkMenu[drink];

                int side0 = 0;
                int side1 = 100;
                int side2 = 57;
                int side3 = 70;
                int side4 = 0;
                int[] sideMenu = { side0, side1, side2, side3, side4};
                var sideOrder = sideMenu[side];

                int dessert0 = 0;
                int dessert1 = 167;
                int dessert2 = 266;
                int dessert3 = 75;
                int dessert4 = 0;
                int[] dessertMenu = { dessert0, dessert1, dessert2, dessert3, dessert4 };
                var dessertOrder = dessertMenu[dessert];

                var newOrder = burgerOrder + drinkOrder + sideOrder + dessertOrder;

                string orderMessage = "Your total calorie count is " + newOrder;

                return orderMessage;

            }


        }
    }
   
