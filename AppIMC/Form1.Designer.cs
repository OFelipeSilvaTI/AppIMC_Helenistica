namespace AppIMC
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
            lblAltura = new Label();
            lblPeso = new Label();
            lblMassa = new Label();
            lblKg = new Label();
            btCalcular = new Button();
            label1 = new Label();
            lblIMC = new Label();
            lblClassif = new Label();
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            SuspendLayout();
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = SystemColors.Control;
            lblAltura.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltura.Location = new Point(257, 81);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(85, 32);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            lblAltura.Click += lblAltura_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(268, 123);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(74, 32);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso:";
            // 
            // lblMassa
            // 
            lblMassa.AutoSize = true;
            lblMassa.Font = new Font("Swis721 Cn BT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMassa.Location = new Point(478, 94);
            lblMassa.Name = "lblMassa";
            lblMassa.Size = new Size(18, 16);
            lblMassa.TabIndex = 4;
            lblMassa.Text = "m";
            lblMassa.Click += label1_Click_1;
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Font = new Font("Swis721 Cn BT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKg.Location = new Point(474, 138);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(22, 16);
            lblKg.TabIndex = 6;
            lblKg.Text = "Kg";
            // 
            // btCalcular
            // 
            btCalcular.Enabled = false;
            btCalcular.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold);
            btCalcular.Location = new Point(289, 183);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(166, 39);
            btCalcular.TabIndex = 7;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 245);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 8;
            label1.Text = "IMC:";
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIMC.Location = new Point(388, 245);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(29, 32);
            lblIMC.TabIndex = 9;
            lblIMC.Text = "X";
            lblIMC.Click += lblIMC_Click;
            // 
            // lblClassif
            // 
            lblClassif.AutoSize = true;
            lblClassif.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassif.Location = new Point(272, 349);
            lblClassif.Name = "lblClassif";
            lblClassif.Size = new Size(191, 32);
            lblClassif.TabIndex = 10;
            lblClassif.Text = "BURACO NEGRO";
            lblClassif.Click += label2_Click;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold);
            numAltura.Location = new Point(348, 79);
            numAltura.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(120, 39);
            numAltura.TabIndex = 11;
            numAltura.ValueChanged += numAltura_ValueChanged_1;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Font = new Font("Swis721 Cn BT", 20F, FontStyle.Bold);
            numPeso.Location = new Point(348, 123);
            numPeso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(120, 39);
            numPeso.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.unnamed;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(numPeso);
            Controls.Add(numAltura);
            Controls.Add(lblClassif);
            Controls.Add(lblIMC);
            Controls.Add(label1);
            Controls.Add(btCalcular);
            Controls.Add(lblKg);
            Controls.Add(lblMassa);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de IMC Helenistica";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltura;
        private Label lblPeso;
        private Label lblMassa;
        private Label lblKg;
        private Button btCalcular;
        private Label label1;
        private Label lblIMC;
        private Label lblClassif;
        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
    }
}
