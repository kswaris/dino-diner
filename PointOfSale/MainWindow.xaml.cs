/* MainWindow.xaml.cs
 * Author: nathan Bean
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
        }
        private void PassOnDataContext()
        {
            Page page = (Page)OrderUI.Content;
            if(page != null)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }
        /// <summary>
        /// OnloadComplete
        /// </summary>
        /// <param name="sender">sender variable</param>
        /// <param name="e">e argment</param>
        public void OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            PassOnDataContext();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassOnDataContext();
        }
    }
}
