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
    public partial class Remove_Vertex : Form
    {
        private Form1 form;
        public Graph g;
        public Remove_Vertex(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }

        private void Remove_Vertex_Load(object sender, EventArgs e)
        {

        }

        private void button_remove_vertex_Click(object sender, EventArgs e)
        {
            if (textBox_get_vertex.Text != "")
            {
                if (g.Search_Key(textBox_get_vertex.Text))
                {
                    g.Remove_Vertex(textBox_get_vertex.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Вершины с таким названием не существует!!!");
                }
                textBox_get_vertex.Text = "";
            }
        }
    }
}
