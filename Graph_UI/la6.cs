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
    public partial class la6 : Form
    {
        private Form1 form;
        public Graph g;

        public la6(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }

        private void la6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g.Get_or == 'n')
            {
                textBox1.Text = "";
                List<string> list = new List<string>(g.vertex_one_degree());
                if (list.Count() != 0)
                {
                    foreach (string elem in list)
                    {
                        textBox1.Text += elem + " ";
                    }
                }
                else
                {
                    textBox1.Text = "Вершины 1-ой степени не найдены";
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Граф является ориентированным!");
                this.Close();
            }
        }
    }
}
