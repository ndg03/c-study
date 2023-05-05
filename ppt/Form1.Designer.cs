namespace ppt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPentagon = new System.Windows.Forms.RadioButton();
            this.rbtArrow = new System.Windows.Forms.RadioButton();
            this.rbtTriangle = new System.Windows.Forms.RadioButton();
            this.rbtEllipse = new System.Windows.Forms.RadioButton();
            this.rbtnFreeline = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.rbtIsoscelesTriangle = new System.Windows.Forms.RadioButton();
            this.rbtRightTriangle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRightTriangle);
            this.groupBox1.Controls.Add(this.rbtIsoscelesTriangle);
            this.groupBox1.Controls.Add(this.rbtPentagon);
            this.groupBox1.Controls.Add(this.rbtArrow);
            this.groupBox1.Controls.Add(this.rbtTriangle);
            this.groupBox1.Controls.Add(this.rbtEllipse);
            this.groupBox1.Controls.Add(this.rbtnFreeline);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图形选择";
            // 
            // rbtPentagon
            // 
            this.rbtPentagon.AutoSize = true;
            this.rbtPentagon.Location = new System.Drawing.Point(22, 201);
            this.rbtPentagon.Name = "rbtPentagon";
            this.rbtPentagon.Size = new System.Drawing.Size(59, 16);
            this.rbtPentagon.TabIndex = 5;
            this.rbtPentagon.TabStop = true;
            this.rbtPentagon.Text = "五边形";
            this.rbtPentagon.UseVisualStyleBackColor = true;
            // 
            // rbtArrow
            // 
            this.rbtArrow.AutoSize = true;
            this.rbtArrow.Location = new System.Drawing.Point(22, 168);
            this.rbtArrow.Name = "rbtArrow";
            this.rbtArrow.Size = new System.Drawing.Size(47, 16);
            this.rbtArrow.TabIndex = 4;
            this.rbtArrow.TabStop = true;
            this.rbtArrow.Text = "箭头";
            this.rbtArrow.UseVisualStyleBackColor = true;
            // 
            // rbtTriangle
            // 
            this.rbtTriangle.AutoSize = true;
            this.rbtTriangle.Location = new System.Drawing.Point(22, 138);
            this.rbtTriangle.Name = "rbtTriangle";
            this.rbtTriangle.Size = new System.Drawing.Size(59, 16);
            this.rbtTriangle.TabIndex = 3;
            this.rbtTriangle.TabStop = true;
            this.rbtTriangle.Text = "三角形";
            this.rbtTriangle.UseVisualStyleBackColor = true;
            // 
            // rbtEllipse
            // 
            this.rbtEllipse.AutoSize = true;
            this.rbtEllipse.Location = new System.Drawing.Point(22, 102);
            this.rbtEllipse.Name = "rbtEllipse";
            this.rbtEllipse.Size = new System.Drawing.Size(47, 16);
            this.rbtEllipse.TabIndex = 2;
            this.rbtEllipse.TabStop = true;
            this.rbtEllipse.Text = "椭圆";
            this.rbtEllipse.UseVisualStyleBackColor = true;
            // 
            // rbtnFreeline
            // 
            this.rbtnFreeline.AutoSize = true;
            this.rbtnFreeline.Location = new System.Drawing.Point(22, 69);
            this.rbtnFreeline.Name = "rbtnFreeline";
            this.rbtnFreeline.Size = new System.Drawing.Size(47, 16);
            this.rbtnFreeline.TabIndex = 1;
            this.rbtnFreeline.TabStop = true;
            this.rbtnFreeline.Text = "涂鸦";
            this.rbtnFreeline.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnRectangle.Location = new System.Drawing.Point(22, 36);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(47, 16);
            this.rbtnRectangle.TabIndex = 0;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "矩形";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(2, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "撤销";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(2, 342);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(92, 23);
            this.btnRetry.TabIndex = 2;
            this.btnRetry.Text = "重做";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // rbtIsoscelesTriangle
            // 
            this.rbtIsoscelesTriangle.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.rbtIsoscelesTriangle.AutoSize = true;
            this.rbtIsoscelesTriangle.Location = new System.Drawing.Point(22, 234);
            this.rbtIsoscelesTriangle.Name = "rbtIsoscelesTriangle";
            this.rbtIsoscelesTriangle.Size = new System.Drawing.Size(83, 16);
            this.rbtIsoscelesTriangle.TabIndex = 6;
            this.rbtIsoscelesTriangle.TabStop = true;
            this.rbtIsoscelesTriangle.Text = "等腰三角形";
            this.rbtIsoscelesTriangle.UseVisualStyleBackColor = true;
            // 
            // rbtRightTriangle
            // 
            this.rbtRightTriangle.AutoSize = true;
            this.rbtRightTriangle.Location = new System.Drawing.Point(22, 256);
            this.rbtRightTriangle.Name = "rbtRightTriangle";
            this.rbtRightTriangle.Size = new System.Drawing.Size(83, 16);
            this.rbtRightTriangle.TabIndex = 7;
            this.rbtRightTriangle.TabStop = true;
            this.rbtRightTriangle.Text = "直角三角形";
            this.rbtRightTriangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(511, 377);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFreeline;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.RadioButton rbtEllipse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.RadioButton rbtTriangle;
        private System.Windows.Forms.RadioButton rbtArrow;
        private System.Windows.Forms.RadioButton rbtPentagon;
        private System.Windows.Forms.RadioButton rbtRightTriangle;
        private System.Windows.Forms.RadioButton rbtIsoscelesTriangle;
    }
}

