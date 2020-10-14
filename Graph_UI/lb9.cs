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
    public partial class lb9 : Form
    {
        private Form1 form;
        public string str_old1 = "";
        public string str_old2 = "";
        public string str_new = "";
        List<string> str_keys = new List<string>();
        public lb9(Form1 main, List<string> str_keys)
        {
            form = main;
            this.str_keys = str_keys;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (str_keys.Contains(textBox1.Text))
                {
                    str_old1 = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Граф с названием " + textBox1.Text + " не существует!!!");
                    textBox1.Text = "";
                    str_old1 = "";
                    str_old2 = "";
                    str_new = "";
                }

                if (str_keys.Contains(textBox2.Text))
                {
                    str_old2 = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Граф с названием " + textBox2.Text + " не существует!!!");
                    textBox2.Text = "";
                    str_old1 = "";
                    str_old2 = "";
                    str_new = "";
                }

                if (str_keys.Contains(textBox3.Text))
                {
                    MessageBox.Show("ОШИБКА!!! Граф с названием " + textBox3.Text + " уже существует!!! Придумайте другое название");
                    textBox3.Text = "";
                    str_old1 = "";
                    str_old2 = "";
                    str_new = "";
                }
                else
                {
                    str_new = textBox3.Text;
                }
                if (str_old1 != "" && str_old2 != "" && str_new != "")
                    this.Close();
            }
        }
    }
}
