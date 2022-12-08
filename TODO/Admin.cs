using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODO_DAL;
using TodoCommon;

namespace TODO
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            TodoDal tdal = new TodoDal();
            UserDal udal = new UserDal();
            dgv.DataSource = tdal.getAll();
            dgv.ClearSelection();
            cbUsers.DataSource = udal.getAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Todo todo = new Todo()
            {
                Task = tbTitle.Text,
                isComplete = false,
                UserId = ((User)cbUsers.Items[cbUsers.SelectedIndex]).Id
            };
            TodoDal dal = new TodoDal();
            dal.Insert(todo);
            List<Todo> list = dgv.DataSource as List<Todo>;
            list.Add(todo);
            dgv.DataSource = null;
            dgv.DataSource = list;
            dgv.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("select a row to delete");
            else
            {
                int id = (int)dgv.SelectedRows[0].Cells[0].Value;
                TodoDal dal = new TodoDal();
                dal.delete(id);
                List<Todo> dt = (List<Todo>)dgv.DataSource;
                dt.RemoveAll(x => x.Id == id);
                dgv.DataSource = null;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
        }
    }
}
