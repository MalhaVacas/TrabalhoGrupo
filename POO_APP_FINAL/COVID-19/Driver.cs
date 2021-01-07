using System;
using System.Collections.Generic;
using System.Text;

namespace COVID_19
{
    class Driver: Citizen
    {
        public Driver(int driverLicense, string driverCategory,int cc, string name, string email, DateTime dateofbirth, string gender, float wage): base()
        {
            this.DriverLicense = driverLicense;
            this.DriverCategory = driverCategory;

        }

        /// <summary>
        /// Este é o numero da carta de condução do motorista
        /// </summary>
        public int DriverLicense { get; set; }

        /// <summary>
        /// This is the category of a vehicule that can be driven by the driver
        /// </summary>
        public string DriverCategory { get; set; }


    }
}
