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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            if (!userDal.ExistUser(tbUser.Text))
            {
                User u = new User { username = tbUser.Text, password = tbPassword.Text };
                userDal.Insert(u);
                this.Close();
            }
            else
            {
                MessageBox.Show("user already exist");
            }
        }
    }
}
