using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHManager.Classes
{
    public class Employer
    {
        public string EmployerID { get; set; }
        public string EmployerName { get; set; }
        public string EmployerFullName { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerOIB { get; set; }
        public double EmployerHR { get; set; }

        public Employer(string id, string name, string fullName, string address, string oib, string hr)
        {
            EmployerID = id;
            EmployerName = name;
            EmployerFullName = fullName;
            EmployerAddress = address;
            EmployerOIB = oib;
            EmployerHR = hr;
        }
    }
}
