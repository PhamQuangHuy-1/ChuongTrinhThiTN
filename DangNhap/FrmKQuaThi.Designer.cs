namespace DangNhap
{
    partial class FrmKQuaThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKQuaThi));
            this.grdData5 = new System.Windows.Forms.DataGridView();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuatBang = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grdData6 = new System.Windows.Forms.DataGridView();
            this.MaBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData6)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.MaMon,
            this.ExamID,
            this.SoDiem});
            this.grdData5.Location = new System.Drawing.Point(12, 12);
            this.grdData5.Name = "grdData5";
            this.grdData5.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdData5.RowHeadersWidth = 62;
            this.grdData5.RowTemplate.Height = 28;
            this.grdData5.Size = new System.Drawing.Size(1007, 466);
            this.grdData5.TabIndex = 0;
            // 
            // MaND
            // 
            this.MaND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaND.DataPropertyName = "MaND";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaND.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaND.HeaderText = "Mã Sinh Viên";
            this.MaND.MinimumWidth = 12;
            this.MaND.Name = "MaND";
            this.MaND.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.DataPropertyName = "MaMon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.MinimumWidth = 8;
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // ExamID
            // 
            this.ExamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExamID.DataPropertyName = "ExamID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExamID.HeaderText = "ExamID";
            this.ExamID.MinimumWidth = 8;
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            // 
            // SoDiem
            // 
            this.SoDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDiem.DataPropertyName = "SoDiem";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDiem.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoDiem.HeaderText = "Số Điểm";
            this.SoDiem.MinimumWidth = 8;
            this.SoDiem.Name = "SoDiem";
            this.SoDiem.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXuatBang
            // 
            this.btnXuatBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBang.Location = new System.Drawing.Point(12, 510);
            this.btnXuatBang.Name = "btnXuatBang";
            this.btnXuatBang.Size = new System.Drawing.Size(215, 42);
            this.btnXuatBang.TabIndex = 15;
            this.btnXuatBang.Text = "Xuất bảng điểm";
            this.btnXuatBang.UseVisualStyleBackColor = true;
            this.btnXuatBang.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(355, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xem chi tiết bài làm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grdData6
            // 
            this.grdData6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBL});
            this.grdData6.Location = new System.Drawing.Point(12, 12);
            this.grdData6.Name = "grdData6";
            this.grdData6.RowHeadersWidth = 62;
            this.grdData6.RowTemplate.Height = 28;
            this.grdData6.Size = new System.Drawing.Size(1007, 466);
            this.grdData6.TabIndex = 17;
            // 
            // MaBL
            // 
            this.MaBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBL.DataPropertyName = "MaBL";
            this.MaBL.HeaderText = "MaBL";
            this.MaBL.MinimumWidth = 8;
            this.MaBL.Name = "MaBL";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(222, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 42);
            this.button4.TabIndex = 18;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmKQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 565);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXuatBang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdData5);
            this.Controls.Add(this.grdData6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKQuaThi";
            this.Text = "FrmKQuaThi";
            this.Load += new System.EventHandler(this.FrmKQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXuatBang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDiem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grdData6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBL;
    }
}