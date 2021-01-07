using System;
using System.Collections.Generic;
using System.Text;

namespace COVID_19
{
   abstract class Staff : Citizen
    {
       

        public Staff(int cc, string name, string email, DateTime dateofbirth, string gender,float wage) : base ()
        { 
            this.Wage = wage;
        }

        public float Wage { get; set; }
    }

}
    

    

