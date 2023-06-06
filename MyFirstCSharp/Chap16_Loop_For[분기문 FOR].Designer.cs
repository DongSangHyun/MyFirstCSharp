namespace MyFirstCSharp
{
    partial class Chap16_Loop_For
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
            this.btnforsum = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.txtGuGu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImmuatable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnforsum
            // 
            this.btnforsum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnforsum.Location = new System.Drawing.Point(0, 0);
            this.btnforsum.Name = "btnforsum";
            this.btnforsum.Size = new System.Drawing.Size(687, 82);
            this.btnforsum.TabIndex = 0;
            this.btnforsum.Text = "1 부터 100 까지 더하기";
            this.btnforsum.UseVisualStyleBackColor = true;
            this.btnforsum.Click += new System.EventHandler(this.btnforsum_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArraySum.Location = new System.Drawing.Point(0, 82);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(687, 67);
            this.btnArraySum.TabIndex = 1;
            this.btnArraySum.Text = "배열 값 더하기";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // txtGuGu
            // 
            this.txtGuGu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGuGu.Location = new System.Drawing.Point(0, 149);
            this.txtGuGu.Multiline = true;
            this.txtGuGu.Name = "txtGuGu";
            this.txtGuGu.Size = new System.Drawing.Size(687, 232);
            this.txtGuGu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(687, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "구구단 표현하기 2 ~ 9 ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImmuatable
            // 
            this.btnImmuatable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImmuatable.Location = new System.Drawing.Point(0, 442);
            this.btnImmuatable.Name = "btnImmuatable";
            this.btnImmuatable.Size = new System.Drawing.Size(687, 61);
            this.btnImmuatable.TabIndex = 4;
            this.btnImmuatable.Text = "Immutable";
            this.btnImmuatable.UseVisualStyleBackColor = true;
            this.btnImmuatable.Click += new System.EventHandler(this.btnImmuatable_Click);
            // 
            // Chap16_Loop_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 588);
            this.Controls.Add(this.btnImmuatable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGuGu);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnforsum);
            this.Name = "Chap16_Loop_For";
            this.Text = "반복문 FOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnforsum;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.TextBox txtGuGu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImmuatable;
    }
}