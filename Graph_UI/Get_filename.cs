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
    public partial class Get_filename : Form
    {
        private Form1 form;
        public string filename = "";
        public Get_filename(Form1 main)
        {
            form = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Get_name.Text != "")
            {
                filename = Get_name.Text;
                Get_name.Text = "";
                this.Close();
            }
        }

        private void Get_filename_Load(object sender, EventArgs e)
        {

        }
    }
}
