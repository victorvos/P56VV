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
using WindowsFormsApp2.Extensions;

namespace WindowsFormsApp2
{
    public partial class StoreForm : Form
    {
        private IService BackendService { get; set; }
       

        public StoreForm()
        {
            InitializeComponent();
            BackendService = new ServiceClient();

            ProductDto[] x = BackendService.GetAvailableProducts();
            OrderDto[] x1 = BackendService.GetInventory(Globals.Username);
            UserDto x2 = BackendService.GetBalance(Globals.Username);

            int valueFromDB = x2.Balance;
            string formatBalance = valueFromDB.AsCurrency();
  

            foreach (var item in x)
            {
                if (item.AvailableAmount > 0)
                {
                    String printItems = $"{item.Name}:                  {item.AvailableAmount},    {item.Price.AsCurrency()}";
                    StoreProductsList.Items.Add(printItems);
                }                
            }
            
            foreach(var item in x1)
            {
                String printItems= $"{item.ProductName}, {item.Amount}";
                storeInventoryList.Items.Add(printItems);
            }

            storeLabelSaldo.Text = $"Money left: {formatBalance}";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDto udto = BackendService.GetUserID(Globals.Username);
            long UserID = udto.UserID;
            UserDto x2 = BackendService.GetBalance(Globals.Username);

            int balance = x2.Balance;

            string getSelected = StoreProductsList.SelectedItem.ToString();
            getSelected = getSelected.Split(':')[0];

            ProductDto pdto = BackendService.GetProductID(getSelected);
            long productID = pdto.ProductID;

            Product p = BackendService.GetProduct(productID);


            if (balance - p.Price < 0)
            {
                storeLabelMessage.Font = new Font(storeLabelMessage.Font.FontFamily, 10);
                storeLabelMessage.Text = "Balance too less to buy this Product";
            }
            else
            {
                BackendService.BuyProduct(UserID, productID, 1);
            }

            

        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreProductsList.Items.Clear();
            storeInventoryList.Items.Clear();
            
            ProductDto[] x = BackendService.GetAvailableProducts();
            OrderDto[] x1 = BackendService.GetInventory(Globals.Username);
            UserDto x2 = BackendService.GetBalance(Globals.Username);

            int valueFromDB = x2.Balance;
            string formatBalance = valueFromDB.AsCurrency();
            
            foreach (var item in x)
            {
                if (item.AvailableAmount > 0)
                {
                    String printItems = $"{item.Name}:                  {item.AvailableAmount},    {item.Price.AsCurrency()}";
                    StoreProductsList.Items.Add(printItems);
                }
            }

            foreach (var item in x1)
            {
                String printItems = $"{item.ProductName}, {item.Amount}";
                storeInventoryList.Items.Add(printItems);
            }

            storeLabelSaldo.Text = $"Money left: {formatBalance}";
        }

        private void StoreProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storeLabelSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
