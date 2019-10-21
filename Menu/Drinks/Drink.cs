/* Drink.cs
 * Author: Sam Waris
 * This is the drink.cs class It houses drink things.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Drinks class.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private bool _ice = true;
        /// <summary>
        /// This is the price double, it holds the price.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is the calories uint, it has properties.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// This is the ingreidents list. It has a getter.
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// This is the size property.
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// This is the ice getter/setter.
        /// </summary>
        public bool Ice
        {
            get { return _ice; }
            set
            {
                _ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("Special");
            }
        }
        /// <summary>
        /// This is the description getter, abstracted.
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// This is the special getter, abstrated.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// THis holds the ice.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
        /// <summary>
        /// The event handler handles if any drink properties were changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// An accessor method for doing things.
        /// </summary>
        /// <param name="name">Tproperty to change.</param>
        protected void NotifyOfPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
