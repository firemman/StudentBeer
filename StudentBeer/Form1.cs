using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentBeer
{
    public partial class Form1 : Form
    {
        Student Artem = new Student("Артём", 18);
        StudentIT Danil = new StudentIT("Данил", 25, 5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\VisualFiles\\hasbulla.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = "Имя студента: " + Artem.getStudentName() + ";\nВозраст студента: " + Artem.getStudentAge();
            label1.Font = new Font("Serif", 10, FontStyle.Bold);

            label2.Text = "Имя студента: " + Danil.getStudentName() + ";\nВозраст студента: " + Danil.getStudentAge();
            label2.Font = new Font("Serif", 10, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(Artem);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Danil.programming(Danil.getStazh());
            }
            else
                MessageBox.Show("Ошибка:\nИли не выбрана ни 1 галочка или выбраны обе галочки вместе\nИли выбран студент, который не умеет программировать.");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
