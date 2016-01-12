using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Enroll.Framework.Entity;
using Enroll.Framework.Dbutility;

namespace Enroll.Framework.EnrollRepository
{
    public interface IStudentRepository
    {
        int Insert(Student s);
        int Update(Student s);

        int Delete(int Id);
    }

    public class StudentRepository:IStudentRepository
    {
        private DbConnection _conn;

        public StudentRepository()
        {
            _conn = new DbConnection();
        }

        public int Insert(Student s)
        {
            string sql = "insert into mstStudent (FirstName,MidName,LastName,Address,Contact,Email,AddedDate)"+
                "values(@FirstName, @MidName, @LastName, @Address, @Contact, @Email, @AddedDate)";

            _conn.Open();

            _conn.InitCommand(sql, CommandType.Text);

            _conn.AddInputParameter("@FirstName", s.FirstName, SqlDbType.NVarChar);
            _conn.AddInputParameter("@MidName",   s.MidName, SqlDbType.NVarChar);
            _conn.AddInputParameter("@LastName", s.LastName, SqlDbType.NVarChar);
            _conn.AddInputParameter("@Address", s.Address, SqlDbType.NVarChar);
            _conn.AddInputParameter("@Contact", s.Contact, SqlDbType.NVarChar);
            _conn.AddInputParameter("@Email", s.Email, SqlDbType.NVarChar);
            _conn.AddInputParameter("@AddedDate", DateTime.Now, SqlDbType.DateTime);

            int result = _conn.ExecuteNonQuery();
            _conn.Close();

            return result;


        }

        public int Update(Student s)
        {
            throw new NotImplementedException();
        }


        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
