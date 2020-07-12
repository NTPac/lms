using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class SachMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()  //lấy dữ liệu
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select mas,anh,tens,theloai,tenTG,namxb,nhaxb from Sach";
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

        public bool AddData(string maS, string tenS, string theLoai, string tenTG, string nhaXB, string namXB, string image, string sl, string dg, string vt, string review ) //them du lieu
        {
            cmd.CommandText = "Insert into Sach(maS,tenS,theLoai,tenTG,nhaXB,namXB,anh,sl,dg,vt,reView) values ('" + maS + "',N'" + tenS + "',N'" + theLoai + "',N'" + tenTG + "',N'" + nhaXB + "','" + namXB + "','" + image + "'," + sl + "," + dg + ",'" + vt + "',N'" + review + "')";
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

            //chưa sửa

        public bool UpdData(string ten, string theloai, string tenTG, string namxb,string nhaxb,string anh,string sl, string dg,string vt,string review,string id) //sua du lieu
        {
            cmd.CommandText = "Update sach set tens = N'" + ten + "', theloai = '"+ theloai + "', tentg = '"+tenTG+ "', namxb = '" + namxb + "', nhaxb = '" + nhaxb + "', anh = '" + anh + "', sl = '" + sl + "', dg = '" + dg + "', vt = '" + vt + "', review = '" + review + "' where mas = '" + id+"'";
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
        public bool UpdDatatl(string ten, string id) //sua du lieu
        {
            cmd.CommandText = "Update theloai set "+ ten+" where mas = '" + id + "'";
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
            cmd.CommandText = "Delete from sach Where mas = '" + ma + "'";
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

        public bool DelDatatl(string ma) //xoa du lieu
        {
            cmd.CommandText = "Delete from theloai Where mas = '" + ma + "'";
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

        public DataTable searchData(string id) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from sach where maS = '"+id+"'";
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

        public DataTable searchData(string tc,string id) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from sach where "+tc+" like '%" + id + "%'";
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

        public DataTable searchDataten(string id) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from sach where tens like '%" + id + "%'";
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

        public DataTable xemcts(string id) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from muonsach where maS = '" + id + "' and trangthai = 'dang muon' ";
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

        public bool AddDataTL(string maS, string review) //them du lieu
        {
            cmd.CommandText = "Insert into theloai(mas,hanhdong,nguoilon,phieuluu,haihuoc,drama,fantasy,lichsu,congai,contrai,kinhdi,tragedy,bian,trinhtham,giatgan,lanman,lightnovel,sachht,sachtch) values ('" + maS + "'," + review + ",'False')";
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

        public DataTable searchDatatl(string id) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from theloai where maS = '" + id + "'";
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

        public DataTable searchDataNC(string x) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from sach , theloai where "+x;
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