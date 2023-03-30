
namespace Cafe_Management_Program
{
    partial class frmPhieuTUChoThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTUChoThanhToan));
            this.dgvPhieuTUChoTT = new System.Windows.Forms.DataGridView();
            this.btnLapPhieuThu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhieuTU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTUChoTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuTUChoTT
            // 
            this.dgvPhieuTUChoTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTUChoTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuTUChoTT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuTUChoTT.Location = new System.Drawing.Point(29, 132);
            this.dgvPhieuTUChoTT.Name = "dgvPhieuTUChoTT";
            this.dgvPhieuTUChoTT.RowHeadersWidth = 51;
            this.dgvPhieuTUChoTT.RowTemplate.Height = 29;
            this.dgvPhieuTUChoTT.Size = new System.Drawing.Size(1130, 387);
            this.dgvPhieuTUChoTT.TabIndex = 0;
            this.dgvPhieuTUChoTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTUChoTT_CellClick);
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.BackColor = System.Drawing.Color.Navy;
            this.btnLapPhieuThu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLapPhieuThu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLapPhieuThu.Location = new System.Drawing.Point(833, 540);
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            this.btnLapPhieuThu.Size = new System.Drawing.Size(326, 48);
            this.btnLapPhieuThu.TabIndex = 1;
            this.btnLapPhieuThu.Text = "Lập phiếu thu";
            this.btnLapPhieuThu.UseVisualStyleBackColor = false;
            this.btnLapPhieuThu.Click += new System.EventHandler(this.btnLapPhieuThu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phiếu đang chọn :";
            // 
            // txtPhieuTU
            // 
            this.txtPhieuTU.AutoSize = true;
            this.txtPhieuTU.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhieuTU.Location = new System.Drawing.Point(206, 552);
            this.txtPhieuTU.Name = "txtPhieuTU";
            this.txtPhieuTU.Size = new System.Drawing.Size(0, 28);
            this.txtPhieuTU.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(500, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phiếu Chờ Thanh Toán";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(323, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "In Phiếu Tính Tiền";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeForm
            // 
            this.closeForm.Image = ((System.Drawing.Image)(resources.GetObject("closeForm.Image")));
            this.closeForm.Location = new System.Drawing.Point(1113, 34);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(46, 48);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 36;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // frmPhieuTUChoThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 604);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhieuTU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLapPhieuThu);
            this.Controls.Add(this.dgvPhieuTUChoTT);
            this.Name = "frmPhieuTUChoThanhToan";
            this.Text = "frmPhieuTUChoThanhToan";
            this.Load += new System.EventHandler(this.frmPhieuTUChoThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTUChoTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuTUChoTT;
        private System.Windows.Forms.Button btnLapPhieuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPhieuTU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox closeForm;
    }
}