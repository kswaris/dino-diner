/* OrderControl.xaml.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Ordercontrol
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the delete from list method.
        /// </summary>
        /// <param name="sender">This is the sender.</param>
        /// <param name="args">This is the argument args.</param>
        public void DeleteFromList(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (sender is FrameworkElement element)
                    if (element.DataContext is IOrderItem item)
                        order.Items.Remove(item);
        }
        /// <summary>
        /// This is the emptylist Method.
        /// </summary>
        /// <param name="sender">This is the object sender.</param>
        /// <param name="args"> This is the object argument.</param>
        public void EmptyList(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                order.Items.Clear();
        }
    }
}
