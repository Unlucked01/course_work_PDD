using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_work_PDD
{
    public class Bill
    {
        public string Fullname;
        public string VehicleDescription;
        public string Reason;
        public decimal Amount;

        public Bill(string fullName, string description, string reason, decimal amount)
        {
            Fullname = fullName;
            VehicleDescription = description;
            Reason = reason;
            Amount = amount;
        }
    }
}
