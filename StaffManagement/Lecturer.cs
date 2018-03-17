using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement
{
    public class Lecturer : Staff
    {
        public int ExpectedPeriod { get; set; }
        public int ActualPeriod { get; set; }
    }
}
