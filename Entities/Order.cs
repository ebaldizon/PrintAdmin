using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        DateTime Date { get; set; }
        int Id { get; set; }
        DateTime Delivery { get; set; }
        string DeliveredBy { get; set; }
        string Computer { get; set; }
        bool Type { get; set; }
        int Quantity { get; set; }
        string Ink { get; set; }
        ArrayList Numbers { get; set; }
        string Size { get; set; }
        string Glued { get; set; }
        string Perforated { get; set; }
        string Hole { get; set; }
        int InitialNum { get; set; }
        int EndNum { get; set; }
        string observations { get; set; }
        string PSDFILE { get; set; }
    }
}
