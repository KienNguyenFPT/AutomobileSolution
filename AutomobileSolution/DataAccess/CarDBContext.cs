using AutomobileSolution.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileSolution.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car
            {
                CarID = 1,
                CarName = "LV",
                Manufacturer = "Honda",
                Price = 30000,
                ReleaseYear = 2021
            },
            new Car
            {
                CarID = 2,
                CarName = "Yamaha",
                Manufacturer = "Ford",
                Price = 3000000,
                ReleaseYear = 2020

            }
        };

        private static CarDBContext instance = null;
        public static readonly object instanceLook = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {

            }
        }
    }
}
