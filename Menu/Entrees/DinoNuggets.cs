﻿/* DinoNuggets.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This is the dinonuggets class.
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// This is the nugget uint, it holds nugget count.
        /// </summary>
        private uint Nuggets = 6;
        /// <summary>
        /// This is the ingredients list
        /// </summary>
        public override List<string> Ingredients
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
            Calories = 59 * Nuggets;
            Price = 4.25;
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
