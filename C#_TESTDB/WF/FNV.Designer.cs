
namespace WF
{
    partial class FNV
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmnv = new System.Windows.Forms.TextBox();
            this.tbtnv = new System.Windows.Forms.TextBox();
            this.tbdc = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.bttt = new System.Windows.Forms.Button();
            this.btss = new System.Windows.Forms.Button();
            this.btxx = new System.Windows.Forms.Button();
            this.GVNV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // tbmnv
            // 
            this.tbmnv.Location = new System.Drawing.Point(139, 52);
            this.tbmnv.Name = "tbmnv";
            this.tbmnv.Size = new System.Drawing.Size(152, 22);
            this.tbmnv.TabIndex = 5;
            // 
            // tbtnv
            // 
            this.tbtnv.Location = new System.Drawing.Point(139, 97);
            this.tbtnv.Name = "tbtnv";
            this.tbtnv.Size = new System.Drawing.Size(152, 22);
            this.tbtnv.TabIndex = 6;
            // 
            // tbdc
            // 
            this.tbdc.Location = new System.Drawing.Point(418, 52);
            this.tbdc.Name = "tbdc";
            this.tbdc.Size = new System.Drawing.Size(152, 22);
            this.tbdc.TabIndex = 7;
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(418, 97);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(152, 22);
            this.tbsdt.TabIndex = 8;
            // 
            // bttt
            // 
            this.bttt.BackColor = System.Drawing.Color.SandyBrown;
            this.bttt.Location = new System.Drawing.Point(588, 23);
            this.bttt.Name = "bttt";
            this.bttt.Size = new System.Drawing.Size(75, 39);
            this.bttt.TabIndex = 9;
            this.bttt.Text = "Thêm";
            this.bttt.UseVisualStyleBackColor = false;
            this.bttt.Click += new System.EventHandler(this.bttt_Click);
            // 
            // btss
            // 
            this.btss.BackColor = System.Drawing.Color.SandyBrown;
            this.btss.Location = new System.Drawing.Point(588, 110);
            this.btss.Name = "btss";
            this.btss.Size = new System.Drawing.Size(75, 36);
            this.btss.TabIndex = 10;
            this.btss.Text = "Sửa";
            this.btss.UseVisualStyleBackColor = false;
            this.btss.Click += new System.EventHandler(this.btss_Click);
            // 
            // btxx
            // 
            this.btxx.BackColor = System.Drawing.Color.SandyBrown;
            this.btxx.Location = new System.Drawing.Point(588, 68);
            this.btxx.Name = "btxx";
            this.btxx.Size = new System.Drawing.Size(75, 36);
            this.btxx.TabIndex = 11;
            this.btxx.Text = "Xóa";
            this.btxx.UseVisualStyleBackColor = false;
            this.btxx.Click += new System.EventHandler(this.btxx_Click);
            // 
            // GVNV
            // 
            this.GVNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVNV.Location = new System.Drawing.Point(12, 159);
            this.GVNV.Name = "GVNV";
            this.GVNV.RowHeadersWidth = 51;
            this.GVNV.RowTemplate.Height = 24;
            this.GVNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVNV.Size = new System.Drawing.Size(831, 286);
            this.GVNV.TabIndex = 14;
            this.GVNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVNV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Location = new System.Drawing.Point(697, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GVNV);
            this.Controls.Add(this.btxx);
            this.Controls.Add(this.btss);
            this.Controls.Add(this.bttt);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbdc);
            this.Controls.Add(this.tbtnv);
            this.Controls.Add(this.tbmnv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmnv;
        private System.Windows.Forms.TextBox tbtnv;
        private System.Windows.Forms.TextBox tbdc;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Button bttt;
        private System.Windows.Forms.Button btss;
        private System.Windows.Forms.Button btxx;
        private System.Windows.Forms.DataGridView GVNV;
        private System.Windows.Forms.Button button1;
    }
}