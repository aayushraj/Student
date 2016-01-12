using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Enroll.Framework.Dbutility
{
    public class DbConnection
    {
        private SqlConnection _Conn=null;
        private SqlCommand _Command = null;

        public String ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString; }
        }

        public void Open()
        {
            _Conn = new SqlConnection(ConnectionString);
            _Conn.Open();
        }

        public void InitCommand(string commandText,CommandType cmdType)
        {
            _Command = new SqlCommand();
            _Command.Connection = _Conn;
            _Command.CommandText = commandText;
            _Command.CommandType = cmdType;
        }

        public void AddInputParameter(string paramName,object paramValue,SqlDbType dbType)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = paramName;
            param.Value = paramValue;
            param.SqlDbType = dbType;
            _Command.Parameters.Add(param);

        }
        /**
         *  for INSERT/UPDATE/DELETE
         */
        public int ExecuteNonQuery()
        {
            return _Command.ExecuteNonQuery();
        }
        /**
         *  for Select
         */
        public IDataReader ExecuteReader()
        {
            return _Command.ExecuteReader();
        }

        public object ExecuteScalar()
        {
            return _Command.ExecuteScalar();
        }

        public void Close()
        {
            if (_Conn != null && _Conn.State == ConnectionState.Open)
            {
                _Conn.Close();
                _Conn = null;
            }
        }
    }
    }

