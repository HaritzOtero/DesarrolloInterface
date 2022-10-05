namespace Ariketa3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNan = new System.Windows.Forms.TextBox();
            this.textBoxIzena = new System.Windows.Forms.TextBox();
            this.textBoxAbizena = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLangilea = new System.Windows.Forms.RadioButton();
            this.radioButtonBezeroa = new System.Windows.Forms.RadioButton();
            this.radioButtonKontaktua = new System.Windows.Forms.RadioButton();
            this.labelBezeroa = new System.Windows.Forms.Label();
            this.labelLangilea = new System.Windows.Forms.Label();
            this.btnGorde = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKategoria = new System.Windows.Forms.Label();
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSegurtasunSoziala = new System.Windows.Forms.TextBox();
            this.textBoxSoldata = new System.Windows.Forms.TextBox();
            this.labelSegurtasunSoziala = new System.Windows.Forms.Label();
            this.labelSoldata = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nan:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Abizena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(93, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // textBoxNan
            // 
            this.textBoxNan.Location = new System.Drawing.Point(141, 97);
            this.textBoxNan.Name = "textBoxNan";
            this.textBoxNan.Size = new System.Drawing.Size(174, 23);
            this.textBoxNan.TabIndex = 4;
            // 
            // textBoxIzena
            // 
            this.textBoxIzena.Location = new System.Drawing.Point(149, 135);
            this.textBoxIzena.Name = "textBoxIzena";
            this.textBoxIzena.Size = new System.Drawing.Size(166, 23);
            this.textBoxIzena.TabIndex = 5;
            // 
            // textBoxAbizena
            // 
            this.textBoxAbizena.Location = new System.Drawing.Point(168, 179);
            this.textBoxAbizena.Name = "textBoxAbizena";
            this.textBoxAbizena.Size = new System.Drawing.Size(147, 23);
            this.textBoxAbizena.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(150, 225);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(165, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLangilea);
            this.groupBox1.Controls.Add(this.radioButtonBezeroa);
            this.groupBox1.Controls.Add(this.radioButtonKontaktua);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(386, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mota";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonLangilea
            // 
            this.radioButtonLangilea.AutoSize = true;
            this.radioButtonLangilea.Location = new System.Drawing.Point(41, 95);
            this.radioButtonLangilea.Name = "radioButtonLangilea";
            this.radioButtonLangilea.Size = new System.Drawing.Size(85, 24);
            this.radioButtonLangilea.TabIndex = 2;
            this.radioButtonLangilea.TabStop = true;
            this.radioButtonLangilea.Text = "Langilea";
            this.radioButtonLangilea.UseVisualStyleBackColor = true;
            // 
            // radioButtonBezeroa
            // 
            this.radioButtonBezeroa.AutoSize = true;
            this.radioButtonBezeroa.Location = new System.Drawing.Point(41, 65);
            this.radioButtonBezeroa.Name = "radioButtonBezeroa";
            this.radioButtonBezeroa.Size = new System.Drawing.Size(83, 24);
            this.radioButtonBezeroa.TabIndex = 1;
            this.radioButtonBezeroa.TabStop = true;
            this.radioButtonBezeroa.Text = "Bezeroa";
            this.radioButtonBezeroa.UseVisualStyleBackColor = true;
            // 
            // radioButtonKontaktua
            // 
            this.radioButtonKontaktua.AutoSize = true;
            this.radioButtonKontaktua.Location = new System.Drawing.Point(41, 35);
            this.radioButtonKontaktua.Name = "radioButtonKontaktua";
            this.radioButtonKontaktua.Size = new System.Drawing.Size(100, 24);
            this.radioButtonKontaktua.TabIndex = 0;
            this.radioButtonKontaktua.TabStop = true;
            this.radioButtonKontaktua.Text = "Kontaktua";
            this.radioButtonKontaktua.UseVisualStyleBackColor = true;
            // 
            // labelBezeroa
            // 
            this.labelBezeroa.AutoSize = true;
            this.labelBezeroa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBezeroa.Location = new System.Drawing.Point(91, 279);
            this.labelBezeroa.Name = "labelBezeroa";
            this.labelBezeroa.Size = new System.Drawing.Size(65, 20);
            this.labelBezeroa.TabIndex = 11;
            this.labelBezeroa.Text = "Bezeroa";
            // 
            // labelLangilea
            // 
            this.labelLangilea.AutoSize = true;
            this.labelLangilea.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLangilea.Location = new System.Drawing.Point(386, 279);
            this.labelLangilea.Name = "labelLangilea";
            this.labelLangilea.Size = new System.Drawing.Size(67, 20);
            this.labelLangilea.TabIndex = 12;
            this.labelLangilea.Text = "Langilea";
            // 
            // btnGorde
            // 
            this.btnGorde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGorde.Location = new System.Drawing.Point(150, 508);
            this.btnGorde.Name = "btnGorde";
            this.btnGorde.Size = new System.Drawing.Size(108, 42);
            this.btnGorde.TabIndex = 13;
            this.btnGorde.Text = "Gorde";
            this.btnGorde.UseVisualStyleBackColor = true;
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIrten.Location = new System.Drawing.Point(448, 508);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(108, 42);
            this.btnIrten.TabIndex = 14;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelKategoria);
            this.panel1.Controls.Add(this.cmbKategoria);
            this.panel1.Location = new System.Drawing.Point(98, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 145);
            this.panel1.TabIndex = 15;
            // 
            // labelKategoria
            // 
            this.labelKategoria.AutoSize = true;
            this.labelKategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKategoria.Location = new System.Drawing.Point(22, 49);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(77, 20);
            this.labelKategoria.TabIndex = 1;
            this.labelKategoria.Text = "Kategoria";
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(22, 72);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(172, 23);
            this.cmbKategoria.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSegurtasunSoziala);
            this.panel2.Controls.Add(this.textBoxSoldata);
            this.panel2.Controls.Add(this.labelSegurtasunSoziala);
            this.panel2.Controls.Add(this.labelSoldata);
            this.panel2.Location = new System.Drawing.Point(386, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 144);
            this.panel2.TabIndex = 16;
            // 
            // textBoxSegurtasunSoziala
            // 
            this.textBoxSegurtasunSoziala.Location = new System.Drawing.Point(26, 98);
            this.textBoxSegurtasunSoziala.Name = "textBoxSegurtasunSoziala";
            this.textBoxSegurtasunSoziala.Size = new System.Drawing.Size(202, 23);
            this.textBoxSegurtasunSoziala.TabIndex = 3;
            // 
            // textBoxSoldata
            // 
            this.textBoxSoldata.Location = new System.Drawing.Point(92, 29);
            this.textBoxSoldata.Name = "textBoxSoldata";
            this.textBoxSoldata.Size = new System.Drawing.Size(136, 23);
            this.textBoxSoldata.TabIndex = 2;
            // 
            // labelSegurtasunSoziala
            // 
            this.labelSegurtasunSoziala.AutoSize = true;
            this.labelSegurtasunSoziala.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSegurtasunSoziala.Location = new System.Drawing.Point(21, 75);
            this.labelSegurtasunSoziala.Name = "labelSegurtasunSoziala";
            this.labelSegurtasunSoziala.Size = new System.Drawing.Size(133, 20);
            this.labelSegurtasunSoziala.TabIndex = 1;
            this.labelSegurtasunSoziala.Text = "SegurtaunSoziala:";
            // 
            // labelSoldata
            // 
            this.labelSoldata.AutoSize = true;
            this.labelSoldata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSoldata.Location = new System.Drawing.Point(21, 28);
            this.labelSoldata.Name = "labelSoldata";
            this.labelSoldata.Size = new System.Drawing.Size(65, 20);
            this.labelSoldata.TabIndex = 0;
            this.labelSoldata.Text = "Soldata:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.labelLangilea);
            this.Controls.Add(this.labelBezeroa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAbizena);
            this.Controls.Add(this.textBoxIzena);
            this.Controls.Add(this.textBoxNan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNan;
        private TextBox textBoxIzena;
        private TextBox textBoxAbizena;
        private TextBox textBoxEmail;
        private GroupBox groupBox1;
        private RadioButton radioButtonLangilea;
        private RadioButton radioButtonBezeroa;
        private RadioButton radioButtonKontaktua;
        private Label labelBezeroa;
        private Label labelLangilea;
        private Button btnGorde;
        private Button btnIrten;
        private Panel panel1;
        private Label labelKategoria;
        private ComboBox cmbKategoria;
        private Panel panel2;
        private TextBox textBoxSegurtasunSoziala;
        private TextBox textBoxSoldata;
        private Label labelSegurtasunSoziala;
        private Label labelSoldata;
    }
}