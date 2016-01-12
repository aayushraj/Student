using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Enroll.Framework.Entity;
using Enroll.Framework.EnrollRepository;

public partial class Admin_Dashboard : System.Web.UI.Page
{
    private IStudentRepository _studentRepository = new StudentRepository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Student s = new Student()
        {

            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            MidName = txtMidname.Text,
            Address = txtAddress.Text,
            Contact = txtContact.Text,
            Email = txtEmail.Text,


        };



        if (_studentRepository.Insert(s)>0)
        {
            txtMessage.Text = "Added Successfully";
        }
    }
}