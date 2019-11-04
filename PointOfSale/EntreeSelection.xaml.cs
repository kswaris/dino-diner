/* EntreesElection.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// This is the entree selection default constructor
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Brontowurst click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void BrontowurstClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Brontowurst());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new BrontowurstCustomization());
            }
        }
        /// <summary>
        /// DinoNuggets click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void DinoNuggetsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new DinoNuggets());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new DinoNuggetsCustomization());
            }
        }
        /// <summary>
        /// PrehistoricPBJ click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void PrehistoricPBJClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new PrehistoricPBJ());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new PrehistoricPBJCustomization());
            }
        }
        /// <summary>
        /// Pterodactyl Wings click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void PterodactylWingsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new PterodactylWings());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Steakosaurus click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void SteakosaurusBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new SteakosaurusBurger());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new SteakosaurusBurgerCustomization());
            }
        }
        /// <summary>
        /// TRexKingBurger click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void TRexKingBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new TRexKingBurger());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new TRexKingBurgerCustomization());
            }
        }
        /// <summary>
        /// Velociwrap click event
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="args">routedevent argument</param>
        public void VelociwrapClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new VelociWrap());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new VelociwrapCustomization());
            }
        }
    }
}
