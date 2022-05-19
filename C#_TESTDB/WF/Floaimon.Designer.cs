
namespace WF
{
    partial class Floaimon
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
            this.tbmaloai = new System.Windows.Forms.TextBox();
            this.tbtenloai = new System.Windows.Forms.TextBox();
            this.btt = new System.Windows.Forms.Button();
            this.btsu = new System.Windows.Forms.Button();
            this.btxo = new System.Windows.Forms.Button();
            this.DGloaimon = new System.Windows.Forms.DataGridView();
            this.buttonreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGloaimon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(129, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí loại món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại:";
            // 
            // tbmaloai
            // 
            this.tbmaloai.Location = new System.Drawing.Point(102, 65);
            this.tbmaloai.Name = "tbmaloai";
            this.tbmaloai.Size = new System.Drawing.Size(147, 22);
            this.tbmaloai.TabIndex = 3;
            // 
            // tbtenloai
            // 
            this.tbtenloai.Location = new System.Drawing.Point(104, 115);
            this.tbtenloai.Name = "tbtenloai";
            this.tbtenloai.Size = new System.Drawing.Size(147, 22);
            this.tbtenloai.TabIndex = 4;
            // 
            // btt
            // 
            this.btt.BackColor = System.Drawing.Color.SandyBrown;
            this.btt.Location = new System.Drawing.Point(267, 38);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(75, 33);
            this.btt.TabIndex = 5;
            this.btt.Text = "Thêm";
            this.btt.UseVisualStyleBackColor = false;
            this.btt.Click += new System.EventHandler(this.btt_Click);
            // 
            // btsu
            // 
            this.btsu.BackColor = System.Drawing.Color.SandyBrown;
            this.btsu.Location = new System.Drawing.Point(267, 77);
            this.btsu.Name = "btsu";
            this.btsu.Size = new System.Drawing.Size(75, 33);
            this.btsu.TabIndex = 6;
            this.btsu.Text = "Sửa";
            this.btsu.UseVisualStyleBackColor = false;
            this.btsu.Click += new System.EventHandler(this.btsu_Click);
            // 
            // btxo
            // 
            this.btxo.BackColor = System.Drawing.Color.SandyBrown;
            this.btxo.Location = new System.Drawing.Point(267, 117);
            this.btxo.Name = "btxo";
            this.btxo.Size = new System.Drawing.Size(75, 33);
            this.btxo.TabIndex = 7;
            this.btxo.Text = "Xóa";
            this.btxo.UseVisualStyleBackColor = false;
            this.btxo.Click += new System.EventHandler(this.btxo_Click);
            // 
            // DGloaimon
            // 
            this.DGloaimon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGloaimon.Location = new System.Drawing.Point(5, 156);
            this.DGloaimon.Name = "DGloaimon";
            this.DGloaimon.RowHeadersWidth = 51;
            this.DGloaimon.RowTemplate.Height = 24;
            this.DGloaimon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGloaimon.Size = new System.Drawing.Size(449, 348);
            this.DGloaimon.TabIndex = 8;
            this.DGloaimon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGloaimon_CellContentClick);
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonreset.Location = new System.Drawing.Point(361, 68);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(88, 50);
            this.buttonreset.TabIndex = 9;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // Floaimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(461, 509);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.DGloaimon);
            this.Controls.Add(this.btxo);
            this.Controls.Add(this.btsu);
            this.Controls.Add(this.btt);
            this.Controls.Add(this.tbtenloai);
            this.Controls.Add(this.tbmaloai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Floaimon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Món";
            this.Load += new System.EventHandler(this.Floaimon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGloaimon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmaloai;
        private System.Windows.Forms.TextBox tbtenloai;
        private System.Windows.Forms.Button btt;
        private System.Windows.Forms.Button btsu;
        private System.Windows.Forms.Button btxo;
        private System.Windows.Forms.DataGridView DGloaimon;
        private System.Windows.Forms.Button buttonreset;
    }
}