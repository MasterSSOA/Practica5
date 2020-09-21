using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>()
            { 
                new Person{ Name = "Hola",},
                 new Person{ Name = "Hola2",}
            };

            var list = new BindingList<Person>(people);
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows[3].Cells[1].Value = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        class Person 
        { 
            public string Name { get; set; }
            public string LastName { get; set; }
        }

    }
}
