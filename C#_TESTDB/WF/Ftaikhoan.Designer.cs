﻿
namespace WF
{
    partial class Ftaikhoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbten = new System.Windows.Forms.TextBox();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttons = new System.Windows.Forms.Button();
            this.buttonx = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbloai = new System.Windows.Forms.TextBox();
            this.dtgrvtk = new System.Windows.Forms.DataGridView();
            this.bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvtk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thiết lập tài khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txbten
            // 
            this.txbten.Location = new System.Drawing.Point(162, 50);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(165, 22);
            this.txbten.TabIndex = 5;
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(162, 89);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(165, 22);
            this.txbpass.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(345, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttons
            // 
            this.buttons.BackColor = System.Drawing.Color.SandyBrown;
            this.buttons.Location = new System.Drawing.Point(345, 83);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(90, 35);
            this.buttons.TabIndex = 10;
            this.buttons.Text = "Sửa";
            this.buttons.UseVisualStyleBackColor = false;
            this.buttons.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonx
            // 
            this.buttonx.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonx.Location = new System.Drawing.Point(345, 124);
            this.buttonx.Name = "buttonx";
            this.buttonx.Size = new System.Drawing.Size(90, 32);
            this.buttonx.TabIndex = 11;
            this.buttonx.Text = "Xóa";
            this.buttonx.UseVisualStyleBackColor = false;
            this.buttonx.Click += new System.EventHandler(this.buttonx_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại tài khoản:";
            // 
            // txbloai
            // 
            this.txbloai.Location = new System.Drawing.Point(162, 124);
            this.txbloai.Name = "txbloai";
            this.txbloai.Size = new System.Drawing.Size(165, 22);
            this.txbloai.TabIndex = 13;
            // 
            // dtgrvtk
            // 
            this.dtgrvtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvtk.Location = new System.Drawing.Point(12, 177);
            this.dtgrvtk.Name = "dtgrvtk";
            this.dtgrvtk.RowHeadersWidth = 51;
            this.dtgrvtk.RowTemplate.Height = 24;
            this.dtgrvtk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvtk.Size = new System.Drawing.Size(545, 272);
            this.dtgrvtk.TabIndex = 14;
            this.dtgrvtk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvtk_CellContentClick);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.PapayaWhip;
            this.bt.Location = new System.Drawing.Point(450, 65);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(107, 59);
            this.bt.TabIndex = 15;
            this.bt.Text = "Reset";
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // Ftaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(569, 453);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.dtgrvtk);
            this.Controls.Add(this.txbloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonx);
            this.Controls.Add(this.buttons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txbten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ftaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.Ftaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbten;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttons;
        private System.Windows.Forms.Button buttonx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbloai;
        private System.Windows.Forms.DataGridView dtgrvtk;
        private System.Windows.Forms.Button bt;
    }
}