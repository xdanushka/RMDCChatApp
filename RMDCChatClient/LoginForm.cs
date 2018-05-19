using MaterialSkin;
using MaterialSkin.Controls;
using RMDCChatClient.Models;
using RMDCChatClient.Properties;
using System;
using System.Windows.Forms;

namespace RMDCChatClient
{
    public partial class Login : MaterialForm
    {

        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tbox_userName.Text;
            string pass = tbox_password.Text;

            if (userName.Equals("") || pass.Equals(""))
            {
                MessageBox.Show(Resources.login_emty_credentials, Resources.error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new DbHelper().GetUser(userName, pass);
            if (user == null)
            {
                MessageBox.Show(Resources.login_wrong_credentials, Resources.error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChatRoomForm chatNow = new ChatRoomForm(user);
            Hide();
            chatNow.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Owner = this;
            Hide();
            registerForm.Show();
        }
    }
}
