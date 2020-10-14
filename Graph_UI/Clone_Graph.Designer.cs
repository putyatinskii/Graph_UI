namespace Graph_UI
{
    partial class Clone_Graph
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
            this.textBox_Old_Graph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_New_Graph = new System.Windows.Forms.TextBox();
            this.button_Old_Graph = new System.Windows.Forms.Button();
            this.button__New_Graph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название графа, который нужно клонировать:";
            // 
            // textBox_Old_Graph
            // 
            this.textBox_Old_Graph.Location = new System.Drawing.Point(12, 57);
            this.textBox_Old_Graph.Name = "textBox_Old_Graph";
            this.textBox_Old_Graph.Size = new System.Drawing.Size(234, 22);
            this.textBox_Old_Graph.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите название нового графа:";
            // 
            // textBox_New_Graph
            // 
            this.textBox_New_Graph.Location = new System.Drawing.Point(12, 147);
            this.textBox_New_Graph.Name = "textBox_New_Graph";
            this.textBox_New_Graph.Size = new System.Drawing.Size(234, 22);
            this.textBox_New_Graph.TabIndex = 3;
            // 
            // button_Old_Graph
            // 
            this.button_Old_Graph.Location = new System.Drawing.Point(268, 48);
            this.button_Old_Graph.Name = "button_Old_Graph";
            this.button_Old_Graph.Size = new System.Drawing.Size(75, 40);
            this.button_Old_Graph.TabIndex = 4;
            this.button_Old_Graph.Text = "Ввод";
            this.button_Old_Graph.UseVisualStyleBackColor = true;
            this.button_Old_Graph.Click += new System.EventHandler(this.button_Old_Graph_Click);
            // 
            // button__New_Graph
            // 
            this.button__New_Graph.Location = new System.Drawing.Point(268, 138);
            this.button__New_Graph.Name = "button__New_Graph";
            this.button__New_Graph.Size = new System.Drawing.Size(75, 40);
            this.button__New_Graph.TabIndex = 5;
            this.button__New_Graph.Text = "Ввод";
            this.button__New_Graph.UseVisualStyleBackColor = true;
            this.button__New_Graph.Click += new System.EventHandler(this.button__New_Graph_Click);
            // 
            // Clone_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.button__New_Graph);
            this.Controls.Add(this.button_Old_Graph);
            this.Controls.Add(this.textBox_New_Graph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Old_Graph);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Clone_Graph";
            this.Text = "Клонирование графа";
            this.Load += new System.EventHandler(this.Clone_Graph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Old_Graph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_New_Graph;
        private System.Windows.Forms.Button button_Old_Graph;
        private System.Windows.Forms.Button button__New_Graph;
    }
}