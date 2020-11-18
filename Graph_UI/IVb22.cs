using System;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_UI
{
    public partial class IVb22 : Form
    {
        private Form1 form;
        public Graph g;
        public string v = "";
        public string u = "";
        public string k = "";

        public IVb22(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (g.Search_Key(textBox1.Text))
                {
                    v = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершины с названием " + textBox1.Text + " не существует!!!");
                    textBox1.Text = "";
                    v = "";
                    u = "";
                    k = "";
                }

                if (g.Search_Key(textBox2.Text))
                {
                    u = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершины с названием " + textBox2.Text + " не существует!!!");
                    textBox2.Text = "";
                    v = "";
                    u = "";
                    k = "";
                }

                int x = -1;
                try
                {
                    x = Convert.ToInt32(textBox3.Text);
                    if (x > 0) k = textBox3.Text;
                    else
                    {
                        MessageBox.Show("ОШИБКА!!! Введено неверное значение!!!");
                        textBox3.Text = "";
                        v = "";
                        u = "";
                        k = "";
                    }
                }
                catch
                {
                    MessageBox.Show("ОШИБКА!!! Введено неверное значение!!!");
                    textBox3.Text = "";
                    v = "";
                    u = "";
                    k = "";
                }
                if (x > 0) k = textBox3.Text;
                if (v != "" && u != "" && k != "")
                    this.Close();
            }
        }
    }
}
