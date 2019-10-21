/* Side.cs
 * Sam Waris
 * The side class. IT has the side base class.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Side class
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private double price;
        private uint calories;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                NotifyOfPropertyChanged("Price");
            }
        }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// This is the description, abstracted.
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// This is the special, abstracted.
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
