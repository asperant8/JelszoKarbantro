
namespace JelszoKarbantarto
{
    partial class JelszoKarbantarto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel_authenticated = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_res = new System.Windows.Forms.Label();
            this.button_delete_account = new System.Windows.Forms.Button();
            this.button_modify_ok = new System.Windows.Forms.Button();
            this.label_new_password = new System.Windows.Forms.Label();
            this.label_old_password = new System.Windows.Forms.Label();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.textBox_old_password = new System.Windows.Forms.TextBox();
            this.button_change = new System.Windows.Forms.Button();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_login.SuspendLayout();
            this.panel_authenticated.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBox_username.Location = new System.Drawing.Point(338, 49);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(131, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(157, 194);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 20);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "Hozzáad";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(338, 86);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(131, 20);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Felhasználónév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jelszó";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(394, 194);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 20);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Belépés";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.panel_authenticated);
            this.panel_login.Controls.Add(this.label_result);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.button_register);
            this.panel_login.Location = new System.Drawing.Point(-2, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(589, 228);
            this.panel_login.TabIndex = 9;
            // 
            // panel_authenticated
            // 
            this.panel_authenticated.Controls.Add(this.button_logout);
            this.panel_authenticated.Controls.Add(this.button_back);
            this.panel_authenticated.Controls.Add(this.label_res);
            this.panel_authenticated.Controls.Add(this.button_delete_account);
            this.panel_authenticated.Controls.Add(this.button_modify_ok);
            this.panel_authenticated.Controls.Add(this.label_new_password);
            this.panel_authenticated.Controls.Add(this.label_old_password);
            this.panel_authenticated.Controls.Add(this.textBox_new_password);
            this.panel_authenticated.Controls.Add(this.textBox_old_password);
            this.panel_authenticated.Controls.Add(this.button_change);
            this.panel_authenticated.Controls.Add(this.label_welcome);
            this.panel_authenticated.Location = new System.Drawing.Point(3, 3);
            this.panel_authenticated.Name = "panel_authenticated";
            this.panel_authenticated.Size = new System.Drawing.Size(583, 222);
            this.panel_authenticated.TabIndex = 10;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(53, 168);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(120, 23);
            this.button_logout.TabIndex = 12;
            this.button_logout.Text = "Kijelentkezés";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(309, 168);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(58, 23);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "Vissza";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(294, 194);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(35, 13);
            this.label_res.TabIndex = 10;
            this.label_res.Text = "label1";
            // 
            // button_delete_account
            // 
            this.button_delete_account.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete_account.ForeColor = System.Drawing.Color.Maroon;
            this.button_delete_account.Location = new System.Drawing.Point(434, 168);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(117, 23);
            this.button_delete_account.TabIndex = 9;
            this.button_delete_account.Text = "Felhasználó törlése";
            this.button_delete_account.UseVisualStyleBackColor = false;
            this.button_delete_account.Click += new System.EventHandler(this.button_delete_account_Click);
            // 
            // button_modify_ok
            // 
            this.button_modify_ok.Location = new System.Drawing.Point(247, 168);
            this.button_modify_ok.Name = "button_modify_ok";
            this.button_modify_ok.Size = new System.Drawing.Size(56, 23);
            this.button_modify_ok.TabIndex = 8;
            this.button_modify_ok.Text = "Változtat";
            this.button_modify_ok.UseVisualStyleBackColor = true;
            this.button_modify_ok.Visible = false;
            this.button_modify_ok.Click += new System.EventHandler(this.button_modify_ok_Click);
            // 
            // label_new_password
            // 
            this.label_new_password.AutoSize = true;
            this.label_new_password.Location = new System.Drawing.Point(193, 128);
            this.label_new_password.Name = "label_new_password";
            this.label_new_password.Size = new System.Drawing.Size(46, 13);
            this.label_new_password.TabIndex = 7;
            this.label_new_password.Text = "Új jelszó";
            this.label_new_password.Visible = false;
            // 
            // label_old_password
            // 
            this.label_old_password.AutoSize = true;
            this.label_old_password.Location = new System.Drawing.Point(193, 90);
            this.label_old_password.Name = "label_old_password";
            this.label_old_password.Size = new System.Drawing.Size(77, 13);
            this.label_old_password.TabIndex = 6;
            this.label_old_password.Text = "Jelenlegi jelszó";
            this.label_old_password.Visible = false;
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.Location = new System.Drawing.Point(364, 125);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_new_password.TabIndex = 5;
            this.textBox_new_password.UseSystemPasswordChar = true;
            this.textBox_new_password.Visible = false;
            // 
            // textBox_old_password
            // 
            this.textBox_old_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_old_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBox_old_password.Location = new System.Drawing.Point(364, 87);
            this.textBox_old_password.Name = "textBox_old_password";
            this.textBox_old_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_old_password.TabIndex = 4;
            this.textBox_old_password.Visible = false;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(249, 168);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(120, 23);
            this.button_change.TabIndex = 3;
            this.button_change.Text = "Jelszó módosítás";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(277, 19);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(35, 13);
            this.label_welcome.TabIndex = 2;
            this.label_welcome.Text = "label3";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(243, 150);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(35, 13);
            this.label_result.TabIndex = 9;
            this.label_result.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JelszoKarbantarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(607, 231);
            this.Controls.Add(this.panel_login);
            this.Name = "JelszoKarbantarto";
            this.RightToLeftLayout = true;
            this.Text = "Jelszó karbantartó";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_authenticated.ResumeLayout(false);
            this.panel_authenticated.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Panel panel_authenticated;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.Button button_delete_account;
        private System.Windows.Forms.Button button_modify_ok;
        private System.Windows.Forms.Label label_new_password;
        private System.Windows.Forms.Label label_old_password;
        private System.Windows.Forms.TextBox textBox_new_password;
        private System.Windows.Forms.TextBox textBox_old_password;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Timer timer1;
    }
}

