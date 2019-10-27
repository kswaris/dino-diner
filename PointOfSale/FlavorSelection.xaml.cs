/* FlavorSelection.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// This is the flavor selection default constructor
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the cola click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void ColaClick(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Cola;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This is the orange click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void OrangeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Orange;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This is the vanilla click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void VanillaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Vanilla;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This is the chocolate click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void ChocolateClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Chocolate;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This is the rootbeer click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void RootBeerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.RootBeer;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This is the cherry click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void CherryClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Cherry;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This is the lime click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void LimeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Lime;
                    NavigationService.Navigate(new DrinkSelection());
                }
        }
        /// <summary>
        /// This returns to the menu
        /// </summary>
        /// <param name="sender">This is the useless sender</param>
        /// <param name="args">This is the useless args</param>
        public void ReturnToMenu(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new DrinkSelection());
        }
    }
}
