namespace kwMusic
{
    partial class frmBackGround
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackGround));
            this.palPlay = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.picLast = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLyrics = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.palPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // palPlay
            // 
            this.palPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.palPlay.Controls.Add(this.lblTime);
            this.palPlay.Controls.Add(this.picLast);
            this.palPlay.Controls.Add(this.picNext);
            this.palPlay.Controls.Add(this.picPlay);
            this.palPlay.Location = new System.Drawing.Point(-1, 300);
            this.palPlay.Name = "palPlay";
            this.palPlay.Size = new System.Drawing.Size(643, 62);
            this.palPlay.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AllowDrop = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.lblTime.Location = new System.Drawing.Point(562, 36);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 23);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLast
            // 
            this.picLast.BackColor = System.Drawing.Color.Transparent;
            this.picLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLast.BackgroundImage")));
            this.picLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLast.Location = new System.Drawing.Point(31, 19);
            this.picLast.Name = "picLast";
            this.picLast.Size = new System.Drawing.Size(24, 24);
            this.picLast.TabIndex = 1;
            this.picLast.TabStop = false;
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNext.BackgroundImage")));
            this.picNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNext.Location = new System.Drawing.Point(103, 18);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(24, 24);
            this.picNext.TabIndex = 1;
            this.picNext.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::kwMusic.Properties.Resources.pause;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Location = new System.Drawing.Point(61, 12);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(36, 36);
            this.picPlay.TabIndex = 1;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(617, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 16);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "×";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLyrics
            // 
            this.lblLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.lblLyrics.Location = new System.Drawing.Point(-3, 100);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(198, 38);
            this.lblLyrics.TabIndex = 3;
            this.lblLyrics.Text = "Lyrics";
            this.lblLyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 210);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(157, 91);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(473, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmBackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.palPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackGround";
            this.Load += new System.EventHandler(this.frmBackGround_Load);
            this.palPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palPlay;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picLast;
        private System.Windows.Forms.Label lblExit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.ListBox listBox1;
    }
}

