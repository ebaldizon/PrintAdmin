using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CustomerDa
    {
        public bool create(Customer customer)
        {
            try
            {
                DB db = new DB();
                string query = @"insert into Customers(id, name, telephone1, telephone2, email)values('" + customer.Id + "', '" + customer.Name + "', '" + customer.Telephone1 + "', '" + customer.Telephone2 + "', '" + customer.Email + "')";
                return db.executeQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable read(Customer customer)
        {
            try
            {
                DB db = new DB();
                
                string query = "select  * from Customers where (id = ("+ customer.Id +")) or (name like '"+ customer.Name +"') or (telephone1 =("+ customer.Telephone1+")) or (telephone2 =("+ customer.Telephone2 +")) or (email =('"+ customer.Email+"'))";
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

        public DataTable readForId(long id)
        {
            try
            {
                DB db = new DB();

                string query = "select * from Customers where id = ("+ id +")";
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

        public bool update(Customer customer)
        {
            try
            {
                DB db = new DB();
                db.connection();
                string query = "update Customers set name = '" + customer.Name + "', telephone1 = (" + customer.Telephone1 + "), telephone2 = (" + customer.Telephone2 + "), email = '" + customer.Email + "' where id = (" + customer.Id + ")";
                return db.executeQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(Customer customer)
        {
            try
            {
                DB db = new DB();
                string query = "DELETE FROM Customers WHERE id = (" + customer.Id + ")" +
                    "AND (name LIKE '" + customer.Name + "')" +
                    "AND (telephone1 = (" + customer.Telephone1 + "))" +
                    "AND (telephone2 = (" + customer.Telephone2 + "))" +
                    "AND (email LIKE '" + customer.Email + "')";

                return db.executeQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable listCustomers()
        {
            try
            {
                DB db = new DB();
                string query = "select * from Customers";
                DataTable dt = db.executeReadQuery(query);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
