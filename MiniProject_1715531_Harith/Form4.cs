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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<string>();
            string path = @"C:\Users\Harris\source\repos\MiniProject_1715531_Harith\path.txt";
            List<string[]> deleteDetail = new List<string[]>();
            foreach (string line in File.ReadAllLines(path).ToList())
            {
                Console.WriteLine(line);
                string[] items = line.Split(',');
                deleteDetail.Add(items);
            }
            for (var k = 0; k<deleteDetail.Count(); k++)
            {
                if (textBox1.Text == deleteDetail[k][0])
                {

                    deleteDetail.Remove(deleteDetail[k]);
                    MessageBox.Show("Successfully deleted user ID " + textBox1.Text);
                    
                }

            }
            textBox1.Clear();
            File.WriteAllText(path, String.Empty);
            foreach (var newList in deleteDetail)
            {
                string x = newList[0] + "," + newList[1] + "," + newList[2];
                temp.Add(x);//tukar name
               
            }
            File.AppendAllLines(path, temp);





            /*var studentID = deleteDetail.Select(s => s[0]).Where(s => s == name);*/
        }
    }
}
