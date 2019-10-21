/* Velociwrap.cs
 * Author: Sam Waris
 * This is the velociwrap class. It extends entree.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Velociwrap Class
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// This is the description override.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// This is the special override.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> info = new List<string>();
                if (!this.dressing) info.Add("Hold Dressing");
                if (!this.lettuce) info.Add("Hold Lettuce");
                if (!this.cheese) info.Add("Hold Cheese");
                return info.ToArray();
            }
        }
        /// <summary>
        /// This holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the dressing.
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the cheese.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            NotifyOfPropertyChanged("Special");
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
