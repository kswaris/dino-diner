/* Triceritots.cs
 * Author: Sam Waris
 * This is the triceritots base class. It extends the side.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// This is the triceritots class.
    /// </summary>
    public class Triceritots : Side, IMenuItem
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
            Size = Size.Small;
            base.Calories = 352;
            base.Price = 0.99;
        }
        /// <summary>
        /// This is the ingredients list.
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
                ;
                return ingredients;
            }
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return this.size.ToString() + " Triceritots";
        }
    }
}
