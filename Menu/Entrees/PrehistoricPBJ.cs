﻿/* PrehistoricPBJ.cs
 * Author: Sam Waris
 * This is the prehistoricPBJ class. It has information about the pbj sandwich.
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the prehistoricpbj class
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
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
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Prehistoric PB & J";
        }
    }
}
