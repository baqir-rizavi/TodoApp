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
    public partial class FrmTodo : Form
    {
        int usr_id;
        private FrmTodo()
        {
            InitializeComponent();
        }

        public FrmTodo(int urs_id)
        {
            InitializeComponent();
            this.usr_id = urs_id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TodoDal dal = new TodoDal();
            dgv.DataSource = dal.getAll(usr_id);
            dgv.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("plz select a row");
            else
            {
                List<Todo> dt = (List<Todo>)dgv.DataSource;
                Todo todo = dt[dgv.CurrentCell.RowIndex];
                todo.isComplete = true;
                TodoDal dal = new TodoDal();
                dal.update(todo);
                dgv.DataSource = null;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
        }
    }
}