/* MezzorellaSticks.cs
 * Author: Sam Waris
 * this is the mezzorellasticks class. It extend sthe side class.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This ist the mozzerella sticks class
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem
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
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }
        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public MezzorellaSticks()
        {
            base.Calories = 540;
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
                    "Cheese Product",
                    "Breading",
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
            return this.size.ToString() + " Mezzorella Sticks";
        }
    }

}
