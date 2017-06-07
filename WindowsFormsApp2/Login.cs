using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.BackendSysteem;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        private IService BackendService { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            BackendService = new ServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginTextBoxUsername.Text == "" || loginTextBoxPassword.Text == "")
            {
                loginLabelMessage.Text = "Username or Password field is still empty";
            }
            else
            {
                if (BackendService.Login(loginTextBoxUsername.Text, loginTextBoxPassword.Text))
                {
                    loginLabelMessage.Text = "Success";

                    this.Hide();
                    var form = new StoreForm();
                    form.Show();
                }
                else
                {
                    loginLabelMessage.Text = "Faal";
                }
            }

            


            // else -> check of username is geregistreerd anders loginLabelMessage.Text = "Customer not registered";
            // else -> user en wachtwoord combinatie komen niet juist overeen loginLabelMessage.Text = "User and Password combination not correct";
            // else -> logged succesfully in. -> goto Store Form. and get Customer info. saldo, producten in inventory en producten beschikbaar.

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

       

        private void registerButton1_Click(object sender, EventArgs e)
        {
            String username = registerTextBoxUsername.Text;
            if (username == "")
            {
                //    registerLabelMessage.ForeColor = Color.Red;
                //    registerLabelMessage.Text = "Vul een username in";
            }
            else
            {
                var newPassword = BackendService.RegistreerUser(username);
                if (!string.IsNullOrWhiteSpace(newPassword)) // check of user bestaat in DB
                {
                    registerLabelMessage.Text = $"Your new password: {newPassword}";
                }
                else
                {
                    registerLabelMessage.ForeColor = Color.Red;
                    registerTextBoxUsername.Text = "Customer already exists!";
                }
            }
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
