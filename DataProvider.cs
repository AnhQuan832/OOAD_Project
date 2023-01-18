using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OOAD_Project
{
    internal class DataProvider
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public static string connecstring;

        public string Connecstring
        {
            get { return connecstring; }
            set { connecstring = value; }
        }

        public void Connect_provider()
        {
            try
            {
                cn = new SqlConnection(Connecstring);
                cn.Open();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Disconnect_provider()
        {
            cn.Close();
            cn.Dispose();
        }

        public DataTable TakeData(string SQLComand)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SQLComand, cn);
            da.Fill(tbl);
            return tbl;
        }

        public DataTable DataWithCondition(string strStore, string Table, string Condition)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TABLE", SqlDbType.NVarChar).Value = Table;
                cmd.Parameters.Add("@CONDITION", SqlDbType.NVarChar).Value = Condition;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string strStore, string Table, string Condition)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TABLE", SqlDbType.NVarChar).Value = Table;
                cmd.Parameters.Add("@CONDITION", SqlDbType.NVarChar).Value = Condition;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(string strStore, string Table, string Condition, DataTable tbl)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TABLE", SqlDbType.NVarChar).Value = Table;
                cmd.Parameters.Add("@CONDITION", SqlDbType.NVarChar).Value = Condition;
                da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(tbl);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThemBangDia(string strStore, string mabd, string tenbd, string matl, string mamuc)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MABD", SqlDbType.NVarChar).Value = mabd;
                cmd.Parameters.Add("@TENBD", SqlDbType.NVarChar).Value = tenbd;
                cmd.Parameters.Add("@MATL", SqlDbType.NVarChar).Value = matl;
                cmd.Parameters.Add("@MAMUC", SqlDbType.NVarChar).Value = mamuc;
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void ThemPhieuThue(string strStore, string mapt, string makh, DateTime ngaythue, string mand)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPT", SqlDbType.NVarChar).Value = mapt;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = makh;
                cmd.Parameters.Add("@NgayThue", SqlDbType.DateTime).Value = ngaythue;
                cmd.Parameters.Add("@MaND", SqlDbType.NVarChar).Value = mand;
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void ThemCTPhieuThue(string strStore, string mapt, string mabd, DateTime hantra, int soluong)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPT", SqlDbType.NVarChar).Value = mapt;
                cmd.Parameters.Add("@MaBD", SqlDbType.NVarChar).Value = mabd;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
                cmd.Parameters.Add("@HanTra", SqlDbType.DateTime).Value = hantra;
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void ThemPhieuTra(string strStore, string maptra, string mapt, string mabd, int soluong, DateTime ngaytra, string quahan, int phatquahan, int huhong, int phathuhong, int thanhtien, string mand)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPTra", SqlDbType.NVarChar).Value = maptra;
                cmd.Parameters.Add("@MaPT", SqlDbType.NVarChar).Value = mapt;
                cmd.Parameters.Add("@MaBD", SqlDbType.NVarChar).Value = mabd;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
                cmd.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = ngaytra;
                cmd.Parameters.Add("@QuaHan", SqlDbType.NVarChar).Value = quahan;
                cmd.Parameters.Add("@PhatQuaHan", SqlDbType.Int).Value = phatquahan;
                cmd.Parameters.Add("@HuHong", SqlDbType.Int).Value = huhong;
                cmd.Parameters.Add("@PhatHuHong", SqlDbType.Int).Value = phathuhong;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = thanhtien;
                cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar).Value = mand;
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }
    }
}
