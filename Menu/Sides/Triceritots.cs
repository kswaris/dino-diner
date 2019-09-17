/* Triceritots.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides 
{
    public class Triceritots : Side
    {
        private Size size;
        /// <summary>
        /// This is the size property for triceritots.
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
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }
        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public Triceritots()
        {
            base.Calories = 352;
            base.Price = 0.99;
        }
        /// <summary>
        /// This is the ingredients list.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil"); ;
                return ingredients;
            }
        }
    }
}
