﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, Graph> Graphs = new Dictionary<string, Graph>();
        string cur_graph = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void File_Download_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> str_keys = new List<string>(Graphs.Keys);
                Form2 newForm = new Form2(this, str_keys);
                newForm.Owner = this;
                newForm.ShowDialog();
                if (newForm.str != "")
                {
                    Graphs.Add(newForm.str, new Graph(openFileDialog1.FileName));
                    listBox_Graphs.Items.Add(newForm.str);
                }
            }
        }

        private void Empty_graph_Click(object sender, EventArgs e)
        {
            List<string> str_keys = new List<string>(Graphs.Keys);
            New_Empty_Graph newForm = new New_Empty_Graph(this, str_keys);
            newForm.Owner = this;
            newForm.ShowDialog();
            if (newForm.str != "")
            {
                Graphs.Add(newForm.str, new Graph(newForm.Get_or, newForm.Get_weight));
                listBox_Graphs.Items.Add(newForm.str);
            }
        }

        private void Graph_clone_Click(object sender, EventArgs e)
        {
            if (Graphs.Count != 0)
            {
                List<string> str_keys = new List<string>(Graphs.Keys);
                Clone_Graph newForm = new Clone_Graph(this, str_keys);
                newForm.Owner = this;
                newForm.ShowDialog();
                if (newForm.str_new != "" && newForm.str_old != "")
                {
                    Graphs.Add(newForm.str_new, (Graph)Graphs[newForm.str_old].Clone());
                    listBox_Graphs.Items.Add(newForm.str_new);
                    //Graphs.Add(newForm.str_new, new Graph(Graphs[newForm.str_old]));
                }
            }
            else
            {
                MessageBox.Show("В программу не добавлен ни один граф");
            }
        }

        private void Out_File_Click(object sender, EventArgs e)
        {
            if (cur_graph != "")
            {
                Get_filename newForm = new Get_filename(this);
                newForm.Owner = this;
                newForm.ShowDialog();
                if (newForm.filename != "")
                {
                    Graphs[cur_graph].In_File(newForm.filename);
                }
            }
            else
            {
                MessageBox.Show("Граф не выбран!");
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label3.Text = "";
                cur_graph = textBox1.Text;
                if (!Graphs.ContainsKey(cur_graph))
                {
                    MessageBox.Show("ОШИБКА!!! Графа с таким названием не существует!!!");
                }
                else
                {
                    listBox_Cur_Graph.Items.Clear();
                    foreach (KeyValuePair<string, string> elem in Graphs[cur_graph].Get_Vertexes)
                        listBox_Cur_Graph.Items.Add(elem.Key + ":" + elem.Value);
                    if ((Graphs[cur_graph].Get_or == 'n' && Graphs[cur_graph].Get_weight == 'n'))
                        label3.Text = "Граф " + cur_graph + " — неориентированный, невзвешенный";
                    else if ((Graphs[cur_graph].Get_or == 'n' && Graphs[cur_graph].Get_weight == 'y'))
                        label3.Text = "Граф " + cur_graph + " — неориентированный, взвешенный";
                    else if ((Graphs[cur_graph].Get_or == 'y' && Graphs[cur_graph].Get_weight == 'n'))
                        label3.Text = "Граф " + cur_graph + " — ориентированный, невзвешенный";
                    else label3.Text = "Граф " + cur_graph + " — ориентированный, взвешенный";
                }
                textBox1.Text = "";
                
            }
        }

        private void listBox_Cur_Graph_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_vertex_Click(object sender, EventArgs e)
        {
            if (cur_graph != "")
            {
                Get_New_Vertex newForm = new Get_New_Vertex(this, Graphs[cur_graph]);
                newForm.Owner = this;
                newForm.ShowDialog();
                listBox_Cur_Graph.Items.Clear();
                foreach (KeyValuePair<string, string> elem in Graphs[cur_graph].Get_Vertexes)
                    listBox_Cur_Graph.Items.Add(elem.Key + ":" + elem.Value);
            }
            else
            {
                MessageBox.Show("Граф не выбран!");
            }
        }

        private void button_remove_vertex_Click(object sender, EventArgs e)
        {
            if (cur_graph != "")
            {
                Remove_Vertex newForm = new Remove_Vertex(this, Graphs[cur_graph]);
                newForm.Owner = this;
                newForm.ShowDialog();
                listBox_Cur_Graph.Items.Clear();
                foreach (KeyValuePair<string, string> elem in Graphs[cur_graph].Get_Vertexes)
                    listBox_Cur_Graph.Items.Add(elem.Key + ":" + elem.Value);
            }
            else
            {
                MessageBox.Show("Граф не выбран!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cur_graph != "")
            {
                if (Graphs[cur_graph].Get_weight == 'n')
                {
                    Add_Arc newForm = new Add_Arc(this, Graphs[cur_graph]);
                    newForm.Owner = this;
                    newForm.ShowDialog();
                    if (newForm.str1 != "" && newForm.str2 != "")
                    {
                        MessageBox.Show(Graphs[cur_graph].Add_Arc(newForm.str1, newForm.str2));
                    }
                }
                else
                {
                    Add_Arc_W newForm = new Add_Arc_W(this, Graphs[cur_graph]);
                    newForm.Owner = this;
                    newForm.ShowDialog();
                    if (newForm.str1 != "" && newForm.str2 != "" && newForm.str_w != "")
                    {
                        MessageBox.Show(Graphs[cur_graph].Add_Arc(newForm.str1, newForm.str2, newForm.str_w));
                    } 
                }
                listBox_Cur_Graph.Items.Clear();
                foreach (KeyValuePair<string, string> elem in Graphs[cur_graph].Get_Vertexes)
                    listBox_Cur_Graph.Items.Add(elem.Key + ":" + elem.Value);
            }
            else
            {
                MessageBox.Show("Граф не выбран!");
            }
        }

        private void button_Remove_Arc_Click(object sender, EventArgs e)
        {
            if (cur_graph != "")
            {
                Remove_Arc newForm = new Remove_Arc(this, Graphs[cur_graph]);
                newForm.Owner = this;
                newForm.ShowDialog();
                if (newForm.str1 != "" && newForm.str2 != "")
                {
                    MessageBox.Show(Graphs[cur_graph].Remove_Arc(newForm.str1, newForm.str2));
                }
                listBox_Cur_Graph.Items.Clear();
                foreach (KeyValuePair<string, string> elem in Graphs[cur_graph].Get_Vertexes)
                    listBox_Cur_Graph.Items.Add(elem.Key + ":" + elem.Value);
            }
            else
            {
                MessageBox.Show("Граф не выбран!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Задание la(6)":
                    if (cur_graph != "")
                    {
                        la6 newForm = new la6(this, Graphs[cur_graph]);
                        newForm.Owner = this;
                        newForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Граф не выбран!");
                    }
                    comboBox1.Text = "";
                    break;
                case "Задание la(10)":
                    if (cur_graph != "")
                    {
                        la10 newForm = new la10(this, Graphs[cur_graph]);
                        newForm.Owner = this;
                        newForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Граф не выбран!");
                    }
                    comboBox1.Text = "";
                    break;
                case "Задание lb(9)":
                    if (Graphs.Count > 1)
                    {
                        List<string> str_keys = new List<string>(Graphs.Keys);
                        lb9 newForm = new lb9(this, str_keys);
                        newForm.Owner = this;
                        newForm.ShowDialog();
                        if (newForm.str_old1 != "" && newForm.str_old2 != "" && newForm.str_new != "")
                        {
                            if (Graphs[newForm.str_old1].Get_or == 'n' && Graphs[newForm.str_old2].Get_or == 'n')
                            {
                                if (Graphs[newForm.str_old1].Get_weight == Graphs[newForm.str_old2].Get_weight)
                                {
                                    Graphs.Add(newForm.str_new, (Graph)Graphs[newForm.str_old1].Clone());
                                    Graphs[newForm.str_new].Symm_sub(Graphs[newForm.str_old2]);
                                    listBox_Graphs.Items.Add(newForm.str_new);
                                }
                                else
                                {
                                    MessageBox.Show("ОШИБКА!!! Один граф является взвешенным, а второй — нет!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("ОШИБКА!!! Как минимум один из графов является ориентированным");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("В программу не добавлено необходимое количество графов");
                    }
                    comboBox1.Text = "";
                    break;
            }
        }
    }
}