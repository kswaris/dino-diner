/* Entree.cs
 * Author: Sam Waris
 * This is the entree class, it is the bas eclass for entrees.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree Class.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This is the price variable.
        /// </summary>
        private double price;
        /// <summary>
        /// This is the unit calories.
        /// </summary>
        private uint calories;
        /// <summary>
        /// This is the calories property.
        /// </summary>
        public uint Calories
        {
            get
            {
                return this.calories;
            }
            set
            {
                calories = value;
                NotifyOfPropertyChanged("Calories");

            }
        }
        /// <summary>
        /// This is the price constructor.
        /// </summary>
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                price = value;
                NotifyOfPropertyChanged("Price");
            }
        }
        /// <summary>
        /// This is the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// Description getter
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// This is the string array special
        /// </summary>
        public abstract string[] Special { get; }
        /// <summary>
        /// The event handler handles if any drink properties were changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// An accessor method for doing things.
        /// </summary>
        /// <param name="name">Tproperty to change</param>
        protected void NotifyOfPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
