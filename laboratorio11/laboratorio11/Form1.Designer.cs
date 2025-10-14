namespace laboratorio11
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
            btnClickThis = new Button();
            lblHelloWorld = new Label();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(439, 246);
            btnClickThis.Margin = new Padding(3, 4, 3, 4);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(86, 31);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click this";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(452, 281);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(53, 20);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "Label1";
            lblHelloWorld.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 600);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickThis);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label lblHelloWorld;
    }
}
