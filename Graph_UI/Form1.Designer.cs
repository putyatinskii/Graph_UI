namespace Graph_UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.File_Download = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Empty_graph = new System.Windows.Forms.Button();
            this.Graph_clone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Graphs = new System.Windows.Forms.ListBox();
            this.Out_File = new System.Windows.Forms.Button();
            this.groupBox_Add_Arc = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Remove_Arc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_remove_vertex = new System.Windows.Forms.Button();
            this.button_add_vertex = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Cur_Graph = new System.Windows.Forms.ListBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_Add_Arc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // File_Download
            // 
            this.File_Download.Location = new System.Drawing.Point(6, 56);
            this.File_Download.Name = "File_Download";
            this.File_Download.Size = new System.Drawing.Size(150, 68);
            this.File_Download.TabIndex = 0;
            this.File_Download.Text = "Загрузить данные из файла";
            this.File_Download.UseVisualStyleBackColor = true;
            this.File_Download.Click += new System.EventHandler(this.File_Download_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Empty_graph
            // 
            this.Empty_graph.Location = new System.Drawing.Point(6, 152);
            this.Empty_graph.Name = "Empty_graph";
            this.Empty_graph.Size = new System.Drawing.Size(150, 68);
            this.Empty_graph.TabIndex = 1;
            this.Empty_graph.Text = "Создать пустой граф";
            this.Empty_graph.UseVisualStyleBackColor = true;
            this.Empty_graph.Click += new System.EventHandler(this.Empty_graph_Click);
            // 
            // Graph_clone
            // 
            this.Graph_clone.Location = new System.Drawing.Point(6, 248);
            this.Graph_clone.Name = "Graph_clone";
            this.Graph_clone.Size = new System.Drawing.Size(150, 68);
            this.Graph_clone.TabIndex = 2;
            this.Graph_clone.Text = "Клонировать существующий граф";
            this.Graph_clone.UseVisualStyleBackColor = true;
            this.Graph_clone.Click += new System.EventHandler(this.Graph_clone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.File_Download);
            this.groupBox1.Controls.Add(this.listBox_Graphs);
            this.groupBox1.Controls.Add(this.Graph_clone);
            this.groupBox1.Controls.Add(this.Empty_graph);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 461);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание графа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список графов:";
            // 
            // listBox_Graphs
            // 
            this.listBox_Graphs.FormattingEnabled = true;
            this.listBox_Graphs.ItemHeight = 16;
            this.listBox_Graphs.Location = new System.Drawing.Point(179, 56);
            this.listBox_Graphs.Name = "listBox_Graphs";
            this.listBox_Graphs.Size = new System.Drawing.Size(191, 372);
            this.listBox_Graphs.TabIndex = 6;
            // 
            // Out_File
            // 
            this.Out_File.Location = new System.Drawing.Point(192, 152);
            this.Out_File.Name = "Out_File";
            this.Out_File.Size = new System.Drawing.Size(150, 50);
            this.Out_File.TabIndex = 4;
            this.Out_File.Text = "Вывести в файл";
            this.Out_File.UseVisualStyleBackColor = true;
            this.Out_File.Click += new System.EventHandler(this.Out_File_Click);
            // 
            // groupBox_Add_Arc
            // 
            this.groupBox_Add_Arc.Controls.Add(this.groupBox2);
            this.groupBox_Add_Arc.Controls.Add(this.label4);
            this.groupBox_Add_Arc.Controls.Add(this.button_Remove_Arc);
            this.groupBox_Add_Arc.Controls.Add(this.button1);
            this.groupBox_Add_Arc.Controls.Add(this.button_remove_vertex);
            this.groupBox_Add_Arc.Controls.Add(this.button_add_vertex);
            this.groupBox_Add_Arc.Controls.Add(this.label3);
            this.groupBox_Add_Arc.Controls.Add(this.Out_File);
            this.groupBox_Add_Arc.Controls.Add(this.listBox_Cur_Graph);
            this.groupBox_Add_Arc.Controls.Add(this.Enter);
            this.groupBox_Add_Arc.Controls.Add(this.label1);
            this.groupBox_Add_Arc.Controls.Add(this.textBox1);
            this.groupBox_Add_Arc.Location = new System.Drawing.Point(405, 12);
            this.groupBox_Add_Arc.Name = "groupBox_Add_Arc";
            this.groupBox_Add_Arc.Size = new System.Drawing.Size(584, 461);
            this.groupBox_Add_Arc.TabIndex = 5;
            this.groupBox_Add_Arc.TabStop = false;
            this.groupBox_Add_Arc.Text = "Работа с графом";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(352, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задания:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Задание la(6)",
            "Задание la(10)",
            "Задание lb(9)"});
            this.comboBox1.Location = new System.Drawing.Point(6, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Информация о графе:";
            // 
            // button_Remove_Arc
            // 
            this.button_Remove_Arc.Location = new System.Drawing.Point(192, 384);
            this.button_Remove_Arc.Name = "button_Remove_Arc";
            this.button_Remove_Arc.Size = new System.Drawing.Size(150, 50);
            this.button_Remove_Arc.TabIndex = 11;
            this.button_Remove_Arc.Text = "Удалить ребро(дугу)";
            this.button_Remove_Arc.UseVisualStyleBackColor = true;
            this.button_Remove_Arc.Click += new System.EventHandler(this.button_Remove_Arc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить ребро(дугу)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_remove_vertex
            // 
            this.button_remove_vertex.Location = new System.Drawing.Point(192, 268);
            this.button_remove_vertex.Name = "button_remove_vertex";
            this.button_remove_vertex.Size = new System.Drawing.Size(150, 50);
            this.button_remove_vertex.TabIndex = 6;
            this.button_remove_vertex.Text = "Удалить вершину";
            this.button_remove_vertex.UseVisualStyleBackColor = true;
            this.button_remove_vertex.Click += new System.EventHandler(this.button_remove_vertex_Click);
            // 
            // button_add_vertex
            // 
            this.button_add_vertex.Location = new System.Drawing.Point(192, 210);
            this.button_add_vertex.Name = "button_add_vertex";
            this.button_add_vertex.Size = new System.Drawing.Size(150, 50);
            this.button_add_vertex.TabIndex = 10;
            this.button_add_vertex.Text = "Добавить вершину";
            this.button_add_vertex.UseVisualStyleBackColor = true;
            this.button_add_vertex.Click += new System.EventHandler(this.button_add_vertex_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // listBox_Cur_Graph
            // 
            this.listBox_Cur_Graph.FormattingEnabled = true;
            this.listBox_Cur_Graph.HorizontalScrollbar = true;
            this.listBox_Cur_Graph.ItemHeight = 16;
            this.listBox_Cur_Graph.Location = new System.Drawing.Point(9, 152);
            this.listBox_Cur_Graph.Name = "listBox_Cur_Graph";
            this.listBox_Cur_Graph.Size = new System.Drawing.Size(174, 276);
            this.listBox_Cur_Graph.TabIndex = 9;
            this.listBox_Cur_Graph.SelectedIndexChanged += new System.EventHandler(this.listBox_Cur_Graph_SelectedIndexChanged);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(192, 47);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 40);
            this.Enter.TabIndex = 8;
            this.Enter.Text = "Ввод";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите название графа:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 504);
            this.Controls.Add(this.groupBox_Add_Arc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Конструктор графов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Add_Arc.ResumeLayout(false);
            this.groupBox_Add_Arc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button File_Download;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Empty_graph;
        private System.Windows.Forms.Button Graph_clone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Out_File;
        private System.Windows.Forms.GroupBox groupBox_Add_Arc;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_Graphs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Cur_Graph;
        private System.Windows.Forms.Button button_add_vertex;
        private System.Windows.Forms.Button button_remove_vertex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Remove_Arc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

