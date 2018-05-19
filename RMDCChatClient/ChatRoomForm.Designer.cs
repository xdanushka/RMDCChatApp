namespace RMDCChatClient
{
    partial class ChatRoomForm
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
            this.lst_online = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_chat = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_send = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbox_msg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_online
            // 
            this.lst_online.BackgroundImageTiled = true;
            this.lst_online.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_online.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lst_online.Depth = 0;
            this.lst_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lst_online.FullRowSelect = true;
            this.lst_online.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_online.Location = new System.Drawing.Point(359, 69);
            this.lst_online.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lst_online.MouseState = MaterialSkin.MouseState.OUT;
            this.lst_online.Name = "lst_online";
            this.lst_online.OwnerDraw = true;
            this.lst_online.Size = new System.Drawing.Size(123, 233);
            this.lst_online.TabIndex = 5;
            this.lst_online.UseCompatibleStateImageBehavior = false;
            this.lst_online.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Online Users";
            this.columnHeader1.Width = 120;
            // 
            // lst_chat
            // 
            this.lst_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_chat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lst_chat.Depth = 0;
            this.lst_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lst_chat.FullRowSelect = true;
            this.lst_chat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_chat.Location = new System.Drawing.Point(13, 69);
            this.lst_chat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lst_chat.MouseState = MaterialSkin.MouseState.OUT;
            this.lst_chat.Name = "lst_chat";
            this.lst_chat.OwnerDraw = true;
            this.lst_chat.Size = new System.Drawing.Size(340, 233);
            this.lst_chat.TabIndex = 6;
            this.lst_chat.UseCompatibleStateImageBehavior = false;
            this.lst_chat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chat Box";
            this.columnHeader2.Width = 340;
            // 
            // btn_send
            // 
            this.btn_send.AutoSize = true;
            this.btn_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_send.Depth = 0;
            this.btn_send.Icon = null;
            this.btn_send.Location = new System.Drawing.Point(426, 308);
            this.btn_send.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_send.Name = "btn_send";
            this.btn_send.Primary = true;
            this.btn_send.Size = new System.Drawing.Size(56, 36);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbox_msg
            // 
            this.tbox_msg.Depth = 0;
            this.tbox_msg.Hint = "Type Your Message Here!";
            this.tbox_msg.Location = new System.Drawing.Point(13, 321);
            this.tbox_msg.MaxLength = 32767;
            this.tbox_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_msg.Name = "tbox_msg";
            this.tbox_msg.PasswordChar = '\0';
            this.tbox_msg.SelectedText = "";
            this.tbox_msg.SelectionLength = 0;
            this.tbox_msg.SelectionStart = 0;
            this.tbox_msg.Size = new System.Drawing.Size(407, 23);
            this.tbox_msg.TabIndex = 8;
            this.tbox_msg.TabStop = false;
            this.tbox_msg.UseSystemPasswordChar = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_user.Location = new System.Drawing.Point(353, 22);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(70, 33);
            this.lbl_user.TabIndex = 9;
            this.lbl_user.Text = "label1";
            // 
            // ChatRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 355);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lst_online);
            this.Controls.Add(this.tbox_msg);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lst_chat);
            this.MaximumSize = new System.Drawing.Size(497, 355);
            this.MinimumSize = new System.Drawing.Size(497, 355);
            this.Name = "ChatRoomForm";
            this.Text = "ChatNow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatRoomForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatNow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lst_online;
        private MaterialSkin.Controls.MaterialListView lst_chat;
        private MaterialSkin.Controls.MaterialRaisedButton btn_send;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_msg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_user;
    }
}