
namespace Cafe_Management_Program
{
    partial class frmLapPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuThu));
            this.dgvCTPhieuTU = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhieuTU = new System.Windows.Forms.TextBox();
            this.txtNgayThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhiPV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNVThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLapPhieuThu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuTU)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTPhieuTU
            // 
            this.dgvCTPhieuTU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPhieuTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuTU.Location = new System.Drawing.Point(13, 347);
            this.dgvCTPhieuTU.Name = "dgvCTPhieuTU";
            this.dgvCTPhieuTU.RowHeadersWidth = 51;
            this.dgvCTPhieuTU.RowTemplate.Height = 29;
            this.dgvCTPhieuTU.Size = new System.Drawing.Size(553, 300);
            this.dgvCTPhieuTU.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu thức uống";
            // 
            // txtPhieuTU
            // 
            this.txtPhieuTU.Enabled = false;
            this.txtPhieuTU.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhieuTU.Location = new System.Drawing.Point(150, 315);
            this.txtPhieuTU.Name = "txtPhieuTU";
            this.txtPhieuTU.Size = new System.Drawing.Size(254, 26);
            this.txtPhieuTU.TabIndex = 2;
            // 
            // txtNgayThu
            // 
            this.txtNgayThu.Enabled = false;
            this.txtNgayThu.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayThu.Location = new System.Drawing.Point(118, 93);
            this.txtNgayThu.Name = "txtNgayThu";
            this.txtNgayThu.Size = new System.Drawing.Size(286, 26);
            this.txtNgayThu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày thu";
            // 
            // txtPhiPV
            // 
            this.txtPhiPV.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhiPV.Location = new System.Drawing.Point(118, 180);
            this.txtPhiPV.Name = "txtPhiPV";
            this.txtPhiPV.Size = new System.Drawing.Size(286, 26);
            this.txtPhiPV.TabIndex = 8;
            this.txtPhiPV.Text = "0";
            this.txtPhiPV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhiPV_KeyPress);
            this.txtPhiPV.Leave += new System.EventHandler(this.txtPhiPV_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phí phục vụ";
            // 
            // txtNVThu
            // 
            this.txtNVThu.Enabled = false;
            this.txtNVThu.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNVThu.Location = new System.Drawing.Point(118, 137);
            this.txtNVThu.Name = "txtNVThu";
            this.txtNVThu.Size = new System.Drawing.Size(286, 26);
            this.txtNVThu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhân viên thu";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtThanhTien.Location = new System.Drawing.Point(118, 269);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(286, 26);
            this.txtThanhTien.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thành tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.Location = new System.Drawing.Point(118, 226);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(286, 26);
            this.txtTongTien.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng Tiền";
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.BackColor = System.Drawing.Color.Navy;
            this.btnLapPhieuThu.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLapPhieuThu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapPhieuThu.Location = new System.Drawing.Point(436, 224);
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            this.btnLapPhieuThu.Size = new System.Drawing.Size(130, 112);
            this.btnLapPhieuThu.TabIndex = 13;
            this.btnLapPhieuThu.Text = "Lập phiếu thu";
            this.btnLapPhieuThu.UseVisualStyleBackColor = false;
            this.btnLapPhieuThu.Click += new System.EventHandler(this.btnLapPhieuThu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Controls.Add(this.dgvCTPhieuTU);
            this.panel1.Controls.Add(this.btnLapPhieuThu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.txtPhieuTU);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtNgayThu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPhiPV);
            this.panel1.Controls.Add(this.txtNVThu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 658);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(223, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 34);
            this.label7.TabIndex = 36;
            this.label7.Text = "Lập Phiếu Thu";
            // 
            // closeForm
            // 
            this.closeForm.Image = ((System.Drawing.Image)(resources.GetObject("closeForm.Image")));
            this.closeForm.Location = new System.Drawing.Point(535, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(46, 48);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 35;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // frmLapPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 682);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLapPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLapPhieuThu";
            this.Load += new System.EventHandler(this.frmLapPhieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuTU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTPhieuTU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhieuTU;
        private System.Windows.Forms.TextBox txtNgayThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhiPV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNVThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLapPhieuThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox closeForm;
    }
}