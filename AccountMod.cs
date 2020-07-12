using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class AccountMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();


        public bool AddData(string name, string pw)  //thêm tài khoản
        {
            cmd.CommandText = "Insert into Account values ('" + name + "','" + pw + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool GetID(string name, string pw)  //lấy tên đăng nhập
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select matt from thuthu where matt = '" + name + "' and matkhau = '" + pw + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
            }
            return false;
        }

        public DataTable GetTen(string name)  //lấy tên đăng nhập
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select tentt from thuthu where matt = '" + name + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    return dt;
            }
            catch (Exception ex)
            {
                dt = null;
                string mex = ex.Message;
            }
            return dt;
        }
    }
}