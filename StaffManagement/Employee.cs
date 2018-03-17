using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement
{
    public class Employee : Staff
    {
        public int WorkDay { get; set; }
        public int Allowance { get; set; }
    }
}
