
namespace Project_CDIO2
{
    partial class frm_GiangVien_Page
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SinhVien = new System.Windows.Forms.Button();
            this.btn_GiangVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SinhVien);
            this.groupBox1.Controls.Add(this.btn_GiangVien);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.quayLạiToolStripMenuItem.Text = "Đóng chương trình";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // btn_SinhVien
            // 
            this.btn_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinhVien.Location = new System.Drawing.Point(6, 203);
            this.btn_SinhVien.Name = "btn_SinhVien";
            this.btn_SinhVien.Size = new System.Drawing.Size(244, 97);
            this.btn_SinhVien.TabIndex = 3;
            this.btn_SinhVien.Text = "Cài Đặt";
            this.btn_SinhVien.UseVisualStyleBackColor = true;
            // 
            // btn_GiangVien
            // 
            this.btn_GiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiangVien.Location = new System.Drawing.Point(6, 91);
            this.btn_GiangVien.Name = "btn_GiangVien";
            this.btn_GiangVien.Size = new System.Drawing.Size(244, 97);
            this.btn_GiangVien.TabIndex = 2;
            this.btn_GiangVien.Text = "Điểm Danh";
            this.btn_GiangVien.UseVisualStyleBackColor = true;
            this.btn_GiangVien.Click += new System.EventHandler(this.btn_GiangVien_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(272, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 586);
            this.panel1.TabIndex = 2;
            // 
            // frm_GiangVien_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_GiangVien_Page";
            this.Text = "Page Giảng Viên";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.Button btn_SinhVien;
        private System.Windows.Forms.Button btn_GiangVien;
        private System.Windows.Forms.Panel panel1;
    }
}