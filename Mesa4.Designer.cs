
namespace WindowsFormsApp1
{
    partial class Mesa4
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
            this.Personas = new System.Windows.Forms.Label();
            this.Numerodepersonas = new System.Windows.Forms.ComboBox();
            this.Familia = new System.Windows.Forms.Label();
            this.Nombrefamilia = new System.Windows.Forms.TextBox();
            this.Entrada = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Platofuerte = new System.Windows.Forms.Label();
            this.Platofuerte1 = new System.Windows.Forms.ComboBox();
            this.Platofuerte2 = new System.Windows.Forms.ComboBox();
            this.Platofuerte3 = new System.Windows.Forms.ComboBox();
            this.Platofuerte4 = new System.Windows.Forms.ComboBox();
            this.Postre = new System.Windows.Forms.Label();
            this.Postrebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Personas
            // 
            this.Personas.AutoSize = true;
            this.Personas.Location = new System.Drawing.Point(2, 50);
            this.Personas.Name = "Personas";
            this.Personas.Size = new System.Drawing.Size(69, 20);
            this.Personas.TabIndex = 0;
            this.Personas.Text = "Personas:";
            // 
            // Numerodepersonas
            // 
            this.Numerodepersonas.FormattingEnabled = true;
            this.Numerodepersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Numerodepersonas.Location = new System.Drawing.Point(117, 47);
            this.Numerodepersonas.Name = "Numerodepersonas";
            this.Numerodepersonas.Size = new System.Drawing.Size(45, 28);
            this.Numerodepersonas.TabIndex = 1;
            this.Numerodepersonas.Text = "0";
            this.Numerodepersonas.SelectedIndexChanged += new System.EventHandler(this.Numerodepersonas_SelectedIndexChanged);
            // 
            // Familia
            // 
            this.Familia.AutoSize = true;
            this.Familia.Location = new System.Drawing.Point(2, 100);
            this.Familia.Name = "Familia";
            this.Familia.Size = new System.Drawing.Size(59, 20);
            this.Familia.TabIndex = 2;
            this.Familia.Text = "Familia:";
            // 
            // Nombrefamilia
            // 
            this.Nombrefamilia.Location = new System.Drawing.Point(117, 97);
            this.Nombrefamilia.Name = "Nombrefamilia";
            this.Nombrefamilia.Size = new System.Drawing.Size(162, 27);
            this.Nombrefamilia.TabIndex = 3;
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.Location = new System.Drawing.Point(2, 155);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(63, 20);
            this.Entrada.TabIndex = 4;
            this.Entrada.Text = "Entrada:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ensalada cesar",
            "Ceviche",
            "Croquetas",
            "Quipe de chivo",
            "Tacos de chivo"});
            this.comboBox1.Location = new System.Drawing.Point(117, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // Platofuerte
            // 
            this.Platofuerte.AutoSize = true;
            this.Platofuerte.Location = new System.Drawing.Point(2, 210);
            this.Platofuerte.Name = "Platofuerte";
            this.Platofuerte.Size = new System.Drawing.Size(86, 20);
            this.Platofuerte.TabIndex = 6;
            this.Platofuerte.Text = "Plato fuerte";
            // 
            // Platofuerte1
            // 
            this.Platofuerte1.FormattingEnabled = true;
            this.Platofuerte1.Items.AddRange(new object[] {
            "Camarones ",
            "Tarkari de chivo",
            "Arroz thai",
            "Rissoto",
            "Giorno",
            "Mista",
            "Sopa de chivo",
            "Buchiaratti",
            "Golden experience",
            "Umbreon"});
            this.Platofuerte1.Location = new System.Drawing.Point(117, 207);
            this.Platofuerte1.Name = "Platofuerte1";
            this.Platofuerte1.Size = new System.Drawing.Size(162, 28);
            this.Platofuerte1.TabIndex = 7;
            // 
            // Platofuerte2
            // 
            this.Platofuerte2.FormattingEnabled = true;
            this.Platofuerte2.Items.AddRange(new object[] {
            "Camarones ",
            "Tarkari de chivo",
            "Arroz thai",
            "Rissoto",
            "Giorno",
            "Mista",
            "Sopa de chivo",
            "Buchiaratti",
            "Golden experience",
            "Umbreon"});
            this.Platofuerte2.Location = new System.Drawing.Point(117, 241);
            this.Platofuerte2.Name = "Platofuerte2";
            this.Platofuerte2.Size = new System.Drawing.Size(162, 28);
            this.Platofuerte2.TabIndex = 8;
            // 
            // Platofuerte3
            // 
            this.Platofuerte3.FormattingEnabled = true;
            this.Platofuerte3.Items.AddRange(new object[] {
            "Camarones ",
            "Tarkari de chivo",
            "Arroz thai",
            "Rissoto",
            "Giorno",
            "Mista",
            "Sopa de chivo",
            "Buchiaratti",
            "Golden experience",
            "Umbreon"});
            this.Platofuerte3.Location = new System.Drawing.Point(117, 275);
            this.Platofuerte3.Name = "Platofuerte3";
            this.Platofuerte3.Size = new System.Drawing.Size(162, 28);
            this.Platofuerte3.TabIndex = 9;
            // 
            // Platofuerte4
            // 
            this.Platofuerte4.FormattingEnabled = true;
            this.Platofuerte4.Items.AddRange(new object[] {
            "Camarones ",
            "Tarkari de chivo",
            "Arroz thai",
            "Rissoto",
            "Giorno",
            "Mista",
            "Sopa de chivo",
            "Buchiaratti",
            "Golden experience",
            "Umbreon"});
            this.Platofuerte4.Location = new System.Drawing.Point(117, 309);
            this.Platofuerte4.Name = "Platofuerte4";
            this.Platofuerte4.Size = new System.Drawing.Size(161, 28);
            this.Platofuerte4.TabIndex = 10;
            // 
            // Postre
            // 
            this.Postre.AutoSize = true;
            this.Postre.Location = new System.Drawing.Point(2, 377);
            this.Postre.Name = "Postre";
            this.Postre.Size = new System.Drawing.Size(52, 20);
            this.Postre.TabIndex = 11;
            this.Postre.Text = "Postre:";
            // 
            // Postrebox
            // 
            this.Postrebox.FormattingEnabled = true;
            this.Postrebox.Items.AddRange(new object[] {
            "Doble Brownie",
            "Torta de 3 leches",
            "Volcan de chocolate"});
            this.Postrebox.Location = new System.Drawing.Point(117, 374);
            this.Postrebox.Name = "Postrebox";
            this.Postrebox.Size = new System.Drawing.Size(161, 28);
            this.Postrebox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bebidas:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Coca-cola",
            "Pepsi",
            "Cola Real",
            "7UP",
            "Red Rock"});
            this.comboBox2.Location = new System.Drawing.Point(117, 440);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(2, 512);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(114, 33);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(174, 516);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 28);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Mesa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 557);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Postrebox);
            this.Controls.Add(this.Postre);
            this.Controls.Add(this.Platofuerte4);
            this.Controls.Add(this.Platofuerte3);
            this.Controls.Add(this.Platofuerte2);
            this.Controls.Add(this.Platofuerte1);
            this.Controls.Add(this.Platofuerte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Nombrefamilia);
            this.Controls.Add(this.Familia);
            this.Controls.Add(this.Numerodepersonas);
            this.Controls.Add(this.Personas);
            this.Name = "Mesa4";
            this.Text = "Mesa1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Personas;
        private System.Windows.Forms.ComboBox Numerodepersonas;
        private System.Windows.Forms.Label Familia;
        private System.Windows.Forms.TextBox Nombrefamilia;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Platofuerte;
        private System.Windows.Forms.ComboBox Platofuerte1;
        private System.Windows.Forms.ComboBox Platofuerte2;
        private System.Windows.Forms.ComboBox Platofuerte3;
        private System.Windows.Forms.ComboBox Platofuerte4;
        private System.Windows.Forms.Label Postre;
        private System.Windows.Forms.ComboBox Postrebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}