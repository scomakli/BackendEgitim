namespace MoneyBox_Application
{
    partial class Form1
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
            System.Windows.Forms.Button btnBreak;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbMoneyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPara = new System.Windows.Forms.ComboBox();
            this.btnFold = new System.Windows.Forms.Button();
            this.btnSendMoney = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.listBoxTotal = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgglutinate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            btnBreak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBreak
            // 
            btnBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnBreak.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnBreak.Location = new System.Drawing.Point(7, 462);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new System.Drawing.Size(173, 81);
            btnBreak.TabIndex = 11;
            btnBreak.Text = "Kumbarayı Kır";
            btnBreak.UseVisualStyleBackColor = false;
            btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // cmbMoneyType
            // 
            this.cmbMoneyType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbMoneyType.FormattingEnabled = true;
            this.cmbMoneyType.Location = new System.Drawing.Point(216, 13);
            this.cmbMoneyType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMoneyType.Name = "cmbMoneyType";
            this.cmbMoneyType.Size = new System.Drawing.Size(241, 32);
            this.cmbMoneyType.TabIndex = 0;
            this.cmbMoneyType.SelectedIndexChanged += new System.EventHandler(this.cmbMoneyType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(186, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para Tipi Seçiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(186, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kumbaraya Atacağınız Parayı Seçiniz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPara
            // 
            this.cmbPara.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbPara.FormattingEnabled = true;
            this.cmbPara.Location = new System.Drawing.Point(216, 90);
            this.cmbPara.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPara.Name = "cmbPara";
            this.cmbPara.Size = new System.Drawing.Size(241, 32);
            this.cmbPara.TabIndex = 3;
            this.cmbPara.SelectedIndexChanged += new System.EventHandler(this.cmbPara_SelectedIndexChanged);
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFold.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFold.Location = new System.Drawing.Point(7, 201);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(173, 81);
            this.btnFold.TabIndex = 4;
            this.btnFold.Text = "Kağıt Parayı Katla";
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // btnSendMoney
            // 
            this.btnSendMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSendMoney.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMoney.Location = new System.Drawing.Point(7, 288);
            this.btnSendMoney.Name = "btnSendMoney";
            this.btnSendMoney.Size = new System.Drawing.Size(173, 81);
            this.btnSendMoney.TabIndex = 8;
            this.btnSendMoney.Text = "Parayı Kumbaraya At";
            this.btnSendMoney.UseVisualStyleBackColor = false;
            this.btnSendMoney.Click += new System.EventHandler(this.btnSendMoney_Click);
            // 
            // btnShake
            // 
            this.btnShake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShake.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShake.Location = new System.Drawing.Point(7, 375);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(173, 81);
            this.btnShake.TabIndex = 10;
            this.btnShake.Text = "Kumbarayı Salla";
            this.btnShake.UseVisualStyleBackColor = false;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // listBoxTotal
            // 
            this.listBoxTotal.FormattingEnabled = true;
            this.listBoxTotal.ItemHeight = 24;
            this.listBoxTotal.Location = new System.Drawing.Point(972, 2);
            this.listBoxTotal.Name = "listBoxTotal";
            this.listBoxTotal.Size = new System.Drawing.Size(317, 532);
            this.listBoxTotal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(665, 2);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(303, 78);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kumbaradaki Paralar Kumbara Kırıldıktan Sonra Sağdaki Listede Gözükecek.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(972, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(650, 616);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(316, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kumbaranın Doluluk Oranı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(665, 455);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(303, 79);
            this.label3.TabIndex = 14;
            this.label3.Text = "TOPLAM TUTARI GÖRMEK İÇİN KUMBARAYI KIRMANIZ GEREKİYOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(650, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kumbaradaki Toplam Para Miktarı ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgglutinate
            // 
            this.btnAgglutinate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgglutinate.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAgglutinate.Location = new System.Drawing.Point(7, 549);
            this.btnAgglutinate.Name = "btnAgglutinate";
            this.btnAgglutinate.Size = new System.Drawing.Size(173, 81);
            this.btnAgglutinate.TabIndex = 17;
            this.btnAgglutinate.Text = "Kumbarayı Yapıştır";
            this.btnAgglutinate.UseVisualStyleBackColor = false;
            this.btnAgglutinate.Click += new System.EventHandler(this.btnAgglutinate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(253, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 342);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 675);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAgglutinate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxTotal);
            this.Controls.Add(btnBreak);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSendMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.cmbPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMoneyType);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMoneyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPara;
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.Button btnSendMoney;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.ListBox listBoxTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgglutinate;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

