namespace Graph_UI
{
    partial class Remove_Vertex
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
            this.textBox_get_vertex = new System.Windows.Forms.TextBox();
            this.button_remove_vertex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя удаляемой вершины:";
            // 
            // textBox_get_vertex
            // 
            this.textBox_get_vertex.Location = new System.Drawing.Point(12, 75);
            this.textBox_get_vertex.Name = "textBox_get_vertex";
            this.textBox_get_vertex.Size = new System.Drawing.Size(233, 22);
            this.textBox_get_vertex.TabIndex = 1;
            // 
            // button_remove_vertex
            // 
            this.button_remove_vertex.Location = new System.Drawing.Point(267, 66);
            this.button_remove_vertex.Name = "button_remove_vertex";
            this.button_remove_vertex.Size = new System.Drawing.Size(75, 40);
            this.button_remove_vertex.TabIndex = 2;
            this.button_remove_vertex.Text = "Ввод";
            this.button_remove_vertex.UseVisualStyleBackColor = true;
            this.button_remove_vertex.Click += new System.EventHandler(this.button_remove_vertex_Click);
            // 
            // Remove_Vertex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 176);
            this.Controls.Add(this.button_remove_vertex);
            this.Controls.Add(this.textBox_get_vertex);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Remove_Vertex";
            this.Text = "Удаление вершины";
            this.Load += new System.EventHandler(this.Remove_Vertex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_get_vertex;
        private System.Windows.Forms.Button button_remove_vertex;
    }
}