using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        private void registerButton1_Click(object sender, EventArgs e)
        {
            String username = registerTextBoxUsername.Text;
            if (username == "")
            {
                registerLabelMessage.ForeColor = Color.Red;
                registerLabelMessage.Text = "Vul een username in";
            }

            if () // check of user bestaat in DB
            {
                Customer c = new Customer(username, Reverse(username));
                registerTextBoxUsername.Text = "Your new password: " + Reverse(username);
            }
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
