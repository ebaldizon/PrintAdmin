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
        public int Number { get; set; }
        public DateTime DateOrder { get; set; }
        public long CustomerID { get; set; }
        public DateTime DateDelivery { get; set; }
        public string DeliveredBy { get; set; }
        public string WorkType { get; set; }
        public string Computer { get; set; }
        public bool Iron { get; set; }
        public bool Paper { get; set; }
        public string Quantity { get; set; }
        public string Ink { get; set; }
		public string Sheets { get; set; }
        public string Trait1 { get; set; }
        public string Trait2 { get; set; }
        public string Trait3 { get; set; }
        public string Trait4 { get; set; }
        public string Trait5 { get; set; }
        public string Trait6 { get; set; }
        public string Size { get; set; }
        public string Glued { get; set; }
        public string Perforated { get; set; }
		public string Changes { get; set; }
        public string Holes { get; set; }
        public int InitialNum { get; set; }
        public int EndNum { get; set; }
        public string Observations { get; set; }
        public Byte[] Design { get; set; }
        public string NameDesign { get; set; }
        public float Price { get; set; }
        public float Payment { get; set; }
        public float Balance { get; set; }

        public void Fill()
        {
            this.Number = 1;
            this.DateOrder = new DateTime(2008, 3, 1, 7, 0, 0);
            this.CustomerID = 0;
            this.DateDelivery = new DateTime(2008, 3, 1, 7, 0, 0);
            this.DeliveredBy = "";
            this.WorkType = "";
            this.Computer = "";
            this.Iron = false;
            this.Paper =false;
            this.Quantity = "";
            this.Ink = "";
            this.Sheets = "";
            this.Trait1 = "";
            this.Trait2 = "";
            this.Trait3 = "";
            this.Trait4 = "";
            this.Trait5 = "";
            this.Trait6 = "";
            this.Size = "";
            this.Glued = "";
            this.Perforated = "";
            this.Changes = "";
            this.Holes = "";
            this.InitialNum = 0;
            this.EndNum = 0;
            this.Observations = "";
            this.Design = null;
            this.NameDesign = "";
            this.Price = 0;
            this.Payment = 0;
            this.Balance = 0;
        }
    }
}
