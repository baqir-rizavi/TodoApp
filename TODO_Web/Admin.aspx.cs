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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("/Login");
            if (!IsPostBack)
            {
                TodoDal todoDal = new TodoDal();
                Session["todos"] = todoDal.getAll();
                dgv.DataSource = (List<Todo>)Session["todos"];
                dgv.DataBind();
                UserDal u = new UserDal();
                Session["users"] = u.getAll();
                ddlUser.DataSource = (List<TodoCommon.User>)Session["users"];
                ddlUser.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           
            Todo todo = new Todo(tbTitle.Text, false, ((List<TodoCommon.User>)Session["users"])[ddlUser.SelectedIndex].Id);
            TodoDal dal = new TodoDal();
            dal.Insert(todo);
            List<Todo> list = (List<Todo>)Session["todos"];
            list.Add(todo);
            Session["todos"] = list;
            dgv.DataSource = null;
            dgv.DataSource = list;
            dgv.DataBind();
            tbTitle.Text = "";
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("/Login");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedIndex == -1)
            {
                return;
            }
            Todo todo = ((List<Todo>)Session["todos"])[dgv.SelectedIndex];
            TodoDal dal = new TodoDal();
            dal.delete(todo.Id);
            List<Todo> todos = (List<Todo>)Session["todos"];
            todos.RemoveAll(x => x.Id == todo.Id);
            Session["todos"] = todos;
            dgv.DataSource = null;
            dgv.DataSource = todos;
            dgv.DataBind();
        }
    }
}