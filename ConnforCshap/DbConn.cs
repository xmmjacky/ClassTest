﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnforCshap
{
    public class DbConn
    {
        private const int MaxPool = 10;//最大连接数
        private const int MinPool = 5;//最小连接数
        private const bool Asyn_Process = true;//设置异步访问数据库
        private const bool Mars = true;
        private const int Conn_Timeout = 15;//设置连接等待时间
        private const int Conn_Lifetime = 15;//设置连接的生命周期
        private string ConnString = "";//连接字符串
        private SqlConnection SqlDrConn = null;//连接对象
        public DbConn()
        {
            ConnString = GetConnString();
            SqlDrConn = new SqlConnection(ConnString);
        }
        private string GetConnString()
        {
            return "server=localhost;integratedsecurity=sspi;database=pubs;MaxPoolSize=" + MaxPool + ";MinPoolSize=" + MinPool + ";ConnectTimeout=" + Conn_Timeout + ";"
                + "ConnectionLifetime=" + Conn_Lifetime + ";AsynchronousProcessing=" + Asyn_Process + ";";
        }
        public DataTable GetDataReader(string StrSql)
        {
            //当连接处于打开状态时关闭,然后再打开,避免有时候数据不能及时更新
            if (SqlDrConn.State == ConnectionState.Open)
            {
                SqlDrConn.Close();
            }
            try
            {
                SqlDrConn.Open();
                SqlCommand SqlCmd = new SqlCommand(StrSql, SqlDrConn);
                SqlDataReader SqlDr = SqlCmd.ExecuteReader();
                if (SqlDr.HasRows)
                {
                    DataTable dt = new DataTable();
                    //读取SqlDataReader里的内容
                    dt.Load(SqlDr);
                    //关闭对象和连接
                    SqlDr.Close();
                    SqlDrConn.Close();
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                SqlDrConn.Close();
            }
        }
    }
}

