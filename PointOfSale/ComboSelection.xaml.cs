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
                CretaceousCombo c = new CretaceousCombo(new Brontowurst());
                cc = c;
                order.Add(cc);
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
                CretaceousCombo c = new CretaceousCombo(new DinoNuggets());
                cc = c;
                order.Add(cc);
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
                CretaceousCombo c = new CretaceousCombo(new PrehistoricPBJ());
                cc = c;
                order.Add(cc);
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
                CretaceousCombo c = new CretaceousCombo(new PterodactylWings());
                cc = c;
                order.Add(cc);
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
                CretaceousCombo c = new CretaceousCombo(new SteakosaurusBurger());
                cc = c;
                order.Add(cc);
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
                CretaceousCombo c = new CretaceousCombo(new TRexKingBurger());
                cc = c;
                order.Add(cc);
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
                CretaceousCombo c = new CretaceousCombo(new VelociWrap());
                cc = c;
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

    }
}