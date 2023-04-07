namespace Generatingtopic
{
    partial class Form1
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
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_char = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_equal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_setquestion = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.listbox_show = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_left.Location = new System.Drawing.Point(24, 49);
            this.lbl_left.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(31, 33);
            this.lbl_left.TabIndex = 0;
            this.lbl_left.Text = "1";
            // 
            // lbl_char
            // 
            this.lbl_char.AutoSize = true;
            this.lbl_char.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_char.Location = new System.Drawing.Point(67, 49);
            this.lbl_char.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_char.Name = "lbl_char";
            this.lbl_char.Size = new System.Drawing.Size(31, 33);
            this.lbl_char.TabIndex = 1;
            this.lbl_char.Text = "+";
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_right.Location = new System.Drawing.Point(116, 49);
            this.lbl_right.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(31, 33);
            this.lbl_right.TabIndex = 2;
            this.lbl_right.Text = "1";
            // 
            // lbl_equal
            // 
            this.lbl_equal.AutoSize = true;
            this.lbl_equal.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_equal.Location = new System.Drawing.Point(169, 49);
            this.lbl_equal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_equal.Name = "lbl_equal";
            this.lbl_equal.Size = new System.Drawing.Size(31, 33);
            this.lbl_equal.TabIndex = 3;
            this.lbl_equal.Text = "=";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(213, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 44);
            this.textBox1.TabIndex = 4;
            // 
            // but_setquestion
            // 
            this.but_setquestion.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_setquestion.Location = new System.Drawing.Point(29, 151);
            this.but_setquestion.Margin = new System.Windows.Forms.Padding(2);
            this.but_setquestion.Name = "but_setquestion";
            this.but_setquestion.Size = new System.Drawing.Size(107, 42);
            this.but_setquestion.TabIndex = 5;
            this.but_setquestion.Text = "出题";
            this.but_setquestion.UseVisualStyleBackColor = true;
            this.but_setquestion.Click += new System.EventHandler(this.but_setquestion_Click);
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_score.Location = new System.Drawing.Point(174, 151);
            this.btn_score.Margin = new System.Windows.Forms.Padding(2);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(107, 42);
            this.btn_score.TabIndex = 6;
            this.btn_score.Text = "判分";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // listbox_show
            // 
            this.listbox_show.FormattingEnabled = true;
            this.listbox_show.ItemHeight = 12;
            this.listbox_show.Location = new System.Drawing.Point(22, 213);
            this.listbox_show.Margin = new System.Windows.Forms.Padding(2);
            this.listbox_show.Name = "listbox_show";
            this.listbox_show.Size = new System.Drawing.Size(267, 196);
            this.listbox_show.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 443);
            this.Controls.Add(this.listbox_show);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.but_setquestion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_equal);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_char);
            this.Controls.Add(this.lbl_left);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_char;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_equal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_setquestion;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.ListBox listbox_show;
    }
}

