using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_1715531_Harith
{

    public class MechaStudent
    {
        public MechaStudent(string ID,string Matric, string Name) {
            this.ID = ID;
            this.Matric = Matric;
            this.Name = Name;
                }
        public MechaStudent() { }
        public string ID { get; set; }
        public string Matric { get; set; }
        public string Name { get; set; }
        /*{
            this.ID = ID;
            this.Matric = Matric;
            this.Name = Name;
        }*/
    }
   


}
