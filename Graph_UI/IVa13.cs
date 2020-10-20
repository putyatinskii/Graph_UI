using System;
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
    public partial class IVa13 : Form
    {
        private Form1 form;
        public Graph g;
        public string u = "";
        public string v1 = "";
        public string v2 = "";

        public IVa13(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }

        private void IVa13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (g.Search_Key(textBox1.Text))
                {
                    u = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершины с названием " + textBox1.Text + " не существует!!!");
                    textBox1.Text = "";
                    u = "";
                    v1 = "";
                    v2 = "";
                }

                if (g.Search_Key(textBox2.Text))
                {
                    v1 = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершины с названием " + textBox2.Text + " не существует!!!");
                    textBox2.Text = "";
                    u = "";
                    v1 = "";
                    v2 = "";
                }

                if (g.Search_Key(textBox3.Text))
                {
                    v2 = textBox3.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершины с названием " + textBox3.Text + " не существует!!!");
                    textBox3.Text = "";
                    u = "";
                    v1 = "";
                    v2 = "";
                }
                if (u != "" && v1 != "" && v2 != "")
                    this.Close();
            }
        }
    }
}
