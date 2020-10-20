using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cqimo
{
    public  class SqlHelper
    {
        //连接字符串
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;


        /// <summary>
        /// 1.执行增、删、改的方法：ExecuteNonQuery
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //2.封装一个执行返回单个对象的方法：ExecuteScalar()
        public static object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        private void OpenFrom(Form objFrm)
        {
            //将当前子窗体设置成非顶级控件
            objFrm.TopLevel = false;
            //设置窗体最大化
            objFrm.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            objFrm.FormBorderStyle = FormBorderStyle.None;
            //指定当前子窗体显示的容器
            
            //显示窗体
            objFrm.Show();
        }

        //3.执行查询多行多列的数据的方法：ExecuteReader
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(connStr);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception)
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }


        //4.执行返回DataTable的方法
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }

    }
}
