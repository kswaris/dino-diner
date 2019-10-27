/*SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// This is the order variable
        /// </summary>
        public Order order = new Order();
        /// <summary>
        /// This is the sideselection method.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds fryceritops
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void FryceritopsClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Items.Add(new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// Adds MeteorMacAndCheese
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void MeteorMacAndCheeseClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new MeteorMacAndCheese());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// Adds Mezzorella Sticks
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void MezzorellaSticksClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new MezzorellaSticks());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// Adds Triceritots
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void Triceritots(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Triceritots());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// This is sidemakesmall. This makes the side small.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void SideMakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
        }
        /// <summary>
        /// This is sidemakemedium. This makes the side medium.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void SideMakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
        }
        /// <summary>
        /// This is sidemakeLarge. This makes the side Large.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void SideMakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
        }
    }
}
