
namespace Cafe_Management_Program
{
    partial class frmPhieuTUDangCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTUDangCho));
            this.dgvPhieuTUDangCho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTUDangCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuTUDangCho
            // 
            this.dgvPhieuTUDangCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTUDangCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuTUDangCho.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuTUDangCho.Location = new System.Drawing.Point(12, 63);
            this.dgvPhieuTUDangCho.Name = "dgvPhieuTUDangCho";
            this.dgvPhieuTUDangCho.RowHeadersWidth = 51;
            this.dgvPhieuTUDangCho.RowTemplate.Height = 29;
            this.dgvPhieuTUDangCho.Size = new System.Drawing.Size(1121, 551);
            this.dgvPhieuTUDangCho.TabIndex = 0;
            this.dgvPhieuTUDangCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTUDangCho_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(438, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phiếu Thức Uống Đang Chờ";
            // 
            // closeForm
            // 
            this.closeForm.Image = ((System.Drawing.Image)(resources.GetObject("closeForm.Image")));
            this.closeForm.Location = new System.Drawing.Point(1087, 9);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(46, 48);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 36;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // frmPhieuTUDangCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 626);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPhieuTUDangCho);
            this.Name = "frmPhieuTUDangCho";
            this.Text = "frmPhieuTUDangCho";
            this.Load += new System.EventHandler(this.frmPhieuTUDangCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTUDangCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuTUDangCho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closeForm;
    }
}