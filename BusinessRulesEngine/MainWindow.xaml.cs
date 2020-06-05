using BusinessRulesEngine.Factory;
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

namespace BusinessRulesEngine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            DDOptions.ItemsSource = new List<string>() { "Book", "PhysicalProduct", "NewMembership", "Upgrade", "Video" }; 
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            OrderFactory orderfactory = new OrderFactory();

            orderfactory.OrderCreation(DDOptions.SelectedItem.ToString());
        }
    }
}
