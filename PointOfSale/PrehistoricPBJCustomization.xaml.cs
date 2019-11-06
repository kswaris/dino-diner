/* PrehistoricPBJCustomization.xaml.cs
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
    /// Interaction logic for PrehistoricPJBCustomization.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomization : Page
    {
        private PrehistoricPBJ pbj;
        /// <summary>
        /// This is the prehistoricPBJCustomization
        /// </summary>
        public PrehistoricPBJCustomization()
        {
            InitializeComponent();
        }
        /// This is the pbj constructor
        /// <summary>
        /// <param name="p">this is the pbj</param>
        /// </summary>
        public PrehistoricPBJCustomization(PrehistoricPBJ p)
        {
            pbj = p;
            InitializeComponent();
        }
        /// <summary>
        /// This is the jellyclick
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="arsg">This is the routedeventarguments object</param>
        private void JellyClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                    pbj.HoldJelly();
        }
        
        /// <summary>
        /// This is doneclick mehtod.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the routedeventarguments</param>
        private void DoneClick(object sender, RoutedEventArgs args)
        {
                NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// This is the PBClick
        /// </summary>
        /// <param name="sender">The sender is an object</param>
        /// <param name="arsg">This is the routedeventarguments</param>
        private void PBClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                    pbj.HoldPeanutButter();
        }
    }
}
