using CoffeeRichardMillard.Models;
using CoffeeRichardMillard.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeRichardMillard
{
    public partial class FormCoffeeMachine : Form
    {
        Order order;

        public FormCoffeeMachine()
        {
            InitializeComponent();

            var coffees = new InMemoryRepository<Coffee>();
            var payments = new InMemoryRepository<Payment>();
            var sugars = new InMemoryRepository<Sugar>();
            var creams = new InMemoryRepository<Cream>();

            order = new Order(coffees, payments, sugars, creams);
            listBoxCoffees.DataSource = order.Coffees.GetAll(null);
            listBoxCoffees.DisplayMember = "OutputDescription";            
        }

        private void UpdateDisplay(int newSelectedIndex = -2)
        {
            int originalSelectedIndex = listBoxCoffees.SelectedIndex;

            // Force listbox to refresh
            listBoxCoffees.DisplayMember = "";
            listBoxCoffees.DisplayMember = "OutputDescription";

            labelTotal.Text = $"Total: {order.Total()}";
            labelPaid.Text = $"Paid: {order.TotalPayments()}";

            if (newSelectedIndex == -2)
                listBoxCoffees.SelectedIndex = Math.Min(originalSelectedIndex, listBoxCoffees.Items.Count - 1);
            else
                listBoxCoffees.SelectedIndex = newSelectedIndex;
        }

        private Coffee GetSelectedCoffee()
        {
            Coffee foundCoffee = null;
            if (listBoxCoffees.SelectedIndex > -1)
            {
                foundCoffee = (Coffee)listBoxCoffees.Items[listBoxCoffees.SelectedIndex];
            }
            return foundCoffee;
        }

        private void buttonAddCoffee_Click(object sender, EventArgs e)
        {
            Coffee coffee = order.AddCoffee();

            UpdateDisplay(order.Coffees.Count(null) - 1);
        }

        private void buttonRemoveCoffee_Click(object sender, EventArgs e)
        {
            Coffee selectedCoffee = GetSelectedCoffee();
            if (selectedCoffee != null)
            {
                int currentSelection = listBoxCoffees.SelectedIndex;

                order.RemoveCoffee(selectedCoffee);
                UpdateDisplay(listBoxCoffees.SelectedIndex = currentSelection - 1);
            }
        }

        private void buttonAddSugar_Click(object sender, EventArgs e)
        {
            Coffee coffee = GetSelectedCoffee();
            if (coffee != null)
            {
                coffee.AddSugar();
                UpdateDisplay();
            }
        }

        private void buttonRemoveSugar_Click(object sender, EventArgs e)
        {
            Coffee coffee = GetSelectedCoffee();
            if (coffee != null)
            {
                if (coffee.Sugars.Count(coffee) > 0)
                {
                    coffee.RemoveSugar(coffee.Sugars.Get(coffee, 0));
                    UpdateDisplay();
                }
            }
        }

        private void buttonRemoveCream_Click(object sender, EventArgs e)
        {
            Coffee coffee = GetSelectedCoffee();
            if (coffee != null)
            {
                if (coffee.Creams.Count(coffee) > 0)
                {
                    coffee.RemoveCream(coffee.Creams.Get(coffee, 0));
                    UpdateDisplay();
                }
            }
        }

        private void buttonAddCream_Click(object sender, EventArgs e)
        {
            Coffee coffee = GetSelectedCoffee();
            if (coffee != null)
            {
                coffee.AddCream();
                UpdateDisplay();
            }
        }

        private void buttonPay(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button payButton = ((Button)sender);
                Decimal paymentAmount = 0.0m;
                
                if (Decimal.TryParse((string)payButton.Tag, out paymentAmount))
                {
                    order.AddPayment(paymentAmount);
                    UpdateDisplay();
                }
            }
        }

        private void buttonCompleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal changeDue = order.CompleteOrder();
                MessageBox.Show($"Enjoy your coffee!  Change due: {changeDue}");

                order.Clear();
                tabControl.SelectedIndex = 0; // display Order tab
                UpdateDisplay();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCoffeeSize_Click(object sender, EventArgs e)
        {
            Button sizeButton = (Button)sender;

            if (sizeButton != null)
            {
                Coffee selectedCoffee = GetSelectedCoffee();
                if (selectedCoffee != null)
                {
                    int coffeeSizeInt = 0;
                    if (int.TryParse((string)sizeButton.Tag, out coffeeSizeInt))
                    {
                        selectedCoffee.Size = (CoffeeSizes)coffeeSizeInt;
                        UpdateDisplay();
                    }
                }
            }
        }

    }
}
