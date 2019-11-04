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
        /// <param name="cc">this is the combo</param>
        public CustomizeCombo(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
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
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// This is the todrinks method, it takes you to drinks
        /// </summary>
        /// <param name="Sender">This is the sender object</param>
        /// <param name="e">This is the argument object</param>
        private void ToDrinks(object Sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// This is the ComboMakeSmall method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void ComboMakeSmall(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    combo.Size = DinoDiner.Menu.Size.Small;
        }
        /// <summary>
        /// This is the ComboMakeMedium method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void ComboMakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    combo.Size = DinoDiner.Menu.Size.Medium;
        }
        /// <summary>
        /// This is the ComboMakeLarge method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void ComboMakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
