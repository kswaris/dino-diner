/* ComboSelection.cs
 * Author: Sam Waris
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;
using System.Windows.Data;

namespace PointOfSale
{ 
    /// <summary>
    /// This is the partial class comboselection
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event for brontowursts
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnBrontowurstClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new Brontowurst()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the event for dinonuggets
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnDinoNuggetsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new DinoNuggets()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the event for prehistoricpbj
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnPrehistoricPBJClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the event for pterodactylwings
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnPterodactylWingsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new PterodactylWings()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the event for steakosaurusburger
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnSteakosaurusBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the event for texrexkingburger
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnTRexKingBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new TRexKingBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the event for velociwrap
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the arguments</param>
        public void OnVelociWrapClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new CretaceousCombo(new VelociWrap()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

    }
}