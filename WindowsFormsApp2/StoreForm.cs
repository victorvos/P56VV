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
    public partial class StoreForm : Form
    {
        private IService BackendService { get; set; }

        public StoreForm()
        {
            InitializeComponent();
            BackendService = new ServiceClient();

            var x = BackendService.GetAvailableProducts();
            var x1 = BackendService.GetInventory("Victor");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get Customer en zet in object
            // daarna Customer.Buy(Product p) aanroepen.
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SELECT ProductName, Price FROM Products WHERE Aantal > 0
            // SELECT ProductName, Amount FROM CustomerProduct Where Username == ""
        }
    }
}
