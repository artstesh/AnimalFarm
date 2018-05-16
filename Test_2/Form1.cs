using System;
using System.Windows.Forms;
using Test_2.Models;
using Test_2.Tools;

namespace Test_2
{
    
    public partial class Form1 : Form
    {
        private Animal viewAnOne;
        private Animal viewAnTwo;

        private void Analize ()
        {   
            if (viewAnOne.massa > viewAnTwo.massa) tbAnalize.Text = viewAnOne.name + " весит больше, чем " + viewAnTwo.name;
            if (viewAnOne.massa < viewAnTwo.massa) tbAnalize.Text = viewAnOne.name + " весит меньше, чем " + viewAnTwo.name;
            if (viewAnOne.massa == viewAnTwo.massa) tbAnalize.Text = "животные весят одинаково";
        }

        private void ChangeUnit1 ()
        {
            viewAnOne.unit = cbUnit.SelectedItem.ToString();
            viewAnOne.massaGen = MassConverter.ConvertKilo(viewAnOne.massa, viewAnOne.unit);
            tbOne.Text = viewAnOne.view();
        }

        private void ChangeUnit2 ()
        {
            viewAnTwo.unit = cbUnit.SelectedItem.ToString();
            viewAnTwo.massaGen = MassConverter.ConvertKilo(viewAnTwo.massa, viewAnTwo.unit);
            tbTwo.Text = viewAnTwo.view();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOne.Items.AddRange(AnimalFactory.GetAnimalNames());
            cbTwo.Items.AddRange(AnimalFactory.GetAnimalNames());
            cbUnit.Items.AddRange(new[] { "kg", "g", "lb", "st" });
         }

        private void cbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAnOne = AnimalFactory.Create(cbOne.SelectedItem.ToString());
            if (cbUnit.SelectedItem != null) ChangeUnit1(); else tbOne.Text = "***Не выбраны единицы веса***";
            if (cbTwo.SelectedItem != null && cbUnit.SelectedItem != null) Analize();
        }

        private void cbTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAnTwo = AnimalFactory.Create(cbTwo.SelectedItem.ToString());
            if (cbUnit.SelectedItem != null) ChangeUnit2(); else tbTwo.Text = "***Не выбраны единицы веса***";
            if (cbOne.SelectedItem != null && cbUnit.SelectedItem != null) Analize();            
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOne.SelectedItem != null) ChangeUnit1();
            if (cbTwo.SelectedItem != null) ChangeUnit2();
            if (cbOne.SelectedItem != null && cbTwo.SelectedItem != null) Analize();
        }
    }
}
