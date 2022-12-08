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

namespace TODO
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            UserDal u = new UserDal();

            cbUsername.DataSource = u.getAll();
        }

        private void cbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Trim() == "")
                MessageBox.Show("plz enter a password");
            else
            {
                UserDal u = new UserDal();
                int id = u.validate(cbUsername.Text, tbPassword.Text);
                if (id != -1)
                {
                    if (cbUsername.Text == "Admin")
                    {
                        Admin f = new Admin();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        FrmTodo f = new FrmTodo(id);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    
                }
                else
                    MessageBox.Show("incorrect username or password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.ShowDialog();
            UserDal u = new UserDal();
            cbUsername.DataSource = u.getAll();
        }
    }
}
