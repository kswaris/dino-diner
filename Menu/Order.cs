/* Order.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
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
        /// <summary>
        /// /This is the propertychangedEventHandler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// This is the notify property change.
        /// </summary>
        /// <param name="PropertyName">This is the propertyname string.</param>
        protected void NotifyOfPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
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
            Items = new ObservableCollection<IOrderItem>();
            SalesTaxRate = 0.25; //25% sales tax
            this.Items.CollectionChanged += this.OnCollectionChanged;
        }
        /// <summary>
        /// This is the observablecollection, items.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
        /// <summary>
        /// This is the subtotalcost property.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0;
                foreach (IOrderItem i in Items)
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
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }
    }
}
