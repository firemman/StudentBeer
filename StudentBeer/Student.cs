using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace StudentBeer
{
    public class Student
    {
        private string Student_name;
        private int Student_age;
        public Student(string n, int age) { Student_name = n; Student_age = age; }

        public void setStudentAge(int age) { Student_age = age; }
        public string getStudentName() { return Student_name; }
        public int getStudentAge() { return Student_age;}
        public void Student_beer(string sound_filename)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = sound_filename;
            sp.Load();
            sp.Play();
        }
    }
}
