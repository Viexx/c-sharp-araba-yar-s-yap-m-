
namespace ArabaYarisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.patlama = new System.Windows.Forms.PictureBox();
            this.bizimaraba = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_skor = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_yuksekskor = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.patlama);
            this.panel1.Controls.Add(this.bizimaraba);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(18, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // patlama
            // 
            this.patlama.Image = global::ArabaYarisi.Properties.Resources.explosion;
            this.patlama.Location = new System.Drawing.Point(185, 276);
            this.patlama.Name = "patlama";
            this.patlama.Size = new System.Drawing.Size(101, 88);
            this.patlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patlama.TabIndex = 2;
            this.patlama.TabStop = false;
            // 
            // bizimaraba
            // 
            this.bizimaraba.Image = global::ArabaYarisi.Properties.Resources.araba5;
            this.bizimaraba.Location = new System.Drawing.Point(217, 370);
            this.bizimaraba.Name = "bizimaraba";
            this.bizimaraba.Size = new System.Drawing.Size(69, 134);
            this.bizimaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizimaraba.TabIndex = 1;
            this.bizimaraba.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::ArabaYarisi.Properties.Resources.araba8;
            this.araba2.Location = new System.Drawing.Point(349, 65);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(69, 134);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 1;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::ArabaYarisi.Properties.Resources.araba4;
            this.araba1.Location = new System.Drawing.Point(88, 65);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(69, 134);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 1;
            this.araba1.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::ArabaYarisi.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(0, -1);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(513, 775);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(389, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SKOR :";
            // 
            // lbl_skor
            // 
            this.lbl_skor.AutoSize = true;
            this.lbl_skor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_skor.Location = new System.Drawing.Point(490, 538);
            this.lbl_skor.Name = "lbl_skor";
            this.lbl_skor.Size = new System.Drawing.Size(26, 29);
            this.lbl_skor.TabIndex = 1;
            this.lbl_skor.Text = "0";
            // 
            // btn_basla
            // 
            this.btn_basla.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_basla.ImageIndex = 0;
            this.btn_basla.ImageList = this.ımageList1;
            this.btn_basla.Location = new System.Drawing.Point(19, 583);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(506, 65);
            this.btn_basla.TabIndex = 2;
            this.btn_basla.Text = "OYUNA BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yüksek Skor :";
            // 
            // lbl_yuksekskor
            // 
            this.lbl_yuksekskor.AutoSize = true;
            this.lbl_yuksekskor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yuksekskor.Location = new System.Drawing.Point(189, 538);
            this.lbl_yuksekskor.Name = "lbl_yuksekskor";
            this.lbl_yuksekskor.Size = new System.Drawing.Size(26, 29);
            this.lbl_yuksekskor.TabIndex = 1;
            this.lbl_yuksekskor.Text = "0";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "basla.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.lbl_yuksekskor);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Yarışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox bizimaraba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox patlama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_skor;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_yuksekskor;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

