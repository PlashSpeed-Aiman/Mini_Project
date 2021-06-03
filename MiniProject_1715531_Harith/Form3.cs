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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ReadStudentDetail();
        }
        private void ReadStudentDetail()
        {
            string path = @Directory.GetCurrentDirectory() + "\\path.txt";
            //List<string> lines = new List<string>();
            List<MechaStudent> studentDetail = new List<MechaStudent>();


            foreach (string line in File.ReadAllLines(path).ToList())
            {
                //MCT1,1729963,Aiman // [MCT1,1729963,Aiman] 
                string[] items = line.Split(',');
                ///string[] items = line.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
               /* MechaStudent data = new MechaStudent(items[0], items[1], items[2]);*/
                var itm = new ListViewItem(items);
                listView1.Items.Add(itm);

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string path = @"C:\Users\Harris\source\repos\MiniProject_1715531_Harith\path.txt";
            ListViewItem itm;
            List<string> lines = new List<string>();
            List<MechaStudent> studentDetail = new List<MechaStudent>();
       
            foreach (string line in File.ReadAllLines(path).ToList())
            {
               
                Console.WriteLine(line);
                string[] items = line.Split(',');
                ///string[] items = line.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
/*                MechaStudent data = new MechaStudent(items[0], items[1], items[2]);
*/                itm = new ListViewItem(items);
                listView1.Items.Add(itm);
              
            }
            /*for (var j = 0; j<studentDetail.Count(); j++)
            {
                listView1.Columns.Add("ID", studentDetail[j].ID);
                listView1.Columns.Add("Matric", studentDetail[j].Matric);
                listView1.Columns.Add("Name", studentDetail[j].Name);

            }*/
            /*    List<string> inContents = new List<string>();
                string detail;
                for (var j = 0; j < studentDetail.Count(); j++)
                {
                    detail = studentDetail[j].ID + " " + studentDetail[j].Matric + " " + studentDetail[j].Name;
                    listView1.Columns.Add("ID",studentDetail[j].ID);
                }
              listView1.*/



        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
