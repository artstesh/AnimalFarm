using System;
using System.Linq;
using System.Windows.Forms;
using Test_2.Models;
using Test_2.Tools;

namespace Test_2
{
    
    public partial class Form1 : Form
    {
        private Animal[] _animals = new Animal[2];

        private void Analize ()
        {
            if (cbOne.SelectedItem == null && cbUnit.SelectedItem == null || _animals.Any(e => e == null)) return;
            var animals = _animals.OrderBy(e => e.massa).ToArray();
            if (animals[0].massa == animals[1].massa)
            {
                tbAnalize.Text = "животные весят одинаково";
                return;
            }
            tbAnalize.Text = animals[1].name + " весит больше, чем " + animals[0].name;
        }

        private void ChangeUnit1 ()
        {
            if (_animals[0] == null || cbUnit.SelectedItem == null) return;
            _animals[0].unit = cbUnit.SelectedItem.ToString();
            _animals[0].massaGen = MassConverter.ConvertKilo(_animals[0].massa, _animals[0].unit);
            tbOne.Text = _animals[0].view();
        }

        private void ChangeUnit2 ()
        {
            if (_animals[1] == null || cbUnit.SelectedItem == null) return;
            _animals[1].unit = cbUnit.SelectedItem.ToString();
            _animals[1].massaGen = MassConverter.ConvertKilo(_animals[1].massa, _animals[1].unit);
            tbTwo.Text = _animals[1].view();
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
            _animals[0] = AnimalFactory.Create(cbOne.SelectedItem.ToString());
            if (cbUnit.SelectedItem == null) tbOne.Text = "***Не выбраны единицы веса***";
            Analize();
        }

        private void cbTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _animals[1] = AnimalFactory.Create(cbTwo.SelectedItem.ToString());
            if (cbUnit.SelectedItem == null) tbTwo.Text = "***Не выбраны единицы веса***";
            Analize();            
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeUnit1();
            ChangeUnit2();
            Analize();
        }
    }
}
