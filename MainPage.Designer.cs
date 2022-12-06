namespace Project_PRN211
{
    partial class MainPage
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonPrvMonth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(229, 33);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(250, 23);
            this.textBoxUserName.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(26, 33);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.Location = new System.Drawing.Point(274, 110);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(100, 23);
            this.buttonThisMonth.TabIndex = 2;
            this.buttonThisMonth.Text = "THÁNG NÀY";
            this.buttonThisMonth.UseVisualStyleBackColor = true;
            // 
            // buttonPrvMonth
            // 
            this.buttonPrvMonth.Location = new System.Drawing.Point(72, 110);
            this.buttonPrvMonth.Name = "buttonPrvMonth";
            this.buttonPrvMonth.Size = new System.Drawing.Size(113, 23);
            this.buttonPrvMonth.TabIndex = 3;
            this.buttonPrvMonth.Text = "THÁNG TRƯỚC";
            this.buttonPrvMonth.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "TƯƠNG LAI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(762, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.Location = new System.Drawing.Point(229, 323);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Size = new System.Drawing.Size(279, 23);
            this.buttonBaoCao.TabIndex = 6;
            this.buttonBaoCao.Text = "Xem báo cáo cho giai đoạn này";
            this.buttonBaoCao.UseVisualStyleBackColor = true;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(293, 60);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(100, 23);
            this.textBoxTongTien.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.buttonBaoCao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPrvMonth);
            this.Controls.Add(this.buttonThisMonth);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUserName;
        private PictureBox pictureBoxLogo;
        private Button buttonThisMonth;
        private Button buttonPrvMonth;
        private Button button1;
        private DataGridView dataGridView1;
        private Button buttonBaoCao;
        private TextBox textBoxTongTien;
    }
}