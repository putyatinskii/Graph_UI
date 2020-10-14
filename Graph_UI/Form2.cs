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
    public partial class Form2 : Form
    {
        private Form1 form;
        public string str = "";
        List<string> str_keys = new List<string>();
        public Form2(Form1 main, List<string> str_keys)
        {
            form = main;
            this.str_keys = str_keys;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (str_keys.Contains(textBox1.Text))
                {
                    MessageBox.Show("ОШИБКА!!! Граф с таким названием уже существует!!! Придумайте другое название");
                }
                else
                {
                    str = textBox1.Text;
                }
                textBox1.Text = "";
            }
            if (str != "") this.Close();
        }
    }
}
