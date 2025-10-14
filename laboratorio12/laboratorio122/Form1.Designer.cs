namespace laboratorio122
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_titulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btn_prom = new Button();
            btn_reset = new Button();
            btn_salir = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // lb_titulo
            // 
            lb_titulo.AutoSize = true;
            lb_titulo.Location = new Point(362, 75);
            lb_titulo.Name = "lb_titulo";
            lb_titulo.Size = new Size(88, 15);
            lb_titulo.TabIndex = 0;
            lb_titulo.Text = "Nota Promedio";
            lb_titulo.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 116);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Nota No.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 156);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota No.2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 197);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Nota No.3";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(405, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(405, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(405, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // btn_prom
            // 
            btn_prom.Location = new Point(268, 255);
            btn_prom.Name = "btn_prom";
            btn_prom.Size = new Size(75, 23);
            btn_prom.TabIndex = 7;
            btn_prom.Text = "Promedio";
            btn_prom.UseVisualStyleBackColor = true;
            btn_prom.Click += btn_prom_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(349, 255);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 8;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(430, 255);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 9;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 318);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "Nota Promedio:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(405, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(btn_salir);
            Controls.Add(btn_reset);
            Controls.Add(btn_prom);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb_titulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_titulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_prom;
        private Button btn_reset;
        private Button btn_salir;
        private Label label5;
        private TextBox textBox4;
    }
}
