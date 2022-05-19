
namespace WF
{
    partial class Fban
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
            this.tbma = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btd = new System.Windows.Forms.Button();
            this.DTGVVBAN = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVVBAN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bàn:";
            // 
            // tbma
            // 
            this.tbma.Location = new System.Drawing.Point(113, 65);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(119, 22);
            this.tbma.TabIndex = 3;
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(113, 117);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(119, 22);
            this.tbten.TabIndex = 4;
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.SandyBrown;
            this.btthem.Location = new System.Drawing.Point(251, 41);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 34);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.SandyBrown;
            this.btedit.Location = new System.Drawing.Point(251, 81);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 34);
            this.btedit.TabIndex = 6;
            this.btedit.Text = "Sửa";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btd
            // 
            this.btd.BackColor = System.Drawing.Color.SandyBrown;
            this.btd.Location = new System.Drawing.Point(251, 121);
            this.btd.Name = "btd";
            this.btd.Size = new System.Drawing.Size(75, 34);
            this.btd.TabIndex = 7;
            this.btd.Text = "Xóa";
            this.btd.UseVisualStyleBackColor = false;
            this.btd.Click += new System.EventHandler(this.btd_Click);
            // 
            // DTGVVBAN
            // 
            this.DTGVVBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVVBAN.Location = new System.Drawing.Point(12, 165);
            this.DTGVVBAN.Name = "DTGVVBAN";
            this.DTGVVBAN.RowHeadersWidth = 51;
            this.DTGVVBAN.RowTemplate.Height = 24;
            this.DTGVVBAN.Size = new System.Drawing.Size(448, 327);
            this.DTGVVBAN.TabIndex = 8;
            this.DTGVVBAN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVVBAN_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Location = new System.Drawing.Point(347, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(472, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTGVVBAN);
            this.Controls.Add(this.btd);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.tbten);
            this.Controls.Add(this.tbma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn";
            this.Load += new System.EventHandler(this.Fban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVVBAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btd;
        private System.Windows.Forms.DataGridView DTGVVBAN;
        private System.Windows.Forms.Button button1;
    }
}