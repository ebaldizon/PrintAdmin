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
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public DateTime Delivery { get; set; }
        public string DeliveredBy { get; set; }
        public string Computer { get; set; }
        public bool Type { get; set; }
        public int Quantity { get; set; }
        public string Ink { get; set; }
        public ArrayList Numbers { get; set; }
        public string Size { get; set; }
        public string Glued { get; set; }
        public string Perforated { get; set; }
        public string Hole { get; set; }
        public int InitialNum { get; set; }
        public int EndNum { get; set; }
        public string observations { get; set; }
        public string PSDFILE { get; set; }
    }
}
