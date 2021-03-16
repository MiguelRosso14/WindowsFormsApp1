
namespace WindowsFormsApp1
{
    partial class Restaurante
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Servicio8 = new System.Windows.Forms.ListBox();
            this.Servicio7 = new System.Windows.Forms.ListBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Mesa7 = new System.Windows.Forms.Button();
            this.Servicio6 = new System.Windows.Forms.ListBox();
            this.Servicio4 = new System.Windows.Forms.ListBox();
            this.Mesa6 = new System.Windows.Forms.Button();
            this.Mesa5 = new System.Windows.Forms.Button();
            this.Mesa4 = new System.Windows.Forms.Button();
            this.Servicio5 = new System.Windows.Forms.ListBox();
            this.Mesa8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Servicio7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Salir, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Mesa7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Servicio6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Servicio4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Mesa6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Mesa8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Servicio5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Servicio8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Mesa5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Mesa4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.55477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.44523F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Servicio8
            // 
            this.Servicio8.FormattingEnabled = true;
            this.Servicio8.ItemHeight = 20;
            this.Servicio8.Location = new System.Drawing.Point(269, 275);
            this.Servicio8.Name = "Servicio8";
            this.Servicio8.Size = new System.Drawing.Size(260, 164);
            this.Servicio8.TabIndex = 13;
            // 
            // Servicio7
            // 
            this.Servicio7.FormattingEnabled = true;
            this.Servicio7.ItemHeight = 20;
            this.Servicio7.Location = new System.Drawing.Point(3, 275);
            this.Servicio7.Name = "Servicio7";
            this.Servicio7.Size = new System.Drawing.Size(260, 164);
            this.Servicio7.TabIndex = 12;
            // 
            // Salir
            // 
            this.Salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Salir.Location = new System.Drawing.Point(536, 240);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(259, 29);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Mesa7
            // 
            this.Mesa7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Mesa7.Location = new System.Drawing.Point(5, 240);
            this.Mesa7.Name = "Mesa7";
            this.Mesa7.Size = new System.Drawing.Size(255, 29);
            this.Mesa7.TabIndex = 9;
            this.Mesa7.Text = "Mesa7";
            this.Mesa7.UseVisualStyleBackColor = true;
            // 
            // Servicio6
            // 
            this.Servicio6.FormattingEnabled = true;
            this.Servicio6.ItemHeight = 20;
            this.Servicio6.Location = new System.Drawing.Point(535, 53);
            this.Servicio6.Name = "Servicio6";
            this.Servicio6.Size = new System.Drawing.Size(251, 164);
            this.Servicio6.TabIndex = 7;
            // 
            // Servicio4
            // 
            this.Servicio4.FormattingEnabled = true;
            this.Servicio4.ItemHeight = 20;
            this.Servicio4.Location = new System.Drawing.Point(3, 53);
            this.Servicio4.Name = "Servicio4";
            this.Servicio4.Size = new System.Drawing.Size(260, 164);
            this.Servicio4.TabIndex = 5;
            this.Servicio4.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Mesa6
            // 
            this.Mesa6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Mesa6.Location = new System.Drawing.Point(544, 9);
            this.Mesa6.Name = "Mesa6";
            this.Mesa6.Size = new System.Drawing.Size(243, 38);
            this.Mesa6.TabIndex = 2;
            this.Mesa6.Text = "Mesa6";
            this.Mesa6.UseVisualStyleBackColor = true;
            // 
            // Mesa5
            // 
            this.Mesa5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Mesa5.Location = new System.Drawing.Point(279, 9);
            this.Mesa5.Name = "Mesa5";
            this.Mesa5.Size = new System.Drawing.Size(239, 38);
            this.Mesa5.TabIndex = 1;
            this.Mesa5.Text = "Mesa5";
            this.Mesa5.UseVisualStyleBackColor = true;
            // 
            // Mesa4
            // 
            this.Mesa4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Mesa4.Location = new System.Drawing.Point(15, 9);
            this.Mesa4.Name = "Mesa4";
            this.Mesa4.Size = new System.Drawing.Size(236, 38);
            this.Mesa4.TabIndex = 0;
            this.Mesa4.Text = "Mesa4";
            this.Mesa4.UseVisualStyleBackColor = true;
            this.Mesa4.Click += new System.EventHandler(this.Mesa1_Click);
            // 
            // Servicio5
            // 
            this.Servicio5.FormattingEnabled = true;
            this.Servicio5.ItemHeight = 20;
            this.Servicio5.Location = new System.Drawing.Point(269, 53);
            this.Servicio5.Name = "Servicio5";
            this.Servicio5.Size = new System.Drawing.Size(260, 164);
            this.Servicio5.TabIndex = 6;
            // 
            // Mesa8
            // 
            this.Mesa8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Mesa8.Location = new System.Drawing.Point(276, 240);
            this.Mesa8.Name = "Mesa8";
            this.Mesa8.Size = new System.Drawing.Size(246, 29);
            this.Mesa8.TabIndex = 8;
            this.Mesa8.Text = "Mesa8";
            this.Mesa8.UseVisualStyleBackColor = true;
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Restaurante";
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox Servicio6;
        private System.Windows.Forms.ListBox Servicio5;
        private System.Windows.Forms.ListBox Servicio4;
        private System.Windows.Forms.Button Mesa6;
        private System.Windows.Forms.Button Mesa5;
        private System.Windows.Forms.Button Mesa4;
        private System.Windows.Forms.ListBox Servicio8;
        private System.Windows.Forms.ListBox Servicio7;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Mesa7;
        private System.Windows.Forms.Button Mesa8;
    }
}

