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
using System.Windows.Shapes;

namespace Prog_124_S23_Midterm_Review_2
{
    /// <summary>
    /// Interaction logic for AddVehiclePage.xaml
    /// </summary>
    public partial class AddVehiclePage : Window
    {
        public AddVehiclePage()
        {
            InitializeComponent();

            // Connecting my static Observable Collection DIRECTLY to the list box
            lbVehicles.ItemsSource = Data.Vehicle;
            
            
        }

        // I have my gui to get a make
        // I need to make an instance of a vehicle type
        // Add it to my data list
        // Display to the list box


        private void btnCar_Click(object sender, RoutedEventArgs e)
        {
            // I Know THIS works for car
            string make = txtMake.Text;
            Car newCar = new Car(make);
            Data.AddVehicle(newCar);
        }

        private void btnBoat_Click(object sender, RoutedEventArgs e)
        {
            // I Know THIS works for car
            string make = txtMake.Text;
            Boat newBoat = new Boat(make);
            Data.AddVehicle(newBoat);
        }

        private void btnPlane_Click(object sender, RoutedEventArgs e)
        {
            // I Know THIS works for car
            string make = txtMake.Text;
            Plane newPlane = new Plane(make);
            Data.AddVehicle(newPlane);
        }

        // The next result I want

    }
}
