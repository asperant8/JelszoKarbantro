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
    
    public partial class JelszoKarbantarto : Form
    {
        Confirmation confirm = new Confirmation();
        User logged_in_user = new User();
        public JelszoKarbantarto()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            label_result.Text = "";
            panel_login.Width = this.Width;
            panel_login.Height = this.Height;


            panel_authenticated.Width = this.Width;
            panel_authenticated.Height = this.Height;


            panel_login.BringToFront();
            panel_authenticated.Visible = false;

            label_welcome.Text = "";
            label_result.Text = "";
            label_res.Text = "";
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            bool existingAccount = false;
            try
            {
                List<User> all_user = new List<User>();
                Authentication.JSON_read(all_user);
                
                foreach (var selected in all_user)
                {
                    if (textBox_username.Text == selected.username)
                    {
                        existingAccount = true;
                        label_result.Text = "Ilyen nevű felhasználó már létezik!";
                        break;
                    }


                }
            }
            catch
            {
                label_result.Text = "";
            }
           
            if (!existingAccount)
            {
                List<string> invalidChars = new List<string>() { "!", "@", ";", " ", "$", "-", ".", "," };
                if (textBox_username.Text.Length > 5 && textBox_password.Text.Length > 5)
                {
                    foreach (var item in invalidChars)
                    {
                        if (textBox_username.Text.Contains(item))
                        {
                            label_result.Text = "Hibás karaktereket tartalmaz a felhasználónév!";
                            break;
                        }
                        else
                        {
                            User user = new User(textBox_username.Text, Hashing.Generate_hash(textBox_password.Text));
                            Authentication.JSON_write(user);
                            label_result.Text = "A felhasználó sikeresen létrehozva!";
                            break;
                        }
                    }
                }
                else if (textBox_username.Text.Length < 5)
                {
                    label_result.Text = "Túl rövid a felhasználónév! Min. 5 karakter.";
                }
                else if (textBox_password.Text.Length < 5)
                {
                    label_result.Text = "Túl rövid a jelszó! Min. 5 karakter.";

                }
            }
            

           
            
        }
        

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> users = new List<User>();
                Authentication.JSON_read(users);
                User currentUser = new User(textBox_username.Text, Hashing.Generate_hash(textBox_password.Text));
                bool containsUser = users.Any(f => f.username == currentUser.username);
                if (containsUser)
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].username == currentUser.username)
                        {
                            if (users[i].hash_password == currentUser.hash_password)
                            {
                                logged_in_user = currentUser;
                                panel_authenticated.Visible = true;
                                panel_authenticated.BringToFront();
                                label_welcome.Text = "Üdv, " + logged_in_user.username+"!";
                                label_result.Text = "";



                                break;

                            }
                            else
                            {
                                label_result.Text = "Hibás jelszó!";

                            }
                        }

                    }
                }
                else
                {
                    label_result.Text = "Nincs ilyen felhasználó!";
                }
            }
            catch
            {
                label_result.Text = "Nincs ilyen felhasználó!";
            }
           
            

        }



        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            label_new_password.Visible = true;
            label_old_password.Visible = true;
            textBox_new_password.Visible = true;
            textBox_old_password.Visible = true;
            button_change.Visible = false;
            button_modify_ok.Visible = true;
            button_back.Visible = true;
            button_logout.Visible = false;
            button_delete_account.Visible = false;
        }

        private void button_modify_ok_Click(object sender, EventArgs e)
        {
            bool successfulChange = false;
            string label_result_string = label_result.Text;
            ModifyData.Modify_Login_credentials(logged_in_user, textBox_old_password.Text, textBox_new_password.Text, ref label_result_string, ref successfulChange);
            label_result.Text = label_result_string;
            if (successfulChange)
            {
                button_modify_ok.Visible = false;
                button_change.Visible = true;
                textBox_new_password.Visible = false;
                textBox_old_password.Visible = false;
                label_new_password.Visible = false;
                label_old_password.Visible = false;
                button_back.Visible = false;
                button_logout.Visible = true;
                button_delete_account.Visible = true;
            }
        }

        private void button_delete_account_Click(object sender, EventArgs e)
        {
            delegatePassUser userPass = new delegatePassUser(confirm.Logged_In_User_Pass);
            userPass(logged_in_user);
            confirm.ShowDialog();

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_login.Visible=true;
            panel_login.BringToFront();
            panel_authenticated.Visible = false;
            logged_in_user = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (confirm.isAccountDeleted)
            {
                panel_login.Visible = true;
                panel_login.BringToFront();
                panel_authenticated.Visible = false;
                confirm.isAccountDeleted = false;
                logged_in_user = null;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            button_modify_ok.Visible = false;
            button_change.Visible = true;
            textBox_new_password.Visible = false;
            textBox_old_password.Visible = false;
            label_new_password.Visible = false;
            label_old_password.Visible = false;
            button_back.Visible = false;
            label_result.Text = "";
            button_logout.Visible = true;
            button_delete_account.Visible = true;
        }
    }
    



}
