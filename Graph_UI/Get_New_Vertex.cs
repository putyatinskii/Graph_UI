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
    public partial class Get_New_Vertex : Form
    {
        private Form1 form;
        public Graph g;
        public Get_New_Vertex(Form1 main, Graph g)
        {
            form = main;
            this.g = g;
            InitializeComponent();
        }
        private void button_get_new_vertex_Click(object sender, EventArgs e)
        {
            if (textBox_vertexname.Text != "")
            {
                if (g.Search_Key(textBox_vertexname.Text))
                {
                    MessageBox.Show("ОШИБКА!!! Вершина с таким названием уже существует!!! Придумайте другое название");
                }
                else
                {
                    g.Add_Vertex(textBox_vertexname.Text);
                    this.Close();
                }
                textBox_vertexname.Text = "";
            }
        }

        private void Get_New_Vertex_Load(object sender, EventArgs e)
        {

        }
    }
}
