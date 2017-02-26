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
    public class DB
    {
        public SqlConnection con { get; set; }
        public string dataSource = "Data Source=DESKTOP-MV2TBFL\\SQLEXPRESS;Initial Catalog=IMPRENTA-LIBERIA;Integrated Security=true;";

      
        public void connection()
        {
            this.con = new SqlConnection();
            this.con.ConnectionString = dataSource;
        } 

        public bool executeQuery(string query)
        {
            connection();
            SqlCommand cmd = new SqlCommand(query, this.con);
            try
            {
                this.con.Open();
                int result = cmd.ExecuteNonQuery();
                this.con.Close();
                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public DataTable executeReadQuery(string query)
        {
            connection();
            SqlCommand cmd = new SqlCommand(query, this.con);
            this.con.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.con.Close();
                return dt;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public bool createFile(Design design)
        {
            connection();
            try
            {
                string sql = "INSERT INTO Disenio (id, description, design) VALUES (@id, @description, @design)";
                SqlCommand cmd = new SqlCommand(sql, this.con);
                cmd.CommandType = CommandType.Text;

                //cmd.Parameters.AddWithValue("@id", design.id);
                //cmd.Parameters.AddWithValue("@description", design.description);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = design.id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = design.description;
                cmd.Parameters.Add(new SqlParameter("@design", SqlDbType.VarBinary, design.design.Length)).Value = design.design;

                //cmd.Parameters.AddWithValue("@design", "0x" + BitConverter.ToString(design.design).Replace("-", ""));
                //cmd.CommandType = CommandType.Text;

                this.con.Open();
                int result = cmd.ExecuteNonQuery();
                this.con.Close();

                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public bool readFile(Design design)
        {
            connection();

            try
            {
                string sql = "INSERT INTO Disenio (id, description, design) VALUES (@id, @description, @design)";
                SqlCommand cmd = new SqlCommand(sql, this.con);
                cmd.CommandType = CommandType.Text;

                //cmd.Parameters.AddWithValue("@id", design.id);
                //cmd.Parameters.AddWithValue("@description", design.description);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = design.id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = design.description;
                cmd.Parameters.Add(new SqlParameter("@design", SqlDbType.VarBinary, design.design.Length)).Value = design.design;

                //cmd.Parameters.AddWithValue("@design", "0x" + BitConverter.ToString(design.design).Replace("-", ""));
                //cmd.CommandType = CommandType.Text;

                this.con.Open();
                int result = cmd.ExecuteNonQuery();
                this.con.Close();

                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                return false;
            }
        }

    }
}
