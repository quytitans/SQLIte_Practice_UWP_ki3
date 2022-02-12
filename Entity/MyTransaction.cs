using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMoneyApp.Entity
{
    public class MyTransaction
    {
        public string name { get; set; }
        public double money { get; set; }
        public DateTime datepay { get; set; }
        public string category  { get; set; }
    }
}
