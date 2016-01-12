using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.Framework.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
       
        public DateTime? AddedDate { get; set; }
    }
}
