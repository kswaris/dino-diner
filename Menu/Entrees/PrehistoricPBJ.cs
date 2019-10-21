/* PrehistoricPBJ.cs
 * Author: Sam Waris
 * This is the prehistoricPBJ class. It has information about the pbj sandwich.
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the prehistoricpbj class
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem
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
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds jel
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
        /// <summary>
        /// This is the description override.
        /// </summary>
        public override string Description
        {
            get{ return this.ToString(); }
        }
        /// <summary>
        /// This is the override method
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
