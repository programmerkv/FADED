using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement
{
    public abstract class Staff
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public double CoefficientPay { get; set; }
        public bool Gender { get; set; }
    }
}
