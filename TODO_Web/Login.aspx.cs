using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TODO_DAL;

namespace TODO_Web
{
    public partial class Login : System.Web.UI.Page
    {
        List<TodoCommon.User> users;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDal u = new UserDal();
                users = u.getAll();
                ddlUsername.DataSource = users;
                ddlUsername.DataBind();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lbFailedLogin.Visible = false;
            UserDal u = new UserDal();
            int id = u.validate(ddlUsername.SelectedValue, tbPassword.Text);
            if (id != -1)
            {
                if (ddlUsername.SelectedValue == "Admin")
                {
                    Session["user"] = id;
                    Response.Redirect("/Admin");
                }
                else
                {
                    Session["user"] = id;
                    Response.Redirect("/User");
                }
            }
            else
            {
                lbFailedLogin.Visible = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lbFailedLogin.Visible = false;
            Response.Redirect("/Register");

        }
    }
}