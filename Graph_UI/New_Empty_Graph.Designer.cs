namespace Graph_UI
{
    partial class New_Empty_Graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_graphname = new System.Windows.Forms.TextBox();
            this.button_new_graph = new System.Windows.Forms.Button();
            this.radioButton_Or = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Not_or = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Not_Weight = new System.Windows.Forms.RadioButton();
            this.radioButton_Weight = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя нового графа:";
            // 
            // textBox_graphname
            // 
            this.textBox_graphname.Location = new System.Drawing.Point(15, 68);
            this.textBox_graphname.Name = "textBox_graphname";
            this.textBox_graphname.Size = new System.Drawing.Size(185, 22);
            this.textBox_graphname.TabIndex = 1;
            // 
            // button_new_graph
            // 
            this.button_new_graph.Location = new System.Drawing.Point(223, 59);
            this.button_new_graph.Name = "button_new_graph";
            this.button_new_graph.Size = new System.Drawing.Size(75, 40);
            this.button_new_graph.TabIndex = 2;
            this.button_new_graph.Text = "Ввод";
            this.button_new_graph.UseVisualStyleBackColor = true;
            this.button_new_graph.Click += new System.EventHandler(this.button_new_graph_Click);
            // 
            // radioButton_Or
            // 
            this.radioButton_Or.AutoSize = true;
            this.radioButton_Or.Location = new System.Drawing.Point(6, 21);
            this.radioButton_Or.Name = "radioButton_Or";
            this.radioButton_Or.Size = new System.Drawing.Size(152, 21);
            this.radioButton_Or.TabIndex = 3;
            this.radioButton_Or.TabStop = true;
            this.radioButton_Or.Text = "Ориентированный";
            this.radioButton_Or.UseVisualStyleBackColor = true;
            this.radioButton_Or.CheckedChanged += new System.EventHandler(this.radioButton_Or_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Not_or);
            this.groupBox1.Controls.Add(this.radioButton_Or);
            this.groupBox1.Location = new System.Drawing.Point(15, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ориентация";
            // 
            // radioButton_Not_or
            // 
            this.radioButton_Not_or.AutoSize = true;
            this.radioButton_Not_or.Location = new System.Drawing.Point(6, 48);
            this.radioButton_Not_or.Name = "radioButton_Not_or";
            this.radioButton_Not_or.Size = new System.Drawing.Size(167, 21);
            this.radioButton_Not_or.TabIndex = 4;
            this.radioButton_Not_or.TabStop = true;
            this.radioButton_Not_or.Text = "Неориентированный";
            this.radioButton_Not_or.UseVisualStyleBackColor = true;
            this.radioButton_Not_or.CheckedChanged += new System.EventHandler(this.radioButton_Not_or_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Not_Weight);
            this.groupBox2.Controls.Add(this.radioButton_Weight);
            this.groupBox2.Location = new System.Drawing.Point(217, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вес";
            // 
            // radioButton_Not_Weight
            // 
            this.radioButton_Not_Weight.AutoSize = true;
            this.radioButton_Not_Weight.Location = new System.Drawing.Point(6, 48);
            this.radioButton_Not_Weight.Name = "radioButton_Not_Weight";
            this.radioButton_Not_Weight.Size = new System.Drawing.Size(129, 21);
            this.radioButton_Not_Weight.TabIndex = 1;
            this.radioButton_Not_Weight.TabStop = true;
            this.radioButton_Not_Weight.Text = "Невзвешенный";
            this.radioButton_Not_Weight.UseVisualStyleBackColor = true;
            this.radioButton_Not_Weight.CheckedChanged += new System.EventHandler(this.radioButton_Not_Weight_CheckedChanged);
            // 
            // radioButton_Weight
            // 
            this.radioButton_Weight.AutoSize = true;
            this.radioButton_Weight.Location = new System.Drawing.Point(6, 21);
            this.radioButton_Weight.Name = "radioButton_Weight";
            this.radioButton_Weight.Size = new System.Drawing.Size(113, 21);
            this.radioButton_Weight.TabIndex = 0;
            this.radioButton_Weight.TabStop = true;
            this.radioButton_Weight.Text = "Взвешенный";
            this.radioButton_Weight.UseVisualStyleBackColor = true;
            this.radioButton_Weight.CheckedChanged += new System.EventHandler(this.radioButton_Weight_CheckedChanged);
            // 
            // New_Empty_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 218);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_new_graph);
            this.Controls.Add(this.textBox_graphname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "New_Empty_Graph";
            this.Text = "Создание пустого графа";
            this.Load += new System.EventHandler(this.New_Empty_Graph_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_graphname;
        private System.Windows.Forms.Button button_new_graph;
        private System.Windows.Forms.RadioButton radioButton_Or;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Not_or;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Not_Weight;
        private System.Windows.Forms.RadioButton radioButton_Weight;
    }
}