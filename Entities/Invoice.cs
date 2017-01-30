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
        int Number { get; set; }
        int Id { get; set; }
        ArrayList Orders { get; set; }
        double Subtotal { get; set; }
        double Tax { get; set; }
        double Total { get; set; }
    }
}
