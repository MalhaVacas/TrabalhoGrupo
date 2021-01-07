using System;
using System.Collections.Generic;
using System.Text;

namespace COVID_19
{
    class Citizen
    {
        public Citizen()
        {

        }

        public Citizen(int cc, object cc1, string name, string email, DateTime dateofbirth, string gender)
        {
            this.Cc = cc;
            this.Name = name;
            this.Email = email;
            this.DateOfBirth = dateofbirth;
            this.Gender = gender;


        }

        /// <summary>
        /// This is the citizen number
        /// </summary>
        public int Cc { get; set; }


        /// <summary>
        /// This is the citizen name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This is the citizen email adress
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// This is the Date of Birth os the citizen
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - this.DateOfBirth.Year;

                if (DateTime.Today.DayOfYear < this.DateOfBirth.DayOfYear)
                {
                    age--;
                }
                return age;
            }
        }



        /// <summary>
        /// This is the citizen gender: Female or Male
        /// </summary>
        string Gender { get; set; }
    }
}
