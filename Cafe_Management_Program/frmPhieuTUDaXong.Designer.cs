
namespace Cafe_Management_Program
{
    partial class frmPhieuTUDaXong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTUDaXong));
            this.dgvPhieuTUDaXong = new System.Windows.Forms.DataGridView();
            this.dgvCTPhieuTUDaXong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYCTT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhieuTU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTUDaXong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuTUDaXong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuTUDaXong
            // 
            this.dgvPhieuTUDaXong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTUDaXong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuTUDaXong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuTUDaXong.Location = new System.Drawing.Point(28, 63);
            this.dgvPhieuTUDaXong.Name = "dgvPhieuTUDaXong";
            this.dgvPhieuTUDaXong.RowHeadersWidth = 51;
            this.dgvPhieuTUDaXong.RowTemplate.Height = 29;
            this.dgvPhieuTUDaXong.Size = new System.Drawing.Size(1108, 183);
            this.dgvPhieuTUDaXong.TabIndex = 0;
            this.dgvPhieuTUDaXong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTUDaXong_CellClick);
            // 
            // dgvCTPhieuTUDaXong
            // 
            this.dgvCTPhieuTUDaXong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPhieuTUDaXong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuTUDaXong.Location = new System.Drawing.Point(16, 79);
            this.dgvCTPhieuTUDaXong.Name = "dgvCTPhieuTUDaXong";
            this.dgvCTPhieuTUDaXong.RowHeadersWidth = 51;
            this.dgvCTPhieuTUDaXong.RowTemplate.Height = 29;
            this.dgvCTPhieuTUDaXong.Size = new System.Drawing.Size(1108, 233);
            this.dgvCTPhieuTUDaXong.TabIndex = 1;
            this.dgvCTPhieuTUDaXong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuTUDaXong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số phiếu thức uống :";
            // 
            // btnYCTT
            // 
            this.btnYCTT.BackColor = System.Drawing.Color.Navy;
            this.btnYCTT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnYCTT.Location = new System.Drawing.Point(703, 26);
            this.btnYCTT.Name = "btnYCTT";
            this.btnYCTT.Size = new System.Drawing.Size(421, 44);
            this.btnYCTT.TabIndex = 4;
            this.btnYCTT.Text = "Gửi Yêu Cầu Tính Tiền";
            this.btnYCTT.UseVisualStyleBackColor = false;
            this.btnYCTT.Click += new System.EventHandler(this.btnYCTT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhieuTU);
            this.groupBox1.Controls.Add(this.btnYCTT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvCTPhieuTUDaXong);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1143, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT PHIẾU THỨC UỐNG";
            // 
            // txtPhieuTU
            // 
            this.txtPhieuTU.AutoSize = true;
            this.txtPhieuTU.Location = new System.Drawing.Point(191, 34);
            this.txtPhieuTU.Name = "txtPhieuTU";
            this.txtPhieuTU.Size = new System.Drawing.Size(0, 28);
            this.txtPhieuTU.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(448, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phiếu Thức Uống Đã Xong";
            // 
            // closeForm
            // 
            this.closeForm.Image = ((System.Drawing.Image)(resources.GetObject("closeForm.Image")));
            this.closeForm.Location = new System.Drawing.Point(1090, 9);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(46, 48);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 36;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // frmPhieuTUDaXong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 604);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhieuTUDaXong);
            this.Name = "frmPhieuTUDaXong";
            this.Text = "frmPhieuTUDaXong";
            this.Load += new System.EventHandler(this.frmPhieuTUDaXong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTUDaXong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuTUDaXong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuTUDaXong;
        private System.Windows.Forms.DataGridView dgvCTPhieuTUDaXong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYCTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtPhieuTU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closeForm;
    }
}