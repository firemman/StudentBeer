using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection.Emit;

namespace StudentBeer
{
    public partial class Form2 : Form
    {
        public Student Artem;
        //Student Artem = new Student("Артём", 18);
        public Form2(Student artem)
        {
            InitializeComponent();
            Artem = artem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\VisualFiles\\magnit2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            button1.Text = "Купить сухарики 'Кириешки'";
            button2.Text = "Купить пиво";
            label1.Text = "Введите новый возраст студента:";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем с покупкой, заходите ещё!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Artem.getStudentAge() >= 18)
            {
                Artem.Student_beer("D:\\VisualFiles\\openPivo.wav");
                MessageBox.Show("Поздравляем с покупкой, заходите ещё!");
            }
            else
            {
                MessageBox.Show("Вам ещё нет 18-ти!\nПриходите как исполнится.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Artem.setStudentAge(Convert.ToInt32(textBox1.Text));
            }
        }

        /*private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Artem.setStudentAge(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Возраст студента успешно изменён.");
            }
        }
        */
    }
}
