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
        private CretaceousCombo cc;
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
                cc = new CretaceousCombo(new Brontowurst());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc = new CretaceousCombo(new DinoNuggets());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc = new CretaceousCombo(new PterodactylWings());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc = new CretaceousCombo(new TRexKingBurger());
                order.Add(cc);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc = new CretaceousCombo(new DinoNuggets());
                order.Add(cc);
 CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

    }
}