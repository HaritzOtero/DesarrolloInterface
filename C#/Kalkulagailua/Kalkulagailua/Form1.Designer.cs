namespace Kalkulagailua
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
            this.txtZenbaki1 = new System.Windows.Forms.TextBox();
            this.txtZenbaki2 = new System.Windows.Forms.TextBox();
            this.btnGehi = new System.Windows.Forms.Button();
            this.btnKen = new System.Windows.Forms.Button();
            this.btnBider = new System.Windows.Forms.Button();
            this.btnZati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZenbaki1
            // 
            this.txtZenbaki1.Location = new System.Drawing.Point(72, 95);
            this.txtZenbaki1.Name = "txtZenbaki1";
            this.txtZenbaki1.Size = new System.Drawing.Size(185, 23);
            this.txtZenbaki1.TabIndex = 0;
            // 
            // txtZenbaki2
            // 
            this.txtZenbaki2.Location = new System.Drawing.Point(355, 95);
            this.txtZenbaki2.Name = "txtZenbaki2";
            this.txtZenbaki2.Size = new System.Drawing.Size(185, 23);
            this.txtZenbaki2.TabIndex = 1;
            // 
            // btnGehi
            // 
            this.btnGehi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGehi.Location = new System.Drawing.Point(157, 193);
            this.btnGehi.Name = "btnGehi";
            this.btnGehi.Size = new System.Drawing.Size(100, 88);
            this.btnGehi.TabIndex = 2;
            this.btnGehi.Text = "+";
            this.btnGehi.UseVisualStyleBackColor = true;
            this.btnGehi.Click += new System.EventHandler(this.btnGehi_Click);
            // 
            // btnKen
            // 
            this.btnKen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKen.Location = new System.Drawing.Point(157, 317);
            this.btnKen.Name = "btnKen";
            this.btnKen.Size = new System.Drawing.Size(100, 88);
            this.btnKen.TabIndex = 3;
            this.btnKen.Text = "-";
            this.btnKen.UseVisualStyleBackColor = true;
            this.btnKen.Click += new System.EventHandler(this.btnKen_Click);
            // 
            // btnBider
            // 
            this.btnBider.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBider.Location = new System.Drawing.Point(355, 193);
            this.btnBider.Name = "btnBider";
            this.btnBider.Size = new System.Drawing.Size(100, 88);
            this.btnBider.TabIndex = 4;
            this.btnBider.Text = "X";
            this.btnBider.UseVisualStyleBackColor = true;
            this.btnBider.Click += new System.EventHandler(this.btnBider_Click);
            // 
            // btnZati
            // 
            this.btnZati.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZati.Location = new System.Drawing.Point(355, 317);
            this.btnZati.Name = "btnZati";
            this.btnZati.Size = new System.Drawing.Size(100, 88);
            this.btnZati.TabIndex = 5;
            this.btnZati.Text = "/";
            this.btnZati.UseVisualStyleBackColor = true;
            this.btnZati.Click += new System.EventHandler(this.btnZati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 518);
            this.Controls.Add(this.btnZati);
            this.Controls.Add(this.btnBider);
            this.Controls.Add(this.btnKen);
            this.Controls.Add(this.btnGehi);
            this.Controls.Add(this.txtZenbaki2);
            this.Controls.Add(this.txtZenbaki1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtZenbaki1;
        private TextBox txtZenbaki2;
        private Button btnGehi;
        private Button btnKen;
        private Button btnBider;
        private Button btnZati;
    }
}