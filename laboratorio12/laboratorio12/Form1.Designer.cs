namespace laboratorio12
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_velocidad = new TextBox();
            tb_tiempo = new TextBox();
            btn_calcular = new Button();
            btn_limpiar = new Button();
            btn_salir = new Button();
            label4 = new Label();
            tb_resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 79);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "calcular distancia recorrida";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 110);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "velocidad en km/h:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 149);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "tiempo en horas:";
            // 
            // tb_velocidad
            // 
            tb_velocidad.Location = new Point(428, 110);
            tb_velocidad.Name = "tb_velocidad";
            tb_velocidad.Size = new Size(100, 23);
            tb_velocidad.TabIndex = 3;
            tb_velocidad.TextChanged += tb_velocidad_TextChanged;
            // 
            // tb_tiempo
            // 
            tb_tiempo.Location = new Point(428, 149);
            tb_tiempo.Name = "tb_tiempo";
            tb_tiempo.Size = new Size(100, 23);
            tb_tiempo.TabIndex = 4;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(290, 206);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(75, 23);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(371, 206);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 6;
            btn_limpiar.Text = "limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(453, 206);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 263);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "resultado:";
            // 
            // tb_resultado
            // 
            tb_resultado.Location = new Point(428, 263);
            tb_resultado.Name = "tb_resultado";
            tb_resultado.Size = new Size(100, 23);
            tb_resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_resultado);
            Controls.Add(label4);
            Controls.Add(btn_salir);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_calcular);
            Controls.Add(tb_tiempo);
            Controls.Add(tb_velocidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_velocidad;
        private TextBox tb_tiempo;
        private Button btn_calcular;
        private Button btn_limpiar;
        private Button btn_salir;
        private Label label4;
        private TextBox tb_resultado;
    }
}
