using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    public partial class Form1 : Form
    {
        int count = 0;
        Task[] task = new Task[500];
        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure figure;

            if (x_textBox.Text != "" && y_textBox.Text != "" && rad_textBox.Text != "")
            {
                figure = new Circle(Convert.ToInt32(x_textBox.Text),Convert.ToInt32(y_textBox.Text), Convert.ToInt32(rad_textBox.Text));

                Task task = new Task(() =>
                {
                    while (true)
                    {
                        if (figure.x >= 1000)
                        {

                            break;
                        }
                        figure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        this.Invoke(new MethodInvoker(delegate {
                            pictureBox1.Refresh();
                        }));
                    }
                });
                task.Start();

            }
            if (x_textBox.Text != "" && y_textBox.Text != "" && sideLen_textBox.Text != "")
            {
                figure= new Square(Convert.ToInt32(x_textBox.Text), Convert.ToInt32(y_textBox.Text), Convert.ToInt32(sideLen_textBox.Text));

                Task task2 = new Task(() =>
                {
                    while (true)
                    {
                        if (figure.x >= 1000)
                        {

                            break;
                        }
                        figure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        this.Invoke(new MethodInvoker(delegate {
                            pictureBox1.Refresh();
                        }));
                    }
                });
                task2.Start();

            }
            if (x_textBox.Text != "" && y_textBox.Text != "" && verLen_textBox.Text != "" && horLen_textBox.Text != "")
            {
                figure = new Rhomb(Convert.ToInt32(x_textBox.Text), Convert.ToInt32(y_textBox.Text),                Convert.ToInt32(horLen_textBox.Text), Convert.ToInt32(verLen_textBox.Text));

                Task task3 = new Task(() =>
                {
                    while (true)
                    {
                        if (figure.x >= 1000)
                        {

                            break;
                        }
                        figure.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        this.Invoke(new MethodInvoker(delegate {
                            pictureBox1.Refresh();
                        }));
                    }
                });

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rad_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
