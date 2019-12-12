namespace QR_CODE_READER
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnkameraac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnqrcodescanner = new System.Windows.Forms.Button();
            this.btnqrcodeadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnkameraac
            // 
            this.btnkameraac.Location = new System.Drawing.Point(41, 60);
            this.btnkameraac.Name = "btnkameraac";
            this.btnkameraac.Size = new System.Drawing.Size(98, 52);
            this.btnkameraac.TabIndex = 1;
            this.btnkameraac.Text = "Kamera Aç";
            this.btnkameraac.UseVisualStyleBackColor = true;
            this.btnkameraac.Click += new System.EventHandler(this.btnkameraac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAMERA AÇ";
            // 
            // btnqrcodescanner
            // 
            this.btnqrcodescanner.Location = new System.Drawing.Point(163, 60);
            this.btnqrcodescanner.Name = "btnqrcodescanner";
            this.btnqrcodescanner.Size = new System.Drawing.Size(98, 52);
            this.btnqrcodescanner.TabIndex = 1;
            this.btnqrcodescanner.Text = "QR KOD TARA";
            this.btnqrcodescanner.UseVisualStyleBackColor = true;
            this.btnqrcodescanner.Click += new System.EventHandler(this.btnqrcodescanner_Click);
            // 
            // btnqrcodeadd
            // 
            this.btnqrcodeadd.Location = new System.Drawing.Point(302, 60);
            this.btnqrcodeadd.Name = "btnqrcodeadd";
            this.btnqrcodeadd.Size = new System.Drawing.Size(98, 52);
            this.btnqrcodeadd.TabIndex = 1;
            this.btnqrcodeadd.Text = "QR KOD EKLE";
            this.btnqrcodeadd.UseVisualStyleBackColor = true;
            this.btnqrcodeadd.Click += new System.EventHandler(this.btnqrcodeadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(41, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 212);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 22);
            this.textBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(344, 381);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(113, 61);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 454);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnqrcodeadd);
            this.Controls.Add(this.btnqrcodescanner);
            this.Controls.Add(this.btnkameraac);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR CODE READER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnkameraac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnqrcodescanner;
        private System.Windows.Forms.Button btnqrcodeadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnexit;
    }
}

