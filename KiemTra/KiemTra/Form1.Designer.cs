﻿
namespace KiemTra
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên đăng nhập";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(548, 95);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(196, 38);
            this.textboxusername.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(192, 200);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(139, 32);
            this.lab.TabIndex = 2;
            this.lab.Text = "mật khẩu:";
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(548, 215);
            this.textboxmatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(196, 38);
            this.textboxmatkhau.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(548, 343);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(232, 66);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox textboxmatkhau;
        private System.Windows.Forms.Button btnlogin;
    }
}

