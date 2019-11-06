/* CustomizeCombo.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// This is the cc variable
        /// </summary>
        private CretaceousCombo cc;
        /// <summary>
        /// This is the customize combo constructor
        /// </summary>
        /// <param name="c">this is the combo</param>
        public CustomizeCombo(CretaceousCombo c)
        {
            cc = c;
            InitializeComponent();
        }
        /// <summary>
        /// This is the customize combo default constructor
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the sidestep method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="e">This is the router object.</param>
        private void SideStep(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(cc));
        }
        /// <summary>
        /// This is the todrinks method, it takes you to drinks
        /// </summary>
        /// <param name="Sender">This is the sender object</param>
        /// <param name="e">This is the argument object</param>
        private void ToDrinks(object Sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(cc));
        }
        /// <summary>
        /// This is the ComboMakeSmall method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void ComboMakeSmall(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
                cc.Size = DinoDiner.Menu.Size.Small;
        }
        /// <summary>
        /// This is the ComboMakeMedium method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void ComboMakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                cc.Size = DinoDiner.Menu.Size.Medium;
        }
        /// <summary>
        /// This is the ComboMakeLarge method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void ComboMakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                cc.Size = DinoDiner.Menu.Size.Large;
        }
        /// <summary>
        /// This returns to the menu
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args"> these are the arguments</param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// This allows you to customize something
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args"> these are the arguments</param>
        public void Customize(object sender, RoutedEventArgs args)
        {
            
            if (DataContext is Order order)
            {
                if (cc.Entree is Brontowurst)
                {
                    NavigationService.Navigate(new BrontowurstCustomization(cc.Entree as Brontowurst));
                }
                if (cc.Entree is DinoNuggets)
                {
                    NavigationService.Navigate(new DinoNuggetsCustomization(cc.Entree as DinoNuggets));
                }
                if (cc.Entree is PrehistoricPBJ)
                {
                    NavigationService.Navigate(new PrehistoricPBJCustomization(cc.Entree as PrehistoricPBJ));
                }
                if (cc.Entree is SteakosaurusBurger)
                {
                    NavigationService.Navigate(new SteakosaurusBurgerCustomization(cc.Entree as SteakosaurusBurger));
                }
                if (cc.Entree is TRexKingBurger)
                {
                    NavigationService.Navigate(new TRexKingBurgerCustomization(cc.Entree as TRexKingBurger));
                }
                if (cc.Entree is VelociWrap)
                {
                    NavigationService.Navigate(new VelociwrapCustomization(cc.Entree as VelociWrap));
                }
            }
        }
    }
}
