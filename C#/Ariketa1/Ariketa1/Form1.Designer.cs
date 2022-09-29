namespace Ariketa1
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
            this.esaldiTxtBox = new System.Windows.Forms.TextBox();
            this.esaldi1 = new System.Windows.Forms.Button();
            this.esaldi2 = new System.Windows.Forms.Button();
            this.esaldi5 = new System.Windows.Forms.Button();
            this.esaldi4 = new System.Windows.Forms.Button();
            this.esaldi3 = new System.Windows.Forms.Button();
            this.lotu = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // esaldiTxtBox
            // 
            this.esaldiTxtBox.Location = new System.Drawing.Point(228, 30);
            this.esaldiTxtBox.Multiline = true;
            this.esaldiTxtBox.Name = "esaldiTxtBox";
            this.esaldiTxtBox.Size = new System.Drawing.Size(357, 157);
            this.esaldiTxtBox.TabIndex = 0;
            // 
            // esaldi1
            // 
            this.esaldi1.Location = new System.Drawing.Point(77, 237);
            this.esaldi1.Name = "esaldi1";
            this.esaldi1.Size = new System.Drawing.Size(99, 41);
            this.esaldi1.TabIndex = 1;
            this.esaldi1.Text = "Esaldi1";
            this.esaldi1.UseVisualStyleBackColor = true;
            this.esaldi1.Click += new System.EventHandler(this.esaldi1_Click);
            // 
            // esaldi2
            // 
            this.esaldi2.Location = new System.Drawing.Point(348, 237);
            this.esaldi2.Name = "esaldi2";
            this.esaldi2.Size = new System.Drawing.Size(102, 40);
            this.esaldi2.TabIndex = 2;
            this.esaldi2.Text = "Esaldi2";
            this.esaldi2.UseVisualStyleBackColor = true;
            this.esaldi2.Click += new System.EventHandler(this.esaldi2_Click);
            // 
            // esaldi5
            // 
            this.esaldi5.Location = new System.Drawing.Point(348, 304);
            this.esaldi5.Name = "esaldi5";
            this.esaldi5.Size = new System.Drawing.Size(102, 44);
            this.esaldi5.TabIndex = 3;
            this.esaldi5.Text = "Esaldi5";
            this.esaldi5.UseVisualStyleBackColor = true;
            this.esaldi5.Click += new System.EventHandler(this.esaldi5_Click);
            // 
            // esaldi4
            // 
            this.esaldi4.Location = new System.Drawing.Point(77, 304);
            this.esaldi4.Name = "esaldi4";
            this.esaldi4.Size = new System.Drawing.Size(99, 44);
            this.esaldi4.TabIndex = 4;
            this.esaldi4.Text = "Esaldi4";
            this.esaldi4.UseVisualStyleBackColor = true;
            this.esaldi4.Click += new System.EventHandler(this.esaldi4_Click);
            // 
            // esaldi3
            // 
            this.esaldi3.Location = new System.Drawing.Point(627, 237);
            this.esaldi3.Name = "esaldi3";
            this.esaldi3.Size = new System.Drawing.Size(90, 40);
            this.esaldi3.TabIndex = 5;
            this.esaldi3.Text = "Esaldi3";
            this.esaldi3.UseVisualStyleBackColor = true;
            this.esaldi3.Click += new System.EventHandler(this.esaldi3_Click);
            // 
            // lotu
            // 
            this.lotu.Location = new System.Drawing.Point(627, 304);
            this.lotu.Name = "lotu";
            this.lotu.Size = new System.Drawing.Size(90, 44);
            this.lotu.TabIndex = 6;
            this.lotu.Text = "Lotu";
            this.lotu.UseVisualStyleBackColor = true;
            this.lotu.Click += new System.EventHandler(this.lotu_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(228, 390);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(95, 34);
            this.btnGarbitu.TabIndex = 7;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Location = new System.Drawing.Point(496, 390);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(89, 34);
            this.btnIrten.TabIndex = 8;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.lotu);
            this.Controls.Add(this.esaldi3);
            this.Controls.Add(this.esaldi4);
            this.Controls.Add(this.esaldi5);
            this.Controls.Add(this.esaldi2);
            this.Controls.Add(this.esaldi1);
            this.Controls.Add(this.esaldiTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox esaldiTxtBox;
        private Button esaldi1;
        private Button esaldi2;
        private Button esaldi5;
        private Button esaldi4;
        private Button esaldi3;
        private Button lotu;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}