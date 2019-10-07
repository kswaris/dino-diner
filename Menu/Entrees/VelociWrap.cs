/* Velociwrap.cs
 * Author: Sam Waris
 * This is the velociwrap class. It extends entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Velociwrap Class
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// This is the dressing bool.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// This is the lettuce bool.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// This is the cheese bool.
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// This is the constructor.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
        /// <summary>
        /// This is the ingredients list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// This holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }
        /// <summary>
        /// This holds the dressing.
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }
        /// <summary>
        /// This holds the cheese.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
