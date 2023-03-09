namespace appAvanceAutomatas
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnalisisParentesis = new System.Windows.Forms.Button();
            this.lblAnalisisParentesis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnalisisOpera = new System.Windows.Forms.Button();
            this.lblAnalisisOpera = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnAnalisisParentesis
            // 
            this.btnAnalisisParentesis.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAnalisisParentesis.FlatAppearance.BorderSize = 3;
            this.btnAnalisisParentesis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisisParentesis.Location = new System.Drawing.Point(106, 157);
            this.btnAnalisisParentesis.Name = "btnAnalisisParentesis";
            this.btnAnalisisParentesis.Size = new System.Drawing.Size(165, 40);
            this.btnAnalisisParentesis.TabIndex = 1;
            this.btnAnalisisParentesis.Text = "ANALIZAR ( )";
            this.btnAnalisisParentesis.UseVisualStyleBackColor = true;
            this.btnAnalisisParentesis.Click += new System.EventHandler(this.btnAnalisisParentesis_Click);
            // 
            // lblAnalisisParentesis
            // 
            this.lblAnalisisParentesis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalisisParentesis.Location = new System.Drawing.Point(9, 214);
            this.lblAnalisisParentesis.Name = "lblAnalisisParentesis";
            this.lblAnalisisParentesis.Size = new System.Drawing.Size(378, 52);
            this.lblAnalisisParentesis.TabIndex = 2;
            this.lblAnalisisParentesis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(72, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "ANALIZADOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 69);
            this.panel1.TabIndex = 4;
            // 
            // btnAnalisisOpera
            // 
            this.btnAnalisisOpera.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAnalisisOpera.FlatAppearance.BorderSize = 3;
            this.btnAnalisisOpera.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisisOpera.Location = new System.Drawing.Point(106, 301);
            this.btnAnalisisOpera.Name = "btnAnalisisOpera";
            this.btnAnalisisOpera.Size = new System.Drawing.Size(165, 40);
            this.btnAnalisisOpera.TabIndex = 5;
            this.btnAnalisisOpera.Text = "ANALIZAR A+B";
            this.btnAnalisisOpera.UseVisualStyleBackColor = true;
            this.btnAnalisisOpera.Click += new System.EventHandler(this.btnAnalisisOpera_Click);
            // 
            // lblAnalisisOpera
            // 
            this.lblAnalisisOpera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalisisOpera.Location = new System.Drawing.Point(9, 364);
            this.lblAnalisisOpera.Name = "lblAnalisisOpera";
            this.lblAnalisisOpera.Size = new System.Drawing.Size(378, 52);
            this.lblAnalisisOpera.TabIndex = 6;
            this.lblAnalisisOpera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 462);
            this.Controls.Add(this.lblAnalisisOpera);
            this.Controls.Add(this.btnAnalisisOpera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnalisisParentesis);
            this.Controls.Add(this.btnAnalisisParentesis);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnalisisParentesis;
        private System.Windows.Forms.Label lblAnalisisParentesis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnalisisOpera;
        private System.Windows.Forms.Label lblAnalisisOpera;
    }
}

