namespace MyFirstCSharp
{
    partial class Chgap19_Foreach_Test_T
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(26, 166);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(373, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "2차원 배열 Foreach 로 표현하기";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(26, 230);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(373, 218);
            this.txtMatrix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 126);
            this.label2.TabIndex = 3;
            this.label2.Text = "1    2    3    4\r\n5    6    7    8\r\n9   10  11  12\r\n\r\n위 3*4 배열을 만들고\r\nForeach 기능을 " +
    "이용하여 데이터 추출 후\r\n텍스트 박스에 같은 배치로 표현하세요.\r\n";
            // 
            // Chgap19_Foreach_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Name = "Chgap19_Foreach_Test_T";
            this.Text = "배열 표현하기 Foreach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label label2;
    }
}