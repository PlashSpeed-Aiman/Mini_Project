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
            string path = @Directory.GetCurrentDirectory() + "\\path.txt";
            List<String> temp = new List<string>();
            List<string[]> deleteDetail = new List<string[]>();
            foreach (string line in File.ReadAllLines(path).ToList())
            {
                Console.WriteLine(line);
                string[] items = line.Split(',');
                deleteDetail.Add(items);
            }

            bool not_Found = false;
            for (var k = 0; k<deleteDetail.Count(); k++)
            {
                if (deleteDetail[k][0].Contains(textBox1.Text))
                {
                    deleteDetail.Remove(deleteDetail[k]);
                    MessageBox.Show("Successfully deleted user ID " + textBox1.Text);
                    break;
                }
                else
                {
                    not_Found = true;
                }

            }

            if (not_Found)
            {
                MessageBox.Show("No User Found");
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
