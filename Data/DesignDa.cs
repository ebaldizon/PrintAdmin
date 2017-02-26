using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DesignDa
    {
        public bool create(Design design)
        {
            try
            {
                DB db = new DB();
                //int bytesDesign = BitConverter.ToInt32(design.design, 0);

                //string hex = BitConverter.ToString(design.design).Replace("-", string.Empty);
                //string hexa = "0x53797374656D2E427974655B5D30";

                /*string misbytes = "";

                for (int i = 0; i < design.design.Length; i++)
                {
                    misbytes += design.design[i].ToString();
                }

                int misOtrosBytes = Int32.Parse(misbytes);*/


                //string query = @"insert into Customers(id, name, telephone1, telephone2, email)values('" + customer.Id + "', '" + customer.Name + "', '" + customer.Telephone1 + "', '" + customer.Telephone2 + "', '" + customer.Email + "')";
                //string query = "insert into Disenios(id, description, design) values("+ design.id +", '"+ design.description + "', "+ misOtrosBytes +")";
                //string query = "insert into Disenios(id, description, design) values(" + design.id + ", '" + design.description + "', CAST('" + design.design + "' as varBinary(MAX)))";

                bool state = db.createFile(design);
                return state; 
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable read(int id)
        {
            try
            {
                DB db = new DB();

                string query = "select * from Disenio where id = (" + id + ")";
                DataTable dt = db.executeReadQuery(query);

                if (dt.Rows[0]["id"].ToString() != "")
                {

                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
