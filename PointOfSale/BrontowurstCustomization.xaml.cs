/* BrontowurstCustomization.xaml.cs
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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private Brontowurst bw;
        /// <summary>
        /// This is the brontowusrt construcotr
        /// </summary>
        public BrontowurstCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the brontowurst constructor
        /// </summary>
        /// <param name="b">this is the wurst</param>
        public BrontowurstCustomization(Brontowurst b)
        {
            bw = b;
            InitializeComponent();
        }
        private void PepperClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
               bw.HoldPeppers();
        }
        private void BunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                bw.HoldBun();
        }
        private void OnionClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                bw.HoldOnion();
        }
        private void DoneClick(object sender, RoutedEventArgs arsg)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
