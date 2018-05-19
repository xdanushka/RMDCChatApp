namespace RMDCChatClient
{
    partial class Login
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
            this.lbl_userName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_password = new MaterialSkin.Controls.MaterialLabel();
            this.tbox_userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_register = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Depth = 0;
            this.lbl_userName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_userName.Location = new System.Drawing.Point(9, 73);
            this.lbl_userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(84, 19);
            this.lbl_userName.TabIndex = 6;
            this.lbl_userName.Text = "User Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Depth = 0;
            this.lbl_password.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(9, 132);
            this.lbl_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(75, 19);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // tbox_userName
            // 
            this.tbox_userName.Depth = 0;
            this.tbox_userName.Hint = "Enter Your User Name";
            this.tbox_userName.Location = new System.Drawing.Point(13, 95);
            this.tbox_userName.MaxLength = 32767;
            this.tbox_userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_userName.Name = "tbox_userName";
            this.tbox_userName.PasswordChar = '\0';
            this.tbox_userName.SelectedText = "";
            this.tbox_userName.SelectionLength = 0;
            this.tbox_userName.SelectionStart = 0;
            this.tbox_userName.Size = new System.Drawing.Size(214, 23);
            this.tbox_userName.TabIndex = 8;
            this.tbox_userName.TabStop = false;
            this.tbox_userName.UseSystemPasswordChar = false;
            // 
            // tbox_password
            // 
            this.tbox_password.Depth = 0;
            this.tbox_password.Hint = "Enter Your Password";
            this.tbox_password.Location = new System.Drawing.Point(13, 154);
            this.tbox_password.MaxLength = 32767;
            this.tbox_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '*';
            this.tbox_password.SelectedText = "";
            this.tbox_password.SelectionLength = 0;
            this.tbox_password.SelectionStart = 0;
            this.tbox_password.Size = new System.Drawing.Size(214, 23);
            this.tbox_password.TabIndex = 9;
            this.tbox_password.TabStop = false;
            this.tbox_password.UseSystemPasswordChar = false;
            // 
            // btn_register
            // 
            this.btn_register.AutoSize = true;
            this.btn_register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register.Depth = 0;
            this.btn_register.Icon = null;
            this.btn_register.Location = new System.Drawing.Point(119, 194);
            this.btn_register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register.Name = "btn_register";
            this.btn_register.Primary = true;
            this.btn_register.Size = new System.Drawing.Size(83, 36);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Depth = 0;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(38, 194);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(61, 36);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 243);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.tbox_userName);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(239, 243);
            this.MinimumSize = new System.Drawing.Size(239, 243);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_userName;
        private MaterialSkin.Controls.MaterialLabel lbl_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_userName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_password;
        private MaterialSkin.Controls.MaterialRaisedButton btn_register;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
    }
}

