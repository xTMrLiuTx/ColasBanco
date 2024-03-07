namespace ColasBanco
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
            btnAgregar = new Button();
            rbDeposito = new RadioButton();
            rbRetiro = new RadioButton();
            rbConsulta = new RadioButton();
            txtCliente = new TextBox();
            btnAtender = new Button();
            listBoxDepositos = new ListBox();
            listBoxRetiros = new ListBox();
            listBoxConsultas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Yellow;
            btnAgregar.Location = new Point(125, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // rbDeposito
            // 
            rbDeposito.AutoSize = true;
            rbDeposito.BackColor = SystemColors.ActiveCaption;
            rbDeposito.Location = new Point(256, 106);
            rbDeposito.Name = "rbDeposito";
            rbDeposito.Size = new Size(78, 19);
            rbDeposito.TabIndex = 1;
            rbDeposito.TabStop = true;
            rbDeposito.Text = "DEPOSITO";
            rbDeposito.UseVisualStyleBackColor = false;
            // 
            // rbRetiro
            // 
            rbRetiro.AutoSize = true;
            rbRetiro.BackColor = SystemColors.ActiveCaption;
            rbRetiro.Location = new Point(256, 130);
            rbRetiro.Name = "rbRetiro";
            rbRetiro.Size = new Size(63, 19);
            rbRetiro.TabIndex = 2;
            rbRetiro.TabStop = true;
            rbRetiro.Text = "RETIRO";
            rbRetiro.UseVisualStyleBackColor = false;
            // 
            // rbConsulta
            // 
            rbConsulta.AutoSize = true;
            rbConsulta.BackColor = SystemColors.ActiveCaption;
            rbConsulta.Location = new Point(256, 155);
            rbConsulta.Name = "rbConsulta";
            rbConsulta.Size = new Size(83, 19);
            rbConsulta.TabIndex = 3;
            rbConsulta.TabStop = true;
            rbConsulta.Text = "CONSULTA";
            rbConsulta.UseVisualStyleBackColor = false;
            rbConsulta.CheckedChanged += rbConsulta_CheckedChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(109, 130);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 4;
            // 
            // btnAtender
            // 
            btnAtender.BackColor = Color.Yellow;
            btnAtender.Location = new Point(243, 60);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(75, 23);
            btnAtender.TabIndex = 6;
            btnAtender.Text = "ATENDER";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Click += btnAtender_Click;
            // 
            // listBoxDepositos
            // 
            listBoxDepositos.BackColor = Color.Yellow;
            listBoxDepositos.FormattingEnabled = true;
            listBoxDepositos.ItemHeight = 15;
            listBoxDepositos.Location = new Point(89, 228);
            listBoxDepositos.Name = "listBoxDepositos";
            listBoxDepositos.Size = new Size(120, 94);
            listBoxDepositos.TabIndex = 7;
            // 
            // listBoxRetiros
            // 
            listBoxRetiros.BackColor = Color.Yellow;
            listBoxRetiros.FormattingEnabled = true;
            listBoxRetiros.ItemHeight = 15;
            listBoxRetiros.Location = new Point(256, 228);
            listBoxRetiros.Name = "listBoxRetiros";
            listBoxRetiros.Size = new Size(120, 94);
            listBoxRetiros.TabIndex = 8;
            // 
            // listBoxConsultas
            // 
            listBoxConsultas.BackColor = Color.Yellow;
            listBoxConsultas.FormattingEnabled = true;
            listBoxConsultas.ItemHeight = 15;
            listBoxConsultas.Location = new Point(448, 228);
            listBoxConsultas.Name = "listBoxConsultas";
            listBoxConsultas.Size = new Size(120, 94);
            listBoxConsultas.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 198);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "DEPOSITO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 198);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "RETIROS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 198);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 12;
            label3.Text = "CONSULTA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 133);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 13;
            label4.Text = "CLIENTE:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(632, 351);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxConsultas);
            Controls.Add(listBoxRetiros);
            Controls.Add(listBoxDepositos);
            Controls.Add(btnAtender);
            Controls.Add(txtCliente);
            Controls.Add(rbConsulta);
            Controls.Add(rbRetiro);
            Controls.Add(rbDeposito);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "BANCO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private RadioButton rbDeposito;
        private RadioButton rbRetiro;
        private RadioButton rbConsulta;
        private TextBox txtCliente;
        private Button btnAtender;
        private ListBox listBoxDepositos;
        private ListBox listBoxRetiros;
        private ListBox listBoxConsultas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}