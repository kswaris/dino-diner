/* DinoNuggets.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        /// <summary>
        /// This is the nugget uint, it holds nugget count.
        /// </summary>
        private uint Nuggets = 6;
        /// <summary>
        /// This is the price double, it holds the price.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is the calories uint. It holds the calories.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// This is the ingredients property.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int x = 0; x < Nuggets; x++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// This is the dinonuggets constructor.
        /// </summary>
        public DinoNuggets()
        {
            this.Calories = 59 * Nuggets;
            this.Price = 4.25;
        }
        /// <summary>
        /// This is the addnugget method, it adds a nugget.
        /// </summary>
        public void AddNugget()
        {
            Nuggets++;
            Calories += 59;
            Price += .25;
        }
    }
}
