namespace MyPham
{
    partial class Baocaodoanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocaodoanhthu));
            this.txtTungay = new System.Windows.Forms.TextBox();
            this.txtdenngay = new System.Windows.Forms.TextBox();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bththongke = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTungay
            // 
            this.txtTungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTungay.Location = new System.Drawing.Point(111, 46);
            this.txtTungay.Name = "txtTungay";
            this.txtTungay.Size = new System.Drawing.Size(116, 22);
            this.txtTungay.TabIndex = 0;
            // 
            // txtdenngay
            // 
            this.txtdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdenngay.Location = new System.Drawing.Point(331, 46);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Size = new System.Drawing.Size(116, 22);
            this.txtdenngay.TabIndex = 1;
            // 
            // txtTongDT
            // 
            this.txtTongDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDT.Location = new System.Drawing.Point(362, 256);
            this.txtTongDT.Name = "txtTongDT";
            this.txtTongDT.Size = new System.Drawing.Size(165, 22);
            this.txtTongDT.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(27, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // bththongke
            // 
            this.bththongke.Location = new System.Drawing.Point(140, 74);
            this.bththongke.Name = "bththongke";
            this.bththongke.Size = new System.Drawing.Size(87, 23);
            this.bththongke.TabIndex = 4;
            this.bththongke.Text = "Báo Cáo";
            this.bththongke.UseVisualStyleBackColor = true;
            this.bththongke.Click += new System.EventHandler(this.bththongke_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng doanh thu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Báo Cáo Doanh Thu Bán Hàng";
            // 
            // Baocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(553, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bththongke);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTongDT);
            this.Controls.Add(this.txtdenngay);
            this.Controls.Add(this.txtTungay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baocaodoanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu";
            this.Load += new System.EventHandler(this.Baocaodoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTungay;
        private System.Windows.Forms.TextBox txtdenngay;
        private System.Windows.Forms.TextBox txtTongDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bththongke;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}