using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using databaseStudensStady2.DB;
using databaseStudensStady2.Models;

namespace databaseStudensStady2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbListStudents.Text = "";
            var context = new DataContext();
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                tbListStudents.Text += student.Id + " " + student.Name + System.Environment.NewLine;
            }
        }

        private void tbListStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var context = new DataContext();
            var student = new Student();
            student.Name = tbName.Text.ToString();
            student.Group = tbGroup.Text.ToString();
            context.Students.Add(student);
            context.SaveChanges();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            var idSTR = tbDelete.Text.ToString();
            var id = int.Parse(idSTR);
            var context = new DataContext();
            var student = context.Students.First(s => s.Id == id);
            context.Students.Remove(student);
            context.SaveChanges();

        }
    }
}
