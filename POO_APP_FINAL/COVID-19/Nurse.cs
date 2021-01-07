using System;
using System.Collections.Generic;
using System.Text;

namespace COVID_19
{
    class Nurse: Citizen
    {
        public Nurse (int nurseLicense, int cc, string name, string email, DateTime dateofbirth, string gender,float wage) : base()
        {
            this.NurseLicense = nurseLicense;
        }

        /// <summary>
        /// This is the Nurse's number license
        /// </summary>
        public int NurseLicense { get; set; }

        
    }
}
