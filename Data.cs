using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_S23_Midterm_Review_2
{
    static class Data
    {
        // We are switching from List to ObservableCollection
        static ObservableCollection<Vehicle> _vehicle;

        // I want my vehicle list to be instantiated only when called

        // static constructor
        static Data()
        {
            _vehicle = new ObservableCollection<Vehicle>();
            Preload();
        }

        private static void Preload()
        {
            _vehicle.Add(new Car("Honda"));
            _vehicle.Add(new Car("Toyta"));
            _vehicle.Add(new Car("Hyundai"));
            _vehicle.Add(new Plane("Ford"));
            _vehicle.Add(new Boat("Buick"));
        }

        internal static ObservableCollection<Vehicle> Vehicle { get => _vehicle;  }

        public static void AddVehicle(Vehicle vehicle)
        {
            _vehicle.Add(vehicle);
        }

    }
}
