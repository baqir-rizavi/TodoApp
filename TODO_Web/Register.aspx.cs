using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TODO_DAL;
using TodoCommon;

namespace TODO_Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lbUserExist.Visible = false;
            UserDal userDal = new UserDal();
            if (!userDal.ExistUser(tbUsername.Text))
            {
                TodoCommon.User u = new TodoCommon.User { username = tbUsername.Text, password = tbPassword.Text };
                userDal.Insert(u);
                Response.Redirect("/Login");
            }
            else
            {
                lbUserExist.Visible = true;
            }
        }
    }
}