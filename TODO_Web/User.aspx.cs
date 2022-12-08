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
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("/Login");
            if (!IsPostBack)
            {
                TodoDal todoDal = new TodoDal();
                Session["todos"] = todoDal.getAll((int)Session["user"]);
                dgv.DataSource = (List<Todo>)Session["todos"];
                dgv.DataBind();
            }
        }

        protected void btnMark_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedIndex == -1)
                return;
            List<Todo> dt = (List<Todo>)Session["todos"];
            Todo todo = dt[dgv.SelectedIndex];
            todo.isComplete = true;
            TodoDal dal = new TodoDal();
            dal.update(todo);
            Session["todos"] = dt;
            dgv.DataSource = null;
            dgv.DataSource = dt;
            dgv.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("/Login");
        }
    }
}