namespace A1U4_numeroControlED3B
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
            txtDato = new TextBox();
            panelArbol = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtDato
            // 
            txtDato.Location = new Point(592, 39);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(150, 31);
            txtDato.TabIndex = 0;
            // 
            // panelArbol
            // 
            panelArbol.Location = new Point(45, 97);
            panelArbol.Name = "panelArbol";
            panelArbol.Size = new Size(697, 321);
            panelArbol.TabIndex = 1;
            panelArbol.Paint += panelArbol_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(45, 435);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 3;
            label1.Text = "Arbol Binario - ITSL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 45);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "Dato";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panelArbol);
            Controls.Add(txtDato);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDato;
        private Panel panelArbol;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
