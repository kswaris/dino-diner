﻿/* OrderControl.xaml.cs
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
        /// This is used for navigation
        /// </summary>
        public NavigationService Navigation { get; set; }
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
                        order.Remove(item);
                        //order.Items.Remove(item);
        }
        /// <summary>
        /// This is the emptylist Method.
        /// </summary>
        /// <param name="sender">This is the object sender.</param>
        /// <param name="args"> This is the object argument.</param>
        public void EmptyList(object sender, RoutedEventArgs args)
        {
            //if (DataContext is Order order)
                //order.Items.Clear();
        }
        /// <summary>
        /// On Selection Changes
        /// </summary>
        /// <param name="sender">This is the object sender.</param>
        /// <param name="args"> This is the object argument.</param>
        public void OnSelectionChanged(object sender, EventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                Navigation?.Navigate(new SideSelection(side));

            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                Navigation?.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                Navigation?.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                Navigation?.Navigate(new MenuCategorySelection());
            }

        }
    }
}
