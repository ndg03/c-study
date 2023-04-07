namespace Screensaver_Zhiyin
{
    partial class FrmScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScreen));
            this.lbl_ngm = new System.Windows.Forms.Label();
            this.tim_ngm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_ngm
            // 
            this.lbl_ngm.AutoSize = true;
            this.lbl_ngm.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ngm.ForeColor = System.Drawing.Color.Red;
            this.lbl_ngm.Location = new System.Drawing.Point(195, 83);
            this.lbl_ngm.Name = "lbl_ngm";
            this.lbl_ngm.Size = new System.Drawing.Size(214, 33);
            this.lbl_ngm.TabIndex = 0;
            this.lbl_ngm.Text = "你干嘛~~哎哟";
            // 
            // tim_ngm
            // 
            this.tim_ngm.Enabled = true;
            this.tim_ngm.Tick += new System.EventHandler(this.tim_ngm_Tick);
            // 
            // FrmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(638, 622);
            this.Controls.Add(this.lbl_ngm);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScreen";
            this.Text = "你干嘛~~哎哟";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmScreen_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ngm;
        private System.Windows.Forms.Timer tim_ngm;
    }
}

