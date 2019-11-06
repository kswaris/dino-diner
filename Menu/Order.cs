/* Order.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// /This is the order class.
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        private ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
        //private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// /This is the propertychangedEventHandler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        /// <summary>
        /// This is the salestax rate Property.
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// This is the salestaxcost property.  
        /// </summary>
        public double SalesTaxCost
        {
            get { return SalesTaxRate * SubtotalCost; }
        }
        /// <summary>
        /// This is the total cost property.
        /// </summary>
        public double TotalCost
        {
            get { return SubtotalCost + SalesTaxCost; }
        }
        /// <summary>
        /// This is the order constructor.
        /// </summary>
        public Order()
        {
            this.SalesTaxRate = 0.25;

            /*
            items = new ObservableCollection<IOrderItem>();
            SalesTaxRate = 0.25; //25% sales tax
            items.CollectionChanged += this.OnCollectionChanged;
            */
        }
        /// <summary>
        /// This is the observablecollection, items.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get { return items ; } }
        /// <summary>
        /// This is the subtotalcost property.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0;
                foreach (IOrderItem i in items)
                    total += i.Price;
                return Math.Max(total, 0);
            }
        }
        /// <summary>
        /// This is the oncollectionchanged notifyer.
        /// </summary>
        /// <param name="sender"> This is the sender object.</param>
        /// <param name="e"> This is the notifycollectionchangedargs object.</param>
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        /// <summary>
        /// This adds an item to the item collection.
        /// </summary>
        /// <param name="item">This is the item you are adding</param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += NotifyItemChanged;
            items.Add(item);
            NotifyItemChanged(this, null);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }
        /// <summary>
        /// This removes an item from the collection
        /// </summary>
        /// <param name="item">This adds an item to the collectoin</param>
        /// <returns>This is the item if it is successful</returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            NotifyItemChanged(this, null);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            return removed;
        }
        /// <summary>
        /// This is the notify item changed method
        /// </summary>
        /// <param name="sender">This is the object sender</param>
        /// <param name="e">This is the propertychangedeventarguments</param>
        public void NotifyItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
