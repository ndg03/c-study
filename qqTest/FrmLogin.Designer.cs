namespace qqTest
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.butLogin = new System.Windows.Forms.Button();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.panelUpLine = new System.Windows.Forms.Panel();
            this.panelDownLine = new System.Windows.Forms.Panel();
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxRemeber = new System.Windows.Forms.CheckBox();
            this.lblFindPassword = new System.Windows.Forms.Label();
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            this.butExit = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.picQRcode = new System.Windows.Forms.PictureBox();
            this.picQQ = new System.Windows.Forms.PictureBox();
            this.lblQQ = new System.Windows.Forms.Label();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picKeyborad = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlus = new System.Windows.Forms.PictureBox();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyborad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(186)))), ((int)(((byte)(251)))));
            this.butLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(92, 243);
            this.butLogin.Margin = new System.Windows.Forms.Padding(4);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(246, 43);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.but_login_Click);
            // 
            // tbAccount
            // 
            this.tbAccount.BackColor = System.Drawing.Color.White;
            this.tbAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAccount.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAccount.Location = new System.Drawing.Point(126, 142);
            this.tbAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(212, 37);
            this.tbAccount.TabIndex = 4;
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.Color.White;
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKey.Font = new System.Drawing.Font("宋体", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbKey.Location = new System.Drawing.Point(124, 183);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(214, 37);
            this.tbKey.TabIndex = 5;
            this.tbKey.UseSystemPasswordChar = true;
            // 
            // panelUpLine
            // 
            this.panelUpLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelUpLine.Location = new System.Drawing.Point(95, 178);
            this.panelUpLine.Name = "panelUpLine";
            this.panelUpLine.Size = new System.Drawing.Size(243, 1);
            this.panelUpLine.TabIndex = 6;
            // 
            // panelDownLine
            // 
            this.panelDownLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelDownLine.Location = new System.Drawing.Point(93, 220);
            this.panelDownLine.Name = "panelDownLine";
            this.panelDownLine.Size = new System.Drawing.Size(245, 1);
            this.panelDownLine.TabIndex = 7;
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHead.BackgroundImage")));
            this.pictureBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHead.Location = new System.Drawing.Point(180, 81);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(67, 63);
            this.pictureBoxHead.TabIndex = 8;
            this.pictureBoxHead.TabStop = false;
            this.pictureBoxHead.MouseEnter += new System.EventHandler(this.pictureBoxHead_MouseEnter);
            this.pictureBoxHead.MouseLeave += new System.EventHandler(this.pictureBoxHead_MouseLeave);
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.checkBoxLogin.Location = new System.Drawing.Point(92, 224);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(82, 18);
            this.checkBoxLogin.TabIndex = 9;
            this.checkBoxLogin.Text = "自动登录";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemeber
            // 
            this.checkBoxRemeber.AutoSize = true;
            this.checkBoxRemeber.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxRemeber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.checkBoxRemeber.Location = new System.Drawing.Point(180, 224);
            this.checkBoxRemeber.Name = "checkBoxRemeber";
            this.checkBoxRemeber.Size = new System.Drawing.Size(82, 18);
            this.checkBoxRemeber.TabIndex = 10;
            this.checkBoxRemeber.Text = "记住密码";
            this.checkBoxRemeber.UseVisualStyleBackColor = true;
            // 
            // lblFindPassword
            // 
            this.lblFindPassword.AutoSize = true;
            this.lblFindPassword.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFindPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblFindPassword.Location = new System.Drawing.Point(275, 225);
            this.lblFindPassword.Name = "lblFindPassword";
            this.lblFindPassword.Size = new System.Drawing.Size(63, 14);
            this.lblFindPassword.TabIndex = 11;
            this.lblFindPassword.Text = "找回密码";

            // 
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccount.BackgroundImage")));
            this.pictureBoxAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAccount.Location = new System.Drawing.Point(95, 154);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(24, 22);
            this.pictureBoxAccount.TabIndex = 13;
            this.pictureBoxAccount.TabStop = false;
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKey.BackgroundImage")));
            this.pictureBoxKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKey.Location = new System.Drawing.Point(93, 196);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(24, 22);
            this.pictureBoxKey.TabIndex = 14;
            this.pictureBoxKey.TabStop = false;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Transparent;
            this.butExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butExit.Location = new System.Drawing.Point(391, 1);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(39, 37);
            this.butExit.TabIndex = 15;
            this.butExit.Text = "×";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.but_exit_Click);
            this.butExit.MouseEnter += new System.EventHandler(this.but_exit_MouseEnter);
            this.butExit.MouseLeave += new System.EventHandler(this.but_exit_MouseLeave);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblRegister.Location = new System.Drawing.Point(12, 309);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(59, 13);
            this.lblRegister.TabIndex = 16;
            this.lblRegister.Text = "注册账号";
            // 
            // picQRcode
            // 
            this.picQRcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQRcode.Image = ((System.Drawing.Image)(resources.GetObject("picQRcode.Image")));
            this.picQRcode.Location = new System.Drawing.Point(382, 289);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(35, 33);
            this.picQRcode.TabIndex = 17;
            this.picQRcode.TabStop = false;
            // 
            // picQQ
            // 
            this.picQQ.BackColor = System.Drawing.Color.Transparent;
            this.picQQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQQ.BackgroundImage")));
            this.picQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQQ.Location = new System.Drawing.Point(12, 12);
            this.picQQ.Name = "picQQ";
            this.picQQ.Size = new System.Drawing.Size(44, 46);
            this.picQQ.TabIndex = 18;
            this.picQQ.TabStop = false;
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.BackColor = System.Drawing.Color.Transparent;
            this.lblQQ.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQQ.ForeColor = System.Drawing.Color.White;
            this.lblQQ.Location = new System.Drawing.Point(62, 21);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(40, 27);
            this.lblQQ.TabIndex = 19;
            this.lblQQ.Text = "QQ";
            // 
            // picDown
            // 
            this.picDown.BackColor = System.Drawing.Color.Transparent;
            this.picDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDown.BackgroundImage")));
            this.picDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDown.Location = new System.Drawing.Point(309, 154);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(29, 22);
            this.picDown.TabIndex = 20;
            this.picDown.TabStop = false;
            // 
            // picKeyborad
            // 
            this.picKeyborad.BackColor = System.Drawing.Color.Transparent;
            this.picKeyborad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picKeyborad.BackgroundImage")));
            this.picKeyborad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picKeyborad.Location = new System.Drawing.Point(309, 196);
            this.picKeyborad.Name = "picKeyborad";
            this.picKeyborad.Size = new System.Drawing.Size(29, 22);
            this.picKeyborad.TabIndex = 21;
            this.picKeyborad.TabStop = false;
            // 
            // pictureBoxPlus
            // 
            this.pictureBoxPlus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlus.BackgroundImage")));
            this.pictureBoxPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlus.Location = new System.Drawing.Point(188, 91);
            this.pictureBoxPlus.Name = "pictureBoxPlus";
            this.pictureBoxPlus.Size = new System.Drawing.Size(51, 44);
            this.pictureBoxPlus.TabIndex = 22;
            this.pictureBoxPlus.TabStop = false;
            // 
            // timerMove
            // 
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 331);
            this.Controls.Add(this.picKeyborad);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.lblQQ);
            this.Controls.Add(this.picQQ);
            this.Controls.Add(this.picQRcode);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.pictureBoxKey);
            this.Controls.Add(this.pictureBoxAccount);
            this.Controls.Add(this.pictureBoxHead);
            this.Controls.Add(this.lblFindPassword);
            this.Controls.Add(this.checkBoxRemeber);
            this.Controls.Add(this.checkBoxLogin);
            this.Controls.Add(this.panelDownLine);
            this.Controls.Add(this.panelUpLine);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.pictureBoxPlus);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "QQ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyborad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Panel panelUpLine;
        private System.Windows.Forms.Panel panelDownLine;
        private System.Windows.Forms.PictureBox pictureBoxHead;
        private System.Windows.Forms.CheckBox checkBoxLogin;
        private System.Windows.Forms.CheckBox checkBoxRemeber;
        private System.Windows.Forms.Label lblFindPassword;
        private System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.PictureBox pictureBoxKey;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox picQRcode;
        private System.Windows.Forms.PictureBox picQQ;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picKeyborad;
        private System.Windows.Forms.PictureBox pictureBoxPlus;
        private System.Windows.Forms.Timer timerMove;
    }
}

