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
    public partial class Remove_Arc : Form
    {
        private Form1 form;
        public Graph g;
        public string str1 = "";
        public string str2 = "";
        public Remove_Arc(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }

        private void Remove_Arc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (g.Search_Key(textBox1.Text))
                {
                    str1 = textBox1.Text;
                    if (str2 != "") this.Close();
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершина с таким названием не существует!!! Придумайте другое название");
                }
                textBox1.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (g.Search_Key(textBox2.Text))
                {
                    str2 = textBox2.Text;
                    if (str1 != "") this.Close();
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершина с таким названием не существует!!! Придумайте другое название");
                }
                textBox2.Text = "";
            }
        }
    }
}
