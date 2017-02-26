using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserDa
    {
        public bool create(User user)
        {
            try
            { 
                DB db = new DB();
                string query = @"insert into Users(id, name, lastname, email, password)values('"+ user.Id+"', '"+ user.Name+"', '"+ user.Lastname+"', '"+user.Mail+"', '"+user.Password+"')";
                return db.executeQuery(query);
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public DataTable read(User readUser)
        {
            try
            {
                DB db = new DB();
                string query = "select * from Users where id = (" + readUser.Id + ")" + 
                    "OR (name LIKE '" + readUser.Name + "')"+
                    "OR (lastname LIKE '" + readUser.Lastname + "')" +
                    "OR (email LIKE '" + readUser.Mail + "')" +
                    "OR (password LIKE '" + readUser.Password + "')";

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

        public bool update(User user)
        {
            try
            {
                DB db = new DB();
                db.connection();
                string query = "update Users set name = '" + user.Name + "', lastname = '"+ user.Lastname +"', email = '"+ user.Mail +"', password = '"+ user.Password +"' where id = ("+ user.Id +")";
                return db.executeQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(User readUser)
        {
            try
            {
                DB db = new DB();
                string query = "DELETE FROM Users WHERE id = (" + readUser.Id + ")" +
                    "AND (name LIKE '" + readUser.Name + "')" +
                    "AND (lastname LIKE '" + readUser.Lastname + "')" +
                    "AND (email LIKE '" + readUser.Mail + "')" +
                    "AND (password LIKE '" + readUser.Password + "')";

                return db.executeQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable listUsers()
        {
            try
            {
                DB db = new DB();
                string query = "select * from Users";
                DataTable dt = db.executeReadQuery(query);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool login(User user)
        {
            try
            {
                DB db = new DB();
                string query = "select * from Users where id = ("+ user.Id +") and password = '"+ user.Password +"'";

                DataTable dt = db.executeReadQuery(query);

                if (dt.Rows[0]["id"].ToString() != "")
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
