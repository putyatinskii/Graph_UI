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
    public partial class New_Empty_Graph : Form
    {
        private Form1 form;
        public string str = "";
        char or = 'n';
        char weight = 'n';
        List<string> str_keys = new List<string>();
        public New_Empty_Graph(Form1 main, List<string> str_keys)
        {
            form = main;
            this.str_keys = str_keys;
            InitializeComponent();
        }

        public char Get_or
        {
            get
            {
                return or;
            }
        }

        public char Get_weight
        {
            get
            {
                return weight;
            }
        }

        private void New_Empty_Graph_Load(object sender, EventArgs e)
        {
            radioButton_Not_or.Checked = true;
            radioButton_Not_Weight.Checked = true;
        }

        private void button_new_graph_Click(object sender, EventArgs e)
        {
             if (textBox_graphname.Text != "")
            {
                if (str_keys.Contains(textBox_graphname.Text))
                {
                    MessageBox.Show("ОШИБКА!!! Граф с таким названием уже существует!!! Придумайте другое название");
                }
                else
                {
                    str = textBox_graphname.Text;

                }
                textBox_graphname.Text = "";
            }
            if (str != "") this.Close();
        }

        private void radioButton_Or_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                or = 'y';
            }
        }

        private void radioButton_Not_or_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                or = 'n';
            }
        }

        private void radioButton_Weight_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                weight = 'y';
            }
        }

        private void radioButton_Not_Weight_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                weight = 'n';
            }
        }
    }
}
