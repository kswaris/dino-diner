/* PrehistoricPBJ.cs
 * Author: Sam Waris
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// This is the peanut butter bool
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// This is the jelly bool
        /// </summary>
        private bool jelly = true;
        /// <summary>
        /// This is the ingredients list.
        /// </summary>
        public override List<string> Ingredients
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
            Price = 6.52;
            Calories = 483;
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
