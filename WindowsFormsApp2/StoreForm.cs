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
            OrderDto[] x1 = BackendService.GetInventory("Victor");
            UserDto x2 = BackendService.GetBalance("Victor");

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
            UserDto udto = BackendService.GetUserID("Victor");
            long UserID = udto.UserID;

            string getSelected = StoreProductsList.SelectedItem.ToString();
            getSelected = getSelected.Split(':')[0];

            Console.WriteLine(getSelected);

            ProductDto pdto = BackendService.GetProductID(getSelected);
            long productID = pdto.ProductID;

            Console.WriteLine(productID);

            BackendService.BuyProduct(UserID, productID);

        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreProductsList.Items.Clear();
            storeInventoryList.Items.Clear();
            
            ProductDto[] x = BackendService.GetAvailableProducts();
            OrderDto[] x1 = BackendService.GetInventory("Victor");
            UserDto x2 = BackendService.GetBalance("Victor");

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
