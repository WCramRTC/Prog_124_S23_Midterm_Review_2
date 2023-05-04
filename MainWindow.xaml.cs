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

namespace Prog_124_S23_Midterm_Review_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbVehicle.ItemsSource = Data.Vehicle;
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int numberOfVehicle = Data.Vehicle.Count;

        }

        private void btnAddNewVehicle_Click(object sender, RoutedEventArgs e)
        {
            // Now to open a new window
            
            // Creating a new instance of our second page
            AddVehiclePage vehiclePage = new AddVehiclePage();

            // To open it we call the .show method
            vehiclePage.Show();

            //new AddVehiclePage().Show();

        }

        private void cbVehicle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int selectedVehicle = cbVehicle.SelectedIndex;

            //Vehicle selected = Data.Vehicle[selectedVehicle];

            Vehicle selected = (Vehicle)cbVehicle.SelectedItem;


            txtMake.Text = selected.Make;
            txtType.Text = selected.GetType().Name;

        }
    } // class

} // namespace
