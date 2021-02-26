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
        /// GET api/J1/Menu/1/2/3/4
        /// "Your total calorie count is 691"
        /// </example> 
        /// <example>
        /// GET api/J1/Menu/0/200/-3/44
        /// "Please order an item from the menu!"
        /// </example>

        
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {

            // burger menu, 0 is blank to start the array at 1, user choses item with id
            int burger0 = 0;
            int burger1 = 461;
            int burger2 = 431;
            int burger3 = 420;
            int burger4 = 0;
            int[] burgerMenu = { burger0, burger1, burger2, burger3, burger4 };


            // drink menu, 0 is blank to start the array at 1, user choses item with id
            int drink0 = 0;
            int drink1 = 130;
            int drink2 = 160;
            int drink3 = 118;
            int drink4 = 0;
            int[] drinkMenu = { drink0, drink1, drink2, drink3, drink4 };
           

            // side menu, 0 is blank to start the array at 1, user choses item with id
            int side0 = 0;
            int side1 = 100;
            int side2 = 57;
            int side3 = 70;
            int side4 = 0;
            int[] sideMenu = { side0, side1, side2, side3, side4 };
            

            // dessert menu, 0 is blank to start the array at 1, user choses item with id
            int dessert0 = 0;
            int dessert1 = 167;
            int dessert2 = 266;
            int dessert3 = 75;
            int dessert4 = 0;
            int[] dessertMenu = { dessert0, dessert1, dessert2, dessert3, dessert4 };

            // a message to prevent incorrect orders outside of array
            string wrongOrder = "Please order a item from the menu!";

            // if statement if any order is not on the menu (outisde 1-4)
            if ( burger < 1 || burger > 4 || drink < 1 || drink > 4 || side < 1 || side > 4 || dessert < 1 || dessert > 4)
            {

                return wrongOrder;

            }
            // else statement if all orders are on the menu
            else {
                var burgerOrder = burgerMenu[burger];
                var drinkOrder = drinkMenu[drink];
                var sideOrder = sideMenu[side];
                var dessertOrder = dessertMenu[dessert];

                // adds all the individual orders together to calculate total calories
                var newOrder = burgerOrder + drinkOrder + sideOrder + dessertOrder;


                string orderMessage = "Your total calorie count is " + newOrder;


                return orderMessage;

            }
        }
    }
}
   
