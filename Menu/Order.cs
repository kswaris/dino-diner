/* Order.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// /This is the order class.
    /// </summary>
    public class Order
    {
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
            SalesTaxRate = 0.25; //15% sales tax
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
    }
}
