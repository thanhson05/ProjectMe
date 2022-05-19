
namespace WF
{
    partial class Flogin
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btxoa = new System.Windows.Forms.Button();
            this.btdn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lbpass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.lbtdn = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WF.Properties.Resources.CF;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 483);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.btdn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(131, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 161);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(243, 126);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(89, 29);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Thoát";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btdn
            // 
            this.btdn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdn.Location = new System.Drawing.Point(140, 126);
            this.btdn.Name = "btdn";
            this.btdn.Size = new System.Drawing.Size(97, 29);
            this.btdn.TabIndex = 2;
            this.btdn.Text = "Đăng nhập ";
            this.btdn.UseVisualStyleBackColor = false;
            this.btdn.Click += new System.EventHandler(this.btdn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbpass);
            this.panel3.Controls.Add(this.lbpass);
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 37);
            this.panel3.TabIndex = 1;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(132, 9);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(207, 22);
            this.tbpass.TabIndex = 1;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbpass.Location = new System.Drawing.Point(7, 12);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(79, 17);
            this.lbpass.TabIndex = 0;
            this.lbpass.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbusername);
            this.panel2.Controls.Add(this.lbtdn);
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 41);
            this.panel2.TabIndex = 0;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(132, 14);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(207, 22);
            this.tbusername.TabIndex = 1;
            // 
            // lbtdn
            // 
            this.lbtdn.AutoSize = true;
            this.lbtdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtdn.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbtdn.Location = new System.Drawing.Point(3, 14);
            this.lbtdn.Name = "lbtdn";
            this.lbtdn.Size = new System.Drawing.Size(123, 17);
            this.lbtdn.TabIndex = 0;
            this.lbtdn.Text = "Tên đăng nhập:";
            // 
            // Flogin
            // 
            this.AcceptButton = this.btdn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btxoa;
            this.ClientSize = new System.Drawing.Size(633, 486);
            this.Controls.Add(this.panel4);
            this.Name = "Flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Flogin_FormClosing);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label lbtdn;
        private System.Windows.Forms.Button btdn;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}

