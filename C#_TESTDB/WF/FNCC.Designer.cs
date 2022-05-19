
namespace WF
{
    partial class FNCC
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
            this.txbPassNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtdiachiNCC = new System.Windows.Forms.TextBox();
            this.txtsdtNCC = new System.Windows.Forms.TextBox();
            this.btttt = new System.Windows.Forms.Button();
            this.btsss = new System.Windows.Forms.Button();
            this.btxxxx = new System.Windows.Forms.Button();
            this.btsr = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.dtgrvncc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvncc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // txbPassNCC
            // 
            this.txbPassNCC.Location = new System.Drawing.Point(96, 51);
            this.txbPassNCC.Name = "txbPassNCC";
            this.txbPassNCC.Size = new System.Drawing.Size(197, 22);
            this.txbPassNCC.TabIndex = 5;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(96, 96);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(197, 22);
            this.txtTenNCC.TabIndex = 6;
            // 
            // txtdiachiNCC
            // 
            this.txtdiachiNCC.Location = new System.Drawing.Point(438, 49);
            this.txtdiachiNCC.Name = "txtdiachiNCC";
            this.txtdiachiNCC.Size = new System.Drawing.Size(197, 22);
            this.txtdiachiNCC.TabIndex = 7;
            // 
            // txtsdtNCC
            // 
            this.txtsdtNCC.Location = new System.Drawing.Point(438, 99);
            this.txtsdtNCC.Name = "txtsdtNCC";
            this.txtsdtNCC.Size = new System.Drawing.Size(197, 22);
            this.txtsdtNCC.TabIndex = 8;
            // 
            // btttt
            // 
            this.btttt.BackColor = System.Drawing.Color.SandyBrown;
            this.btttt.Location = new System.Drawing.Point(669, 41);
            this.btttt.Name = "btttt";
            this.btttt.Size = new System.Drawing.Size(75, 36);
            this.btttt.TabIndex = 9;
            this.btttt.Text = "Thêm";
            this.btttt.UseVisualStyleBackColor = false;
            this.btttt.Click += new System.EventHandler(this.btttt_Click);
            // 
            // btsss
            // 
            this.btsss.BackColor = System.Drawing.Color.SandyBrown;
            this.btsss.Location = new System.Drawing.Point(669, 79);
            this.btsss.Name = "btsss";
            this.btsss.Size = new System.Drawing.Size(75, 36);
            this.btsss.TabIndex = 10;
            this.btsss.Text = "Sửa";
            this.btsss.UseVisualStyleBackColor = false;
            this.btsss.Click += new System.EventHandler(this.btsss_Click);
            // 
            // btxxxx
            // 
            this.btxxxx.BackColor = System.Drawing.Color.SandyBrown;
            this.btxxxx.Location = new System.Drawing.Point(669, 117);
            this.btxxxx.Name = "btxxxx";
            this.btxxxx.Size = new System.Drawing.Size(75, 36);
            this.btxxxx.TabIndex = 11;
            this.btxxxx.Text = "Xóa";
            this.btxxxx.UseVisualStyleBackColor = false;
            this.btxxxx.Click += new System.EventHandler(this.btxxxx_Click);
            // 
            // btsr
            // 
            this.btsr.BackColor = System.Drawing.Color.PapayaWhip;
            this.btsr.Location = new System.Drawing.Point(750, 35);
            this.btsr.Name = "btsr";
            this.btsr.Size = new System.Drawing.Size(116, 48);
            this.btsr.TabIndex = 12;
            this.btsr.Text = "Tìm kiếm";
            this.btsr.UseVisualStyleBackColor = false;
            this.btsr.Click += new System.EventHandler(this.btsr_Click);
            // 
            // tbtim
            // 
            this.tbtim.Location = new System.Drawing.Point(872, 49);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(217, 22);
            this.tbtim.TabIndex = 13;
            // 
            // dtgrvncc
            // 
            this.dtgrvncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvncc.Location = new System.Drawing.Point(12, 159);
            this.dtgrvncc.Name = "dtgrvncc";
            this.dtgrvncc.RowHeadersWidth = 51;
            this.dtgrvncc.RowTemplate.Height = 24;
            this.dtgrvncc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvncc.Size = new System.Drawing.Size(1082, 287);
            this.dtgrvncc.TabIndex = 14;
            this.dtgrvncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvncc_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Location = new System.Drawing.Point(891, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgrvncc);
            this.Controls.Add(this.tbtim);
            this.Controls.Add(this.btsr);
            this.Controls.Add(this.btxxxx);
            this.Controls.Add(this.btsss);
            this.Controls.Add(this.btttt);
            this.Controls.Add(this.txtsdtNCC);
            this.Controls.Add(this.txtdiachiNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txbPassNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.FNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPassNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtdiachiNCC;
        private System.Windows.Forms.TextBox txtsdtNCC;
        private System.Windows.Forms.Button btttt;
        private System.Windows.Forms.Button btsss;
        private System.Windows.Forms.Button btxxxx;
        private System.Windows.Forms.Button btsr;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.DataGridView dtgrvncc;
        private System.Windows.Forms.Button button1;
    }
}