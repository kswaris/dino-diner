﻿/* DinoNuggets.cs
 * Author: Sam Waris
 * This is the dinonuggets class. it has information about dino nuggets.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the dinonuggets class.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                    ingredients.Add("Chicken Nugget");
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
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
        /// <summary>
        /// The big getter setter
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(Nuggets > 6)
                {
                    special.Add($"{Nuggets - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }
        /// <summary>
        /// This is the description string.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
    }
}
