using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrderDa
    {
        public bool create(Order order)
        {
            DB db = new DB();

            db.connection();

            try
            {
                string sql = "INSERT INTO Orders (number, dateOrder, customerID, dateDelivery, deliveredBy, workType, computer, iron, paper, quantity, ink, sheets, trait1, trait2, trait3, trait4, trait5, trait6, size, glued, perforated, changes, holes, initialNum, endNum, observations, nameDesign, design, price, payment, balance)" +
                             "VALUES (@number, @dateOrder, @customerID, @dateDelivery, @deliveredBy, @workType, @computer, @iron, @paper, @quantity, @ink, @sheets, @trait1, @trait2, @trait3, @trait4, @trait5, @trait6, @size, @glued, @perforated, @changes, @holes, @initialNum, @endNum, @observations, @nameDesign, @design, @price, @payment, @balance)";

                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@number", SqlDbType.Int).Value = order.Number;
                cmd.Parameters.Add("@dateOrder", SqlDbType.Date).Value = order.DateOrder;
                cmd.Parameters.Add("@customerID", SqlDbType.BigInt).Value = order.CustomerID;
                cmd.Parameters.Add("@dateDelivery", SqlDbType.Date).Value = order.DateDelivery;
                cmd.Parameters.Add("@deliveredBy", SqlDbType.VarChar).Value = order.DeliveredBy;
                cmd.Parameters.Add("@workType", SqlDbType.VarChar).Value = order.WorkType;
                cmd.Parameters.Add("@computer", SqlDbType.VarChar).Value = order.Computer;
                cmd.Parameters.Add("@iron", SqlDbType.Bit).Value = order.Iron;
                cmd.Parameters.Add("@paper", SqlDbType.Bit).Value = order.Paper;
                cmd.Parameters.Add("@quantity", SqlDbType.VarChar).Value = order.Quantity;
                cmd.Parameters.Add("@ink", SqlDbType.VarChar).Value = order.Ink;
                cmd.Parameters.Add("@sheets", SqlDbType.VarChar).Value = order.Sheets;
                cmd.Parameters.Add("@trait1", SqlDbType.VarChar).Value = order.Trait1;
                cmd.Parameters.Add("@trait2", SqlDbType.VarChar).Value = order.Trait2;
                cmd.Parameters.Add("@trait3", SqlDbType.VarChar).Value = order.Trait3;
                cmd.Parameters.Add("@trait4", SqlDbType.VarChar).Value = order.Trait4;
                cmd.Parameters.Add("@trait5", SqlDbType.VarChar).Value = order.Trait5;
                cmd.Parameters.Add("@trait6", SqlDbType.VarChar).Value = order.Trait6;
                cmd.Parameters.Add("@size", SqlDbType.VarChar).Value = order.Size;
                cmd.Parameters.Add("@glued", SqlDbType.VarChar).Value = order.Glued;
                cmd.Parameters.Add("@perforated", SqlDbType.VarChar).Value = order.Perforated;
                cmd.Parameters.Add("@changes", SqlDbType.VarChar).Value = order.Changes;
                cmd.Parameters.Add("@holes", SqlDbType.VarChar).Value = order.Holes;
                cmd.Parameters.Add("@initialNum", SqlDbType.VarChar).Value = order.InitialNum;
                cmd.Parameters.Add("@endNum", SqlDbType.VarChar).Value = order.EndNum;
                cmd.Parameters.Add("@observations", SqlDbType.VarChar).Value = order.Observations;
                cmd.Parameters.Add("@nameDesign", SqlDbType.VarChar).Value = order.NameDesign;
                cmd.Parameters.Add(new SqlParameter("@design", SqlDbType.VarBinary, order.Design.Length)).Value = order.Design;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = order.Price;
                cmd.Parameters.Add("@payment", SqlDbType.Float).Value = order.Payment;
                cmd.Parameters.Add("@balance", SqlDbType.Float).Value = order.Balance;

                db.con.Open();
                int result = cmd.ExecuteNonQuery();
                db.con.Close();

                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public DataTable readForCustomerID(Order order)
        {
            try
            {
                 DB db = new DB();

                 string query = "select number, dateOrder, customerID, (select name from Customers where id = customerID) as customerName, dateDelivery, deliveredBy, workType, initialNum, endNum, nameDesign  from Orders where customerID = (" + order.CustomerID +")";
                 DataTable dt = db.executeReadQuery(query);

                 if (dt.Rows[0]["number"].ToString() != "")
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

        public DataTable readForCustomerIDInv(Order order)
        {
            try
            {
                DB db = new DB();

                string query = "select number, dateOrder, customerID, (select name from Customers where id = customerID) as name, workType, initialNum, endNum,price, payment, balance from Orders where customerID = (" + order.CustomerID + ")";
                DataTable dt = db.executeReadQuery(query);

                if (dt.Rows[0]["number"].ToString() != "")
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

        public DataTable readForNumber(int number)
        {
            try
            {
                DB db = new DB();

                string query = "select * from Orders where number = (" + number + ")";
                DataTable dt = db.executeReadQuery(query);

                if (dt.Rows[0]["number"].ToString() != "")
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


        public DataTable listOrders()
        {
            try
            {
                DB db = new DB();
                string query = "select number, dateOrder, customerID, (select name from Customers where id = customerID) as customerName, dateDelivery, deliveredBy, workType, initialNum, endNum, nameDesign  from Orders";
                DataTable dt = db.executeReadQuery(query);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable listOrdersInvoice()
        {
            try
            {
                DB db = new DB();
                string query = "select number, dateOrder, customerID, (select name from Customers where id = customerID) as name, workType, initialNum, endNum,price, payment, balance from Orders";
                DataTable dt = db.executeReadQuery(query);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable ultimateOrder()
        {

            try
            {
                DB db = new DB();
                string query = "select number from Orders ORDER BY number DESC";

                DataTable dt = db.executeReadQuery(query);

                if (dt.Rows[0]["number"].ToString() != "")
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

        public bool update(Order order)
        {
            DB db = new DB();

            db.connection();

            try
            {

                string sql = "update Orders set dateOrder = @dateOrder, customerID = @customerID, dateDelivery = @dateDelivery, deliveredBy = @deliveredBy, workType = @workType, computer = @computer, iron = @iron, paper = @paper, quantity = @quantity,"+
                    "ink = @ink, sheets = @sheets, trait1 = @trait1, trait2 = @trait2, trait3 = @trait3, trait4 = @trait4, trait5 = @trait5, trait6 = @trait6, size = @size, glued = @glued, perforated = @perforated, changes = @changes, holes = @holes, initialNum = @initialNum,"+
                    "endNum = @endNum, observations = @observations, nameDesign = @nameDesign, design = @design, price = @price, payment = @payment, balance = @balance where number = @number";
  
                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@number", SqlDbType.Int).Value = order.Number;
                cmd.Parameters.Add("@dateOrder", SqlDbType.Date).Value = order.DateOrder;
                cmd.Parameters.Add("@customerID", SqlDbType.BigInt).Value = order.CustomerID;
                cmd.Parameters.Add("@dateDelivery", SqlDbType.Date).Value = order.DateDelivery;
                cmd.Parameters.Add("@deliveredBy", SqlDbType.VarChar).Value = order.DeliveredBy;
                cmd.Parameters.Add("@workType", SqlDbType.VarChar).Value = order.WorkType;
                cmd.Parameters.Add("@computer", SqlDbType.VarChar).Value = order.Computer;
                cmd.Parameters.Add("@iron", SqlDbType.Bit).Value = order.Iron;
                cmd.Parameters.Add("@paper", SqlDbType.Bit).Value = order.Paper;
                cmd.Parameters.Add("@quantity", SqlDbType.VarChar).Value = order.Quantity;
                cmd.Parameters.Add("@ink", SqlDbType.VarChar).Value = order.Ink;
                cmd.Parameters.Add("@sheets", SqlDbType.VarChar).Value = order.Sheets;
                cmd.Parameters.Add("@trait1", SqlDbType.VarChar).Value = order.Trait1;
                cmd.Parameters.Add("@trait2", SqlDbType.VarChar).Value = order.Trait2;
                cmd.Parameters.Add("@trait3", SqlDbType.VarChar).Value = order.Trait3;
                cmd.Parameters.Add("@trait4", SqlDbType.VarChar).Value = order.Trait4;
                cmd.Parameters.Add("@trait5", SqlDbType.VarChar).Value = order.Trait5;
                cmd.Parameters.Add("@trait6", SqlDbType.VarChar).Value = order.Trait6;
                cmd.Parameters.Add("@size", SqlDbType.VarChar).Value = order.Size;
                cmd.Parameters.Add("@glued", SqlDbType.VarChar).Value = order.Glued;
                cmd.Parameters.Add("@perforated", SqlDbType.VarChar).Value = order.Perforated;
                cmd.Parameters.Add("@changes", SqlDbType.VarChar).Value = order.Changes;
                cmd.Parameters.Add("@holes", SqlDbType.VarChar).Value = order.Holes;
                cmd.Parameters.Add("@initialNum", SqlDbType.VarChar).Value = order.InitialNum;
                cmd.Parameters.Add("@endNum", SqlDbType.VarChar).Value = order.EndNum;
                cmd.Parameters.Add("@observations", SqlDbType.VarChar).Value = order.Observations;
                cmd.Parameters.Add("@nameDesign", SqlDbType.VarChar).Value = order.NameDesign;
                cmd.Parameters.Add(new SqlParameter("@design", SqlDbType.VarBinary, order.Design.Length)).Value = order.Design;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = order.Price;
                cmd.Parameters.Add("@payment", SqlDbType.Float).Value = order.Payment;
                cmd.Parameters.Add("@balance", SqlDbType.Float).Value = order.Balance;

                db.con.Open();
                int result = cmd.ExecuteNonQuery();
                db.con.Close();

                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public bool updateInvoice(Order order)
        {
            DB db = new DB();

            db.connection();

            try
            {

                string sql = "update Orders set price = @price, payment = @payment, balance = @balance where number = @number";

                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = order.Price;
                cmd.Parameters.Add("@payment", SqlDbType.Float).Value = order.Payment;
                cmd.Parameters.Add("@balance", SqlDbType.Float).Value = order.Balance;
                cmd.Parameters.Add("@number", SqlDbType.Int).Value = order.Number;

                db.con.Open();
                int result = cmd.ExecuteNonQuery();
                db.con.Close();

                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public bool delete(int number)
        {
            try
            {
                DB db = new DB();
                string query = "DELETE FROM Orders WHERE number = ("+ number +")";

                return db.executeQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
