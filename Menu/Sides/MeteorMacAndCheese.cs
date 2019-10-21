/* MeteorMacAndCheese.cs
 * Author: Sam Waris
 * This is the meteor mac and cheese class. it extends sides.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// This is the size property.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// This is the MeteorMacAndCheese constructor.
        /// </summary>
        public MeteorMacAndCheese()
        {
            base.Calories = 420;
            base.Price = 0.99;
        }
        /// <summary>
        /// This is the ingredients thing.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Macaroni Noodles",
                    "Cheese Product",
                    "Pork Sausage"
                };
                return ingredients;
            }
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return this.size.ToString() + " Meteor Mac and Cheese";
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
            get { return new string[0]; }
        }
    }
}
