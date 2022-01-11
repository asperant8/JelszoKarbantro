using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JelszoKarbantarto
{
    public partial class Confirmation : Form
    {
        public bool isAccountDeleted = false;
        User logged_in_user = new User();
        public Confirmation()
        {
            InitializeComponent();
        }
        public void Logged_In_User_Pass(User logged_user)
        {
            logged_in_user = logged_user;

        }

        private void button_yes_Click(object sender, EventArgs e)
        {

            ModifyData.Delete_Account(logged_in_user);
            isAccountDeleted = true;
            this.Close();

 

        }

        private void button_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            isAccountDeleted = false;
            this.Left = JelszoKarbantarto.ActiveForm.Left;
            this.Top = JelszoKarbantarto.ActiveForm.Top;

        }
    }

}
