﻿/* SteakosaurusBurger.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
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
    }
}
