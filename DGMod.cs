using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class DGMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()  //lấy dữ liệu
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select maDG, ht from DocGia";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(string madg,string cmnd, string ht, string gt, string ns, string qq, string nn, string chooht, string sdt, string anh) //them du lieu
        {
            cmd.CommandText = "Insert into DocGia(madg,cmnd,ht,gt,ns,qq,nn,chooht,sdt,anh) values (N'" + madg + "',N'" + cmnd + "',N'" + ht + "',N'" + gt + "','"+ ns +"',N'"+ qq + "',N'" + nn + "',N'" + chooht + "','" + sdt + "','" + anh + "')";
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

        public bool UpdData(string ten, string loai, string soluong, string mota, string usercapnhap, int id) //sua du lieu
        {
            cmd.CommandText = "Update thuviensv set ten = N'" + ten + "',loai = N'" + loai + "',soluong = N'" + soluong + "', mota = N'" + mota + "',usercapnhap ='" + usercapnhap + "' where id =" + id;
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

        public bool DelData(string ma) //xoa du lieu
        {
            cmd.CommandText = "Delete from docgia Where madg = '" + ma + "'";
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

        public DataTable searchData(string ten) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from docgia where madg = '" + ten + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public DataTable searchDatamuon(string ten) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from muonsach where madg = '" + ten + "' and trangthai = 'dang muon'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
    }
}