using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    using System;
    using System.Windows.Forms;

    public class Customer
    {
        private String username, password;
        private Double balance;
        private static List<Customer> _users = new List<Customer>();    //userlist
        private List<Product> productInventory = new List<Product>();   // Inventory met producten van customer

        public Customer(String username, String password)
        {
            this.username = username;
            this.password = password;
            balance = 25.00;
            _users.Add(this);                                           //add user to userlist when instance made.
        }

        public String Username { get; set; }
        public String Password { get; set; }
        public Double Balance { get; set; }

        public void Buy(Product p)
        {
            if(balance < p.Price)
            {
                MessageBox.Show("Not enough balance to buy this product");
            }
            else if (p.Amount < 1)
            {
                MessageBox.Show("Not enough products in stock");
            }
            else
            {
                productInventory.Add(p);
                p.Amount -= 1;
                Console.WriteLine("Bought : " + p.Name + " x 1");
            }
        }
    }
}
