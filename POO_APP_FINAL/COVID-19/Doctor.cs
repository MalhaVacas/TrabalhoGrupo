using System;
using System.Collections.Generic;
using System.Text;

namespace COVID_19
{
    class Doctor : Citizen
    {
        public Doctor(int doctorLicense, int cc, string name, string email, DateTime dateofbirth, string gender, float wage) : base()
        {
            this.DoctorLicense = doctorLicense;
        }

        /// <summary>
        /// This is the Doctor's number license
        /// </summary>
        public int DoctorLicense { get; set; }

    } 
}
