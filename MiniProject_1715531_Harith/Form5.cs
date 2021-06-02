using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniProject_1715531_Harith
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = @Directory.GetCurrentDirectory() + "\\path.txt";
            List<MechaStudent> findDetail = new List<MechaStudent>();

            foreach (string line in File.ReadAllLines(path).ToList())
            {

                string[] items = line.Split(',');
                findDetail.Add(new MechaStudent() {ID = items[0], Matric = items[1], Name = items[2]});

            }

            /*List<MechaStudent> FindStudent = findDetail.Where(x => x.Name == textBox1.Text).ToList();*/
            var query = findDetail.Where(x => x.Name.Contains(textBox1.Text))
                .Select(x => new {name = x.Name, id = x.ID, matric = x.Matric});

            //check if IEnumerable is not empty
            if (!query.Any())
            {
                var stringBuilder = new StringBuilder();
                foreach (var name in query)
                {
                    stringBuilder.Append(name.name + " " + name.id + " " + name.matric + "\n");
                }

                MessageBox.Show(stringBuilder.ToString());
            }
            else
            {
                MessageBox.Show("User Not Found!");
            }






        }
    }
}

