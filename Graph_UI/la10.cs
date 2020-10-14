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
    public partial class la10 : Form
    {
        private Form1 form;
        public Graph g;

        public la10(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }

        private void la10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            textBox2.Text = "";
            if (g.Get_or == 'y')
            {
                s = textBox1.Text;
                if (g.Search_Key(s))
                {
                    List<string> list = new List<string>(g.indegree(s));
                    if (list.Count() != 0)
                    {
                        foreach (string elem in list)
                        {
                            textBox2.Text += elem + " ";
                        }
                    }
                    else
                    {
                        textBox2.Text = "Вершины не обнаружены";
                    }
                }
                else MessageBox.Show("Такого ключа не существует!");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка! Граф является неориентированным!");
                this.Close();
            }
        }
    }
}
