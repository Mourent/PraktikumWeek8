
namespace PraktikumWeek8
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
            this.cBoxHome = new System.Windows.Forms.ComboBox();
            this.cBoxAway = new System.Windows.Forms.ComboBox();
            this.labelVs = new System.Windows.Forms.Label();
            this.labelManager1 = new System.Windows.Forms.Label();
            this.labelCaptain1 = new System.Windows.Forms.Label();
            this.labelManager2 = new System.Windows.Forms.Label();
            this.labelCaptain2 = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelOutputCapacity = new System.Windows.Forms.Label();
            this.labelOutputStadium = new System.Windows.Forms.Label();
            this.labelOutputCaptain2 = new System.Windows.Forms.Label();
            this.labelOutputManager2 = new System.Windows.Forms.Label();
            this.labelOutputCaptain1 = new System.Windows.Forms.Label();
            this.labelOutputManager1 = new System.Windows.Forms.Label();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.labelOutTanggal = new System.Windows.Forms.Label();
            this.labelOutSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxHome
            // 
            this.cBoxHome.FormattingEnabled = true;
            this.cBoxHome.Location = new System.Drawing.Point(28, 22);
            this.cBoxHome.Name = "cBoxHome";
            this.cBoxHome.Size = new System.Drawing.Size(174, 21);
            this.cBoxHome.TabIndex = 0;
            this.cBoxHome.SelectedIndexChanged += new System.EventHandler(this.cBoxHome_SelectedIndexChanged);
            // 
            // cBoxAway
            // 
            this.cBoxAway.FormattingEnabled = true;
            this.cBoxAway.Location = new System.Drawing.Point(334, 22);
            this.cBoxAway.Name = "cBoxAway";
            this.cBoxAway.Size = new System.Drawing.Size(174, 21);
            this.cBoxAway.TabIndex = 1;
            this.cBoxAway.SelectedIndexChanged += new System.EventHandler(this.cBoxAway_SelectedIndexChanged);
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Location = new System.Drawing.Point(248, 25);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(21, 13);
            this.labelVs.TabIndex = 2;
            this.labelVs.Text = "VS";
            // 
            // labelManager1
            // 
            this.labelManager1.AutoSize = true;
            this.labelManager1.Location = new System.Drawing.Point(25, 77);
            this.labelManager1.Name = "labelManager1";
            this.labelManager1.Size = new System.Drawing.Size(55, 13);
            this.labelManager1.TabIndex = 3;
            this.labelManager1.Text = "Manager :";
            // 
            // labelCaptain1
            // 
            this.labelCaptain1.AutoSize = true;
            this.labelCaptain1.Location = new System.Drawing.Point(25, 116);
            this.labelCaptain1.Name = "labelCaptain1";
            this.labelCaptain1.Size = new System.Drawing.Size(49, 13);
            this.labelCaptain1.TabIndex = 4;
            this.labelCaptain1.Text = "Captain :";
            // 
            // labelManager2
            // 
            this.labelManager2.AutoSize = true;
            this.labelManager2.Location = new System.Drawing.Point(331, 77);
            this.labelManager2.Name = "labelManager2";
            this.labelManager2.Size = new System.Drawing.Size(55, 13);
            this.labelManager2.TabIndex = 5;
            this.labelManager2.Text = "Manager :";
            // 
            // labelCaptain2
            // 
            this.labelCaptain2.AutoSize = true;
            this.labelCaptain2.Location = new System.Drawing.Point(331, 116);
            this.labelCaptain2.Name = "labelCaptain2";
            this.labelCaptain2.Size = new System.Drawing.Size(49, 13);
            this.labelCaptain2.TabIndex = 6;
            this.labelCaptain2.Text = "Captain :";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(167, 172);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(51, 13);
            this.labelStadium.TabIndex = 7;
            this.labelStadium.Text = "Stadium :";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(167, 217);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(54, 13);
            this.labelCapacity.TabIndex = 8;
            this.labelCapacity.Text = "Capacity :";
            // 
            // labelOutputCapacity
            // 
            this.labelOutputCapacity.AutoSize = true;
            this.labelOutputCapacity.Location = new System.Drawing.Point(230, 217);
            this.labelOutputCapacity.Name = "labelOutputCapacity";
            this.labelOutputCapacity.Size = new System.Drawing.Size(0, 13);
            this.labelOutputCapacity.TabIndex = 14;
            // 
            // labelOutputStadium
            // 
            this.labelOutputStadium.AutoSize = true;
            this.labelOutputStadium.Location = new System.Drawing.Point(230, 172);
            this.labelOutputStadium.Name = "labelOutputStadium";
            this.labelOutputStadium.Size = new System.Drawing.Size(0, 13);
            this.labelOutputStadium.TabIndex = 13;
            // 
            // labelOutputCaptain2
            // 
            this.labelOutputCaptain2.AutoSize = true;
            this.labelOutputCaptain2.Location = new System.Drawing.Point(394, 116);
            this.labelOutputCaptain2.Name = "labelOutputCaptain2";
            this.labelOutputCaptain2.Size = new System.Drawing.Size(0, 13);
            this.labelOutputCaptain2.TabIndex = 12;
            // 
            // labelOutputManager2
            // 
            this.labelOutputManager2.AutoSize = true;
            this.labelOutputManager2.Location = new System.Drawing.Point(394, 77);
            this.labelOutputManager2.Name = "labelOutputManager2";
            this.labelOutputManager2.Size = new System.Drawing.Size(0, 13);
            this.labelOutputManager2.TabIndex = 11;
            // 
            // labelOutputCaptain1
            // 
            this.labelOutputCaptain1.AutoSize = true;
            this.labelOutputCaptain1.Location = new System.Drawing.Point(88, 116);
            this.labelOutputCaptain1.Name = "labelOutputCaptain1";
            this.labelOutputCaptain1.Size = new System.Drawing.Size(0, 13);
            this.labelOutputCaptain1.TabIndex = 10;
            // 
            // labelOutputManager1
            // 
            this.labelOutputManager1.AutoSize = true;
            this.labelOutputManager1.Location = new System.Drawing.Point(88, 77);
            this.labelOutputManager1.Name = "labelOutputManager1";
            this.labelOutputManager1.Size = new System.Drawing.Size(0, 13);
            this.labelOutputManager1.TabIndex = 9;
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(12, 368);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.Size = new System.Drawing.Size(505, 233);
            this.dgvMatch.TabIndex = 15;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(219, 245);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(179, 290);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(52, 13);
            this.labelTanggal.TabIndex = 17;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Location = new System.Drawing.Point(196, 327);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(35, 13);
            this.labelSkor.TabIndex = 18;
            this.labelSkor.Text = "Skor :";
            // 
            // labelOutTanggal
            // 
            this.labelOutTanggal.AutoSize = true;
            this.labelOutTanggal.Location = new System.Drawing.Point(242, 290);
            this.labelOutTanggal.Name = "labelOutTanggal";
            this.labelOutTanggal.Size = new System.Drawing.Size(13, 13);
            this.labelOutTanggal.TabIndex = 19;
            this.labelOutTanggal.Text = "--";
            // 
            // labelOutSkor
            // 
            this.labelOutSkor.AutoSize = true;
            this.labelOutSkor.Location = new System.Drawing.Point(242, 327);
            this.labelOutSkor.Name = "labelOutSkor";
            this.labelOutSkor.Size = new System.Drawing.Size(13, 13);
            this.labelOutSkor.TabIndex = 20;
            this.labelOutSkor.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 624);
            this.Controls.Add(this.labelOutSkor);
            this.Controls.Add(this.labelOutTanggal);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.labelOutputCapacity);
            this.Controls.Add(this.labelOutputStadium);
            this.Controls.Add(this.labelOutputCaptain2);
            this.Controls.Add(this.labelOutputManager2);
            this.Controls.Add(this.labelOutputCaptain1);
            this.Controls.Add(this.labelOutputManager1);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelCaptain2);
            this.Controls.Add(this.labelManager2);
            this.Controls.Add(this.labelCaptain1);
            this.Controls.Add(this.labelManager1);
            this.Controls.Add(this.labelVs);
            this.Controls.Add(this.cBoxAway);
            this.Controls.Add(this.cBoxHome);
            this.Name = "Form1";
            this.Text = "Manager :";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxHome;
        private System.Windows.Forms.ComboBox cBoxAway;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.Label labelManager1;
        private System.Windows.Forms.Label labelCaptain1;
        private System.Windows.Forms.Label labelManager2;
        private System.Windows.Forms.Label labelCaptain2;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelOutputCapacity;
        private System.Windows.Forms.Label labelOutputStadium;
        private System.Windows.Forms.Label labelOutputCaptain2;
        private System.Windows.Forms.Label labelOutputManager2;
        private System.Windows.Forms.Label labelOutputCaptain1;
        private System.Windows.Forms.Label labelOutputManager1;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Label labelOutTanggal;
        private System.Windows.Forms.Label labelOutSkor;
    }
}

