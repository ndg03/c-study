namespace qqTest
{
    partial class main_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_1));
            this.lbl_search = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_connectperson = new System.Windows.Forms.Button();
            this.bt_message = new System.Windows.Forms.Button();
            this.bt_space = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_search.Location = new System.Drawing.Point(12, 139);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(73, 30);
            this.lbl_search.TabIndex = 3;
            this.lbl_search.Text = "搜索";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_search.Location = new System.Drawing.Point(91, 139);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(640, 30);
            this.tb_search.TabIndex = 4;
            // 
            // bt_connectperson
            // 
            this.bt_connectperson.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_connectperson.Location = new System.Drawing.Point(33, 175);
            this.bt_connectperson.Name = "bt_connectperson";
            this.bt_connectperson.Size = new System.Drawing.Size(145, 46);
            this.bt_connectperson.TabIndex = 5;
            this.bt_connectperson.Text = "联系人";
            this.bt_connectperson.UseVisualStyleBackColor = true;
            // 
            // bt_message
            // 
            this.bt_message.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_message.Location = new System.Drawing.Point(318, 174);
            this.bt_message.Name = "bt_message";
            this.bt_message.Size = new System.Drawing.Size(107, 49);
            this.bt_message.TabIndex = 6;
            this.bt_message.Text = "消息";
            this.bt_message.UseVisualStyleBackColor = true;
            // 
            // bt_space
            // 
            this.bt_space.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_space.Location = new System.Drawing.Point(556, 172);
            this.bt_space.Name = "bt_space";
            this.bt_space.Size = new System.Drawing.Size(114, 52);
            this.bt_space.TabIndex = 7;
            this.bt_space.Text = "空间";
            this.bt_space.UseVisualStyleBackColor = true;
            // 
            // main_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 60F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 735);
            this.Controls.Add(this.bt_space);
            this.Controls.Add(this.bt_message);
            this.Controls.Add(this.bt_connectperson);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lbl_search);
            this.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "main_1";
            this.Text = "QQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_connectperson;
        private System.Windows.Forms.Button bt_message;
        private System.Windows.Forms.Button bt_space;
    }
}