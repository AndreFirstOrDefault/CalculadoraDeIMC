namespace CalculadoraDeIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxPeso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxAltura = new TextBox();
            label5 = new Label();
            buttonCalcular = new Button();
            labelResultado = new Label();
            labelMensagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 43);
            label1.TabIndex = 0;
            label1.Text = "PREENCHA OS CAMPOS E CLIQUE NO BOTÃO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPeso
            // 
            textBoxPeso.Cursor = Cursors.IBeam;
            textBoxPeso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPeso.ForeColor = Color.Red;
            textBoxPeso.Location = new Point(106, 66);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(207, 33);
            textBoxPeso.TabIndex = 1;
            textBoxPeso.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(88, 34);
            label2.TabIndex = 2;
            label2.Text = "PESO: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 64);
            label3.Name = "label3";
            label3.Size = new Size(108, 34);
            label3.TabIndex = 3;
            label3.Text = "Kilogramas";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(88, 34);
            label4.TabIndex = 4;
            label4.Text = "ALTURA: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Cursor = Cursors.IBeam;
            textBoxAltura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAltura.ForeColor = Color.Red;
            textBoxAltura.Location = new Point(106, 116);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(207, 33);
            textBoxAltura.TabIndex = 5;
            textBoxAltura.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(319, 114);
            label5.Name = "label5";
            label5.Size = new Size(108, 34);
            label5.TabIndex = 6;
            label5.Text = "Metros";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcular.ForeColor = Color.Blue;
            buttonCalcular.Location = new Point(12, 169);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(415, 61);
            buttonCalcular.TabIndex = 3;
            buttonCalcular.Text = "CALCULAR";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelResultado
            // 
            labelResultado.BackColor = SystemColors.Window;
            labelResultado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(12, 246);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(415, 67);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Seu resultado aparecerá aqui";
            labelResultado.TextAlign = ContentAlignment.MiddleCenter;
            labelResultado.Visible = false;
            // 
            // labelMensagem
            // 
            labelMensagem.BackColor = SystemColors.Window;
            labelMensagem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMensagem.Location = new Point(12, 339);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(415, 67);
            labelMensagem.TabIndex = 8;
            labelMensagem.TextAlign = ContentAlignment.MiddleCenter;
            labelMensagem.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(451, 451);
            Controls.Add(labelMensagem);
            Controls.Add(labelResultado);
            Controls.Add(buttonCalcular);
            Controls.Add(label5);
            Controls.Add(textBoxAltura);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPeso);
            Controls.Add(label1);
            MaximumSize = new Size(690, 490);
            Name = "Form1";
            Text = "IMC - Índice de massa corporea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAltura;
        private Label label5;
        public TextBox textBoxPeso;
        private Button buttonCalcular;
        private Label labelResultado;
        private Label labelMensagem;
    }
}
