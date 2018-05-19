namespace RMDCChatClient
{
    partial class RegisterForm
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
            this.lbl_newUserName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_newPassword = new MaterialSkin.Controls.MaterialLabel();
            this.tbox_newUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_newPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_newRePassword = new MaterialSkin.Controls.MaterialLabel();
            this.tbox_newRePassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_newRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_newUserName
            // 
            this.lbl_newUserName.AutoSize = true;
            this.lbl_newUserName.Depth = 0;
            this.lbl_newUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_newUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_newUserName.Location = new System.Drawing.Point(9, 74);
            this.lbl_newUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newUserName.Name = "lbl_newUserName";
            this.lbl_newUserName.Size = new System.Drawing.Size(84, 19);
            this.lbl_newUserName.TabIndex = 7;
            this.lbl_newUserName.Text = "User Name";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Depth = 0;
            this.lbl_newPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_newPassword.Location = new System.Drawing.Point(9, 131);
            this.lbl_newPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(75, 19);
            this.lbl_newPassword.TabIndex = 8;
            this.lbl_newPassword.Text = "Password";
            // 
            // tbox_newUserName
            // 
            this.tbox_newUserName.Depth = 0;
            this.tbox_newUserName.Hint = "Enter a Name";
            this.tbox_newUserName.Location = new System.Drawing.Point(13, 96);
            this.tbox_newUserName.MaxLength = 32767;
            this.tbox_newUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_newUserName.Name = "tbox_newUserName";
            this.tbox_newUserName.PasswordChar = '\0';
            this.tbox_newUserName.SelectedText = "";
            this.tbox_newUserName.SelectionLength = 0;
            this.tbox_newUserName.SelectionStart = 0;
            this.tbox_newUserName.Size = new System.Drawing.Size(172, 23);
            this.tbox_newUserName.TabIndex = 9;
            this.tbox_newUserName.TabStop = false;
            this.tbox_newUserName.UseSystemPasswordChar = false;
            // 
            // tbox_newPassword
            // 
            this.tbox_newPassword.Depth = 0;
            this.tbox_newPassword.Hint = "Enter a Password";
            this.tbox_newPassword.Location = new System.Drawing.Point(13, 154);
            this.tbox_newPassword.MaxLength = 32767;
            this.tbox_newPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_newPassword.Name = "tbox_newPassword";
            this.tbox_newPassword.PasswordChar = '*';
            this.tbox_newPassword.SelectedText = "";
            this.tbox_newPassword.SelectionLength = 0;
            this.tbox_newPassword.SelectionStart = 0;
            this.tbox_newPassword.Size = new System.Drawing.Size(172, 23);
            this.tbox_newPassword.TabIndex = 10;
            this.tbox_newPassword.TabStop = false;
            this.tbox_newPassword.UseSystemPasswordChar = false;
            // 
            // lbl_newRePassword
            // 
            this.lbl_newRePassword.AutoSize = true;
            this.lbl_newRePassword.Depth = 0;
            this.lbl_newRePassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_newRePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_newRePassword.Location = new System.Drawing.Point(9, 190);
            this.lbl_newRePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newRePassword.Name = "lbl_newRePassword";
            this.lbl_newRePassword.Size = new System.Drawing.Size(96, 19);
            this.lbl_newRePassword.TabIndex = 11;
            this.lbl_newRePassword.Text = "Re-Password";
            // 
            // tbox_newRePassword
            // 
            this.tbox_newRePassword.Depth = 0;
            this.tbox_newRePassword.Hint = "Re-Enter a Password";
            this.tbox_newRePassword.Location = new System.Drawing.Point(12, 212);
            this.tbox_newRePassword.MaxLength = 32767;
            this.tbox_newRePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_newRePassword.Name = "tbox_newRePassword";
            this.tbox_newRePassword.PasswordChar = '*';
            this.tbox_newRePassword.SelectedText = "";
            this.tbox_newRePassword.SelectionLength = 0;
            this.tbox_newRePassword.SelectionStart = 0;
            this.tbox_newRePassword.Size = new System.Drawing.Size(172, 23);
            this.tbox_newRePassword.TabIndex = 12;
            this.tbox_newRePassword.TabStop = false;
            this.tbox_newRePassword.UseSystemPasswordChar = false;
            // 
            // btn_newRegister
            // 
            this.btn_newRegister.AutoSize = true;
            this.btn_newRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_newRegister.Depth = 0;
            this.btn_newRegister.Icon = null;
            this.btn_newRegister.Location = new System.Drawing.Point(13, 249);
            this.btn_newRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_newRegister.Name = "btn_newRegister";
            this.btn_newRegister.Primary = true;
            this.btn_newRegister.Size = new System.Drawing.Size(83, 36);
            this.btn_newRegister.TabIndex = 13;
            this.btn_newRegister.Text = "Register";
            this.btn_newRegister.UseVisualStyleBackColor = true;
            this.btn_newRegister.Click += new System.EventHandler(this.btn_newRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 295);
            this.Controls.Add(this.btn_newRegister);
            this.Controls.Add(this.tbox_newRePassword);
            this.Controls.Add(this.lbl_newRePassword);
            this.Controls.Add(this.tbox_newPassword);
            this.Controls.Add(this.tbox_newUserName);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.lbl_newUserName);
            this.MaximumSize = new System.Drawing.Size(195, 295);
            this.MinimumSize = new System.Drawing.Size(195, 295);
            this.Name = "RegisterForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_newUserName;
        private MaterialSkin.Controls.MaterialLabel lbl_newPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_newUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_newPassword;
        private MaterialSkin.Controls.MaterialLabel lbl_newRePassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_newRePassword;
        private MaterialSkin.Controls.MaterialRaisedButton btn_newRegister;

    }
}