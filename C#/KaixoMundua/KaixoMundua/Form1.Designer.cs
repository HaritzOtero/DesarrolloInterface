﻿namespace KaixoMundua
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
            this.btnKaixo = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaixo
            // 
            this.btnKaixo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKaixo.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKaixo.Location = new System.Drawing.Point(158, 196);
            this.btnKaixo.Name = "btnKaixo";
            this.btnKaixo.Size = new System.Drawing.Size(124, 45);
            this.btnKaixo.TabIndex = 0;
            this.btnKaixo.Text = "KAIXO";
            this.btnKaixo.UseVisualStyleBackColor = false;
            this.btnKaixo.Click += new System.EventHandler(this.btnKaixo_Click);
            // 
            // btnItxi
            // 
            this.btnItxi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnItxi.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItxi.Location = new System.Drawing.Point(502, 196);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(124, 45);
            this.btnItxi.TabIndex = 1;
            this.btnItxi.Text = "ITXI";
            this.btnItxi.UseVisualStyleBackColor = false;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnKaixo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnKaixo;
        private Button btnItxi;
    }
}