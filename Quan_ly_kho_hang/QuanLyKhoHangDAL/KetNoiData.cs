using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhoHangDAL
{
    public class KetNoiData
    {
        public static SqlConnection connect;
        static string _message = "";
        public void MoKetNoi()
        {
            if (KetNoiData.connect == null)
                KetNoiData.connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_KhoHang;Integrated Security=True");
            if (KetNoiData.connect.State != ConnectionState.Open)
                KetNoiData.connect.Open();
        }
        public void DongKetNoi()
        {
            if (KetNoiData.connect != null)
            {
                if (KetNoiData.connect.State == ConnectionState.Open)
                {
                    KetNoiData.connect.Close();
                }
            }

        }
        //insert ,update ,delete
        public int ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public string ThucThiCauLenhSQL_CoThongBao(string strSQL)
        {
            try
            {
                _message = "";
                MoKetNoi();
                connect.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
                return _message;
            }
            catch
            {
                return _message;
            }
        }

        static void InfoMessageHandler(object sender, SqlInfoMessageEventArgs e)
        {
            _message = e.Message;
        }
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public string GetValue(string strSQL)//select
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }
    }
}
