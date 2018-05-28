using System;
using System.Linq;
using System.Windows.Forms;
using Test_2.Models;
using Test_2.Tools;

namespace Test_2
{

    public partial class Form1 : Form
    {
        private Animals viewAnOne;
        private Animals viewAnTwo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOne.Items.AddRange(AnimalsFactory.ListNamesAnimals());
            cbTwo.Items.AddRange(AnimalsFactory.ListNamesAnimals());
            cbUnit.Items.AddRange(MassaAnimals.ListUnitMass());
        }

        private void cbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAnOne = AnimalsFactory.CreateAnimals(cbOne.SelectedItem.ToString());
            tbOne.Text = MassaAnimals.MassaView(viewAnOne, cbUnit.SelectedItem);
            if (cbUnit.SelectedItem != null) tbAnalize.Text = MassaAnimals.MassaCompare(viewAnOne, viewAnTwo);
        }

        private void cbTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAnTwo = AnimalsFactory.CreateAnimals(cbTwo.SelectedItem.ToString());
            tbTwo.Text = MassaAnimals.MassaView(viewAnTwo, cbUnit.SelectedItem);
            if (cbUnit.SelectedItem != null) tbAnalize.Text = MassaAnimals.MassaCompare(viewAnOne, viewAnTwo);
        }

        private void tbTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAnalize_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbOne.Text = MassaAnimals.MassaView(viewAnOne, cbUnit.SelectedItem);
            tbTwo.Text = MassaAnimals.MassaView(viewAnTwo, cbUnit.SelectedItem);
            tbAnalize.Text = MassaAnimals.MassaCompare(viewAnOne, viewAnTwo);
        }
    }
}
