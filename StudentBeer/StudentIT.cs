using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentBeer
{
    public class StudentIT : Student, Interface1
    {
        private int stazh;
        public StudentIT(string n, int age, int stazh) : base(n, age) {
            this.stazh = stazh;
        }
        public int getStazh() { return stazh; }

        public void programming(int stazh) {
            MessageBox.Show("Студент программирует уже " + getStazh() + "лет.");
        }


    }
}
