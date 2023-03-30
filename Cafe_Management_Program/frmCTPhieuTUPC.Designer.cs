
namespace Cafe_Management_Program
{
    partial class frmCTPhieuTUPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPhieuTUPC));
            this.dgvCTPhieuTU = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhanXong = new System.Windows.Forms.Button();
            this.btnXacNhanXongTatCa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThucUong = new System.Windows.Forms.Label();
            this.txtPhieuTU = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTPhieuTU
            // 
            this.dgvCTPhieuTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuTU.Location = new System.Drawing.Point(15, 133);
            this.dgvCTPhieuTU.Name = "dgvCTPhieuTU";
            this.dgvCTPhieuTU.RowHeadersWidth = 51;
            this.dgvCTPhieuTU.RowTemplate.Height = 29;
            this.dgvCTPhieuTU.Size = new System.Drawing.Size(794, 380);
            this.dgvCTPhieuTU.TabIndex = 0;
            this.dgvCTPhieuTU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuTU_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu thức uống:";
            // 
            // btnXacNhanXong
            // 
            this.btnXacNhanXong.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhanXong.Location = new System.Drawing.Point(264, 521);
            this.btnXacNhanXong.Name = "btnXacNhanXong";
            this.btnXacNhanXong.Size = new System.Drawing.Size(178, 43);
            this.btnXacNhanXong.TabIndex = 3;
            this.btnXacNhanXong.Text = "Xác nhận xong món";
            this.btnXacNhanXong.UseVisualStyleBackColor = true;
            this.btnXacNhanXong.Click += new System.EventHandler(this.btnXacNhanXong_Click);
            // 
            // btnXacNhanXongTatCa
            // 
            this.btnXacNhanXongTatCa.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhanXongTatCa.Location = new System.Drawing.Point(524, 521);
            this.btnXacNhanXongTatCa.Name = "btnXacNhanXongTatCa";
            this.btnXacNhanXongTatCa.Size = new System.Drawing.Size(285, 43);
            this.btnXacNhanXongTatCa.TabIndex = 5;
            this.btnXacNhanXongTatCa.Text = "Xác nhận đã hoàn thành tất cả";
            this.btnXacNhanXongTatCa.UseVisualStyleBackColor = true;
            this.btnXacNhanXongTatCa.Click += new System.EventHandler(this.btnXacNhanXongTatCa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã thức uống:";
            // 
            // txtThucUong
            // 
            this.txtThucUong.AutoSize = true;
            this.txtThucUong.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtThucUong.Location = new System.Drawing.Point(155, 528);
            this.txtThucUong.Name = "txtThucUong";
            this.txtThucUong.Size = new System.Drawing.Size(58, 28);
            this.txtThucUong.TabIndex = 7;
            this.txtThucUong.Text = "label3";
            // 
            // txtPhieuTU
            // 
            this.txtPhieuTU.AutoSize = true;
            this.txtPhieuTU.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhieuTU.Location = new System.Drawing.Point(180, 86);
            this.txtPhieuTU.Name = "txtPhieuTU";
            this.txtPhieuTU.Size = new System.Drawing.Size(0, 28);
            this.txtPhieuTU.TabIndex = 8;
            // 
            // closeForm
            // 
            this.closeForm.Image = ((System.Drawing.Image)(resources.GetObject("closeForm.Image")));
            this.closeForm.Location = new System.Drawing.Point(763, 13);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(46, 48);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 30;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(309, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 34);
            this.label6.TabIndex = 34;
            this.label6.Text = "Xác Nhận Xong Phiếu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvCTPhieuTU);
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Controls.Add(this.btnXacNhanXong);
            this.panel1.Controls.Add(this.txtPhieuTU);
            this.panel1.Controls.Add(this.btnXacNhanXongTatCa);
            this.panel1.Controls.Add(this.txtThucUong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 582);
            this.panel1.TabIndex = 35;
            // 
            // frmCTPhieuTUPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(847, 606);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTPhieuTUPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCTPhieuTUPC";
            this.Load += new System.EventHandler(this.frmCTPhieuTUPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTPhieuTU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanXong;
        private System.Windows.Forms.Button btnXacNhanXongTatCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtThucUong;
        private System.Windows.Forms.Label txtPhieuTU;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}