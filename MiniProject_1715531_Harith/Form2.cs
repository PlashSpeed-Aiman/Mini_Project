using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1715531_Harith
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

      

        private void button5_Click_1(object sender, EventArgs e)
        {
            string path = @Directory.GetCurrentDirectory() + "\\path.txt";;
            //string outFile = @"C:\Users\Harris\source\repos\MiniProject_1715531_Harith\outFile.txt";
            
            List<MechaStudent> students = new List<MechaStudent>();
            
            students.Add(new MechaStudent() { ID = textBox1.Text , Name = textBox3.Text , Matric = textBox2.Text });

            List<string> outContents = new List<string>();

            for (var i = 0; i < students.Count(); i++)
            {
                string stuff = students[i].ID + "," + students[i].Matric + "," + students[i].Name;
                outContents.Add(stuff);
            }
            File.AppendAllLines(path, outContents);
            

            MessageBox.Show("Successfully added user " + textBox3.Text + " with ID " + textBox1.Text);
            Clear_Text();
            

        }
        private void Clear_Text()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
