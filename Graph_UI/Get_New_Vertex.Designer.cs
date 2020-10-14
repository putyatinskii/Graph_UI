namespace Graph_UI
{
    partial class Get_New_Vertex
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
            this.textBox_vertexname = new System.Windows.Forms.TextBox();
            this.button_get_new_vertex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название новой выршины:";
            // 
            // textBox_vertexname
            // 
            this.textBox_vertexname.Location = new System.Drawing.Point(15, 64);
            this.textBox_vertexname.Name = "textBox_vertexname";
            this.textBox_vertexname.Size = new System.Drawing.Size(239, 22);
            this.textBox_vertexname.TabIndex = 1;
            // 
            // button_get_new_vertex
            // 
            this.button_get_new_vertex.Location = new System.Drawing.Point(270, 55);
            this.button_get_new_vertex.Name = "button_get_new_vertex";
            this.button_get_new_vertex.Size = new System.Drawing.Size(75, 40);
            this.button_get_new_vertex.TabIndex = 2;
            this.button_get_new_vertex.Text = "Ввод";
            this.button_get_new_vertex.UseVisualStyleBackColor = true;
            this.button_get_new_vertex.Click += new System.EventHandler(this.button_get_new_vertex_Click);
            // 
            // Get_New_Vertex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 141);
            this.Controls.Add(this.button_get_new_vertex);
            this.Controls.Add(this.textBox_vertexname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Get_New_Vertex";
            this.Text = "Добавление новой вершины";
            this.Load += new System.EventHandler(this.Get_New_Vertex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vertexname;
        private System.Windows.Forms.Button button_get_new_vertex;
    }
}