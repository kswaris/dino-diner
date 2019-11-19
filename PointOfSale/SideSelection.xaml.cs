/*SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private CretaceousCombo combo;
        private Side _side;
        /// <summary>
        /// This is the order variable
        /// </summary>
        public Order order = new Order();
        /// <summary>
        /// This is the sideselection method.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the side selection method.
        /// </summary>
        /// <param name="cc">this is the combo you're using.</param>
        public SideSelection(CretaceousCombo cc)
        {
            combo = cc;
            InitializeComponent();
        }
        /// <summary>
        /// Adds fryceritops
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void FryceritopsClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                _side = new Fryceritops();
                if (combo == null)
                {
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    combo.Side = _side;
                }
            }
        }
        /// <summary>
        /// Adds MeteorMacAndCheese
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void MeteorMacAndCheeseClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                _side = new MeteorMacAndCheese();
                if(combo == null)
                {
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    combo.Side = _side;
                }
            }
        }
        /// <summary>
        /// Adds Mezzorella Sticks
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void MezzorellaSticksClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                _side = new MezzorellaSticks();
                if (combo == null)
                {
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    combo.Side = _side;
                }
            }
        }
        /// <summary>
        /// Adds Triceritots
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void Triceritots(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                _side = new Triceritots();
                if (combo == null)
                {
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    combo.Side = _side;
                }
            }
        }
        /// <summary>
        /// This is sidemakesmall. This makes the side small.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void SideMakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    _side.Size = DinoDiner.Menu.Size.Small;
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
                else
                {
                    combo.Side.Size = DinoDiner.Menu.Size.Small;
                    NavigationService?.Navigate(new CustomizeCombo());
                }
            }
        }
        /// <summary>
        /// This is sidemakemedium. This makes the side medium.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void SideMakeMedium(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (combo == null)
                {
                    _side.Size = DinoDiner.Menu.Size.Medium;
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
                else
                {
                    combo.Side.Size = DinoDiner.Menu.Size.Medium;
                    NavigationService?.Navigate(new CustomizeCombo());
                }
            }
        }
        /// <summary>
        /// This is sidemakeLarge. This makes the side Large.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void SideMakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    _side.Size = DinoDiner.Menu.Size.Large;
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
                else
                {
                    combo.Side.Size = DinoDiner.Menu.Size.Large;
                    NavigationService?.Navigate(new CustomizeCombo());
                }
            }
        }
        /// <summary>
        /// Alternative Constructor
        /// </summary>
        /// <param name="side">Side</param>
        public SideSelection(Side side)
        {
            _side = side;
            InitializeComponent();
        }
    }
}
