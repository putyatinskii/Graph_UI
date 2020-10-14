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
    public partial class Clone_Graph : Form
    {
        private Form1 form;
        public string str_old = "";
        public string str_new = "";
        List<string> str_keys = new List<string>();
        public Clone_Graph(Form1 main, List<string> str_keys)
        {
            form = main;
            this.str_keys = str_keys;
            InitializeComponent();
        }

        private void button_Old_Graph_Click(object sender, EventArgs e)
        {
            if (textBox_Old_Graph.Text != "")
            {
                if (str_keys.Contains(textBox_Old_Graph.Text))
                {
                    str_old = textBox_Old_Graph.Text;
                    if (str_new != "") this.Close();
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Граф с таким названием не существует!!!");
                }
                textBox_Old_Graph.Text = "";
            }
        }

        private void button__New_Graph_Click(object sender, EventArgs e)
        {
            if (textBox_New_Graph.Text != "")
            {
                if (str_keys.Contains(textBox_New_Graph.Text))
                {
                    MessageBox.Show("ОШИБКА!!! Граф с таким названием уже существует!!! Придумайте другое название");
                }
                else
                {
                    str_new = textBox_New_Graph.Text;
                    if (str_old != "") this.Close();
                }
                textBox_New_Graph.Text = "";
            }
        }

        private void Clone_Graph_Load(object sender, EventArgs e)
        {

        }
    }
}
