using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BankClient
{
    public partial class Form1 : Form
    {
        
        Connection conn = new Connection();
        double amount = 0;
        public Form1()
        {
            InitializeComponent();
            var ClientRaw = File.ReadAllText("Clients.txt");
            List<Customer> Clients = (List<Customer>) JsonConvert.DeserializeObject<IList<Customer>>(ClientRaw);
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            foreach (var c in Clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Name; 
                item.Tag = c;
                listView1.Items.Add(item);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            amount = double.Parse(AmountValue.Text);
            AdjustFunds();
            AmountValue.Text = "";

        }

       

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            amount = 0;


            if (e.IsSelected)
            {

                Customer c = (Customer)listView1.SelectedItems[0].Tag;
                

                NameValue.Text = c.Name;
                FundsValue.Text = conn.GetFunds(c.Id, amount);
                
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            
            amount = double.Parse(AmountValue.Text);
            amount = -amount;
            AdjustFunds();
            AmountValue.Text = "";
        }

        public void AdjustFunds()
        {
            // optimer ved at gøre customer til instancefield..
            Customer c = (Customer)listView1.SelectedItems[0].Tag;

            FundsValue.Text = conn.GetFunds(c.Id, amount);
        }

        
    }
}
