using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int Number { get; set; }
        public int Id { get; set; }
        public ArrayList Orders { get; set; }
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
    }
}
