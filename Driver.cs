using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_work_PDD
{
    public class Driver
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DriverLicense { get; set; }
        public string FullName { get; set; }

        public Driver(string surname, string name, string lastname, DateTime dateofbirth, string driverLicense)
        {
            Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(surname); ;
            Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name); ;
            Lastname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastname); ;
            DateOfBirth = dateofbirth;
            DriverLicense = driverLicense;
            if(!string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Lastname) && !string.IsNullOrEmpty(driverLicense))
            {
                FullName = $"{Surname} {Name.First().ToString().ToUpper()}.{Lastname.First().ToString().ToUpper()}.";
            }
        }
    }
}
