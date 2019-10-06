/* SteakosaurusBurger.cs
 * Author: Sam Waris
 * This is the steakosaurusburger class. It houses things about the steakburger.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the steakosaurus burger class
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem
    {
        /// <summary>
        /// This is the bun bool.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This is the pickle bool.
        /// </summary>/
        private bool pickle = true;
        /// <summary>
        /// This is the pattie bool.
        /// </summary>
        private bool pattie = true;
        /// <summary>
        /// This is the ketchup bool.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// This is the mustard bool.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Steakosaurus Constructor
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }
        /// <summary>
        /// This is the ingredients, it returns the list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pattie) ingredients.Add("Steakburger Pattie");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (pickle) ingredients.Add("Pickle");
                return ingredients;
            }
        }
        /// <summary>
        /// This allows you to hold the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        /// <summary>
        /// This allows you to hold the pickle.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }
        /// <summary>
        /// This allows you to hold the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }
        /// <summary>
        /// This allows you to hold the mustard.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
