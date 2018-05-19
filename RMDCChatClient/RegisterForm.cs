using MaterialSkin;
using MaterialSkin.Controls;
using RMDCChatClient.Properties;
using System;
using System.Windows.Forms;

namespace RMDCChatClient
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_newRegister_Click(object sender, EventArgs e)
        {
            string userName = tbox_newUserName.Text;
            string password = tbox_newRePassword.Text;
            string rePassword = tbox_newRePassword.Text;

            if (userName.Equals("") || password.Equals("") || rePassword.Equals(""))
            {
                MessageBox.Show(Resources.registration_empty, Resources.error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show(Resources.pwd_length_error, Resources.error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!password.Equals(rePassword))
            {
                MessageBox.Show(Resources.pwd_not_match, Resources.error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new DbHelper().AddUser(userName, password))
            {
                MessageBox.Show(Resources.reg_success, Resources.success,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Owner.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(Resources.reg_failed, Resources.error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
