/* PrehistoricPBJ.cs
 * Author: Sam Waris
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// This is the price property.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is the calorie property.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// This is the ingredients property.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// This is the constructor.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// This holds peanut
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// This holds jel
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
