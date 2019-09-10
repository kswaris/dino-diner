/* PterodactylWings.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        /// <summary>
        /// This is the price double. It holds the price.
        /// </summary>
        public double Price = 7.21;
        /// <summary>
        /// This is the uint calories. It holds the calories.
        /// </summary>
        public uint Calories = 318;
        /// <summary>
        /// This is the ingredients, it returns the list.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }
        /// <summary>
        /// This is pterodactylWings constructor.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
