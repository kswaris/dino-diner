/* VelociwrapCustomization.xaml.cs
 * Author:Sam Waris
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
    /// Interaction logic for VelociwrapCustomization.xaml
    /// </summary>
    public partial class VelociwrapCustomization : Page
    {
        private VelociWrap vw;
        private CretaceousCombo cc;
        /// <summary>
        /// This is the velociwrap constructors
        /// </summary>
        public VelociwrapCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the velociwrap customization
        /// </summary>
        /// <param name="cc">This is the combo</param>
        public void VelociWrapCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.vw = cc.Entree as VelociWrap;
        }
        /// <summary>
        /// This is the velocirap constructor
        /// </summary>
        /// <param name="tr">this is the trex</param>
        public VelociwrapCustomization(VelociWrap v)
        {
            vw = v;
            InitializeComponent();
        }
        private void LettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                    velociwrap.HoldLettuce();
            if (cc != null)
            {
                vw.HoldLettuce();
                cc.Entree = vw;
            }
        }
        private void CheeseClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                    velociwrap.HoldCheese();
            if (cc != null)
            {
                vw.HoldCheese();
                cc.Entree = vw;
            }
        }
        private void DressingClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap velociwrap)
                    velociwrap.HoldDressing();
            if (cc != null)
            {
                vw.HoldDressing();
                cc.Entree = vw;
            }
        }
        /// <summary>
        /// This is the done click method
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the argument</param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
                NavigationService.Navigate(new CustomizeCombo(cc));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
