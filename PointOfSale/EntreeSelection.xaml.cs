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
        private Entree _entree;

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
                Brontowurst bw = new Brontowurst();
                _entree = bw;
                order.Add(_entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new BrontowurstCustomization(_entree as Brontowurst));
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
                DinoNuggets dn = new DinoNuggets();
                _entree = dn;
                order.Add(_entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new DinoNuggetsCustomization(_entree as DinoNuggets));
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
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                _entree = pbj;
                order.Add(_entree); CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new PrehistoricPBJCustomization(_entree as PrehistoricPBJ));
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
                PterodactylWings ptw = new PterodactylWings();
                order.Add(ptw);
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
                SteakosaurusBurger sb = new SteakosaurusBurger();
                _entree = sb;
                order.Add(_entree); CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(_entree as SteakosaurusBurger));
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
                TRexKingBurger tkb = new TRexKingBurger();
                _entree = tkb;
                order.Add(_entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new TRexKingBurgerCustomization(_entree as TRexKingBurger));
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
                VelociWrap vw = new VelociWrap();
                _entree = vw;
                order.Add(_entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new VelociwrapCustomization(_entree as VelociWrap));
            }
        }
    }
}
