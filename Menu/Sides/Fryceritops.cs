/* Fryceritops.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// This is the fryceritops 
    /// </summary>
    public class Fryceritops : Side
    {
        private Size size;
        /// <summary>
        /// This is the size property.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch(size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }
        /// <summary>
        /// This is the fryceritop constructor.
        /// </summary> 
        public Fryceritops()
        {
            base.Calories = 222;
            base.Price = 0.99;
        }
        /// <summary>
        /// This is the ingredients thing.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Potato",
                    "Salt",
                    "Vegetable Oil"
                };
                return ingredients;
            }
        }
    }
}
