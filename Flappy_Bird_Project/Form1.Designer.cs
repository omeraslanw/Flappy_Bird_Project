namespace Flappy_Bird_Project
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
            this.birdPic = new System.Windows.Forms.PictureBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.groundPic = new System.Windows.Forms.PictureBox();
            this.bottomPic = new System.Windows.Forms.PictureBox();
            this.topPic2 = new System.Windows.Forms.PictureBox();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPic1 = new System.Windows.Forms.PictureBox();
            this.scoreBoardLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restartLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPic1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // birdPic
            // 
            this.birdPic.Image = ((System.Drawing.Image)(resources.GetObject("birdPic.Image")));
            this.birdPic.Location = new System.Drawing.Point(100, 200);
            this.birdPic.Name = "birdPic";
            this.birdPic.Size = new System.Drawing.Size(125, 82);
            this.birdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdPic.TabIndex = 0;
            this.birdPic.TabStop = false;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLbl.Location = new System.Drawing.Point(12, 22);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(203, 55);
            this.scoreLbl.TabIndex = 4;
            this.scoreLbl.Text = "Score: 0";
            // 
            // groundPic
            // 
            this.groundPic.Image = ((System.Drawing.Image)(resources.GetObject("groundPic.Image")));
            this.groundPic.Location = new System.Drawing.Point(1, 557);
            this.groundPic.Name = "groundPic";
            this.groundPic.Size = new System.Drawing.Size(1177, 150);
            this.groundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundPic.TabIndex = 5;
            this.groundPic.TabStop = false;
            // 
            // bottomPic
            // 
            this.bottomPic.Image = ((System.Drawing.Image)(resources.GetObject("bottomPic.Image")));
            this.bottomPic.Location = new System.Drawing.Point(615, 356);
            this.bottomPic.Name = "bottomPic";
            this.bottomPic.Size = new System.Drawing.Size(150, 200);
            this.bottomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPic.TabIndex = 6;
            this.bottomPic.TabStop = false;
            // 
            // topPic2
            // 
            this.topPic2.Image = ((System.Drawing.Image)(resources.GetObject("topPic2.Image")));
            this.topPic2.Location = new System.Drawing.Point(815, 2);
            this.topPic2.Name = "topPic2";
            this.topPic2.Size = new System.Drawing.Size(150, 200);
            this.topPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPic2.TabIndex = 7;
            this.topPic2.TabStop = false;
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.BackColor = System.Drawing.Color.Gray;
            this.gameOverLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverLbl.ForeColor = System.Drawing.Color.Black;
            this.gameOverLbl.Location = new System.Drawing.Point(253, 159);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(430, 87);
            this.gameOverLbl.TabIndex = 8;
            this.gameOverLbl.Text = "Game Over!";
            this.gameOverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topPic1
            // 
            this.topPic1.Image = ((System.Drawing.Image)(resources.GetObject("topPic1.Image")));
            this.topPic1.Location = new System.Drawing.Point(300, 2);
            this.topPic1.Name = "topPic1";
            this.topPic1.Size = new System.Drawing.Size(150, 135);
            this.topPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPic1.TabIndex = 9;
            this.topPic1.TabStop = false;
            // 
            // scoreBoardLbl
            // 
            this.scoreBoardLbl.BackColor = System.Drawing.Color.Gray;
            this.scoreBoardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreBoardLbl.Location = new System.Drawing.Point(319, 259);
            this.scoreBoardLbl.Name = "scoreBoardLbl";
            this.scoreBoardLbl.Size = new System.Drawing.Size(286, 87);
            this.scoreBoardLbl.TabIndex = 11;
            this.scoreBoardLbl.Text = "Score:";
            this.scoreBoardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.restartLbl);
            this.panel1.Controls.Add(this.gameOverLbl);
            this.panel1.Controls.Add(this.scoreBoardLbl);
            this.panel1.Location = new System.Drawing.Point(100, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 508);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // restartLbl
            // 
            this.restartLbl.BackColor = System.Drawing.Color.Olive;
            this.restartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restartLbl.Location = new System.Drawing.Point(356, 358);
            this.restartLbl.Name = "restartLbl";
            this.restartLbl.Size = new System.Drawing.Size(218, 74);
            this.restartLbl.TabIndex = 12;
            this.restartLbl.Text = "Restart";
            this.restartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartLbl.Click += new System.EventHandler(this.restartLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(326, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 93);
            this.label1.TabIndex = 14;
            this.label1.Text = "Flappy Bird";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Copy Right | Ömer Faruk Aslan | @omeraslanw36@gmail.com | 2023";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1178, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPic1);
            this.Controls.Add(this.topPic2);
            this.Controls.Add(this.bottomPic);
            this.Controls.Add(this.groundPic);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.birdPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.birdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPic1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox birdPic;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.PictureBox groundPic;
        private System.Windows.Forms.PictureBox bottomPic;
        private System.Windows.Forms.PictureBox topPic2;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox topPic1;
        private System.Windows.Forms.Label scoreBoardLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label restartLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

