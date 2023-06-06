namespace MyFirstCSharp
{
    partial class Chap17_MatrixTest_T
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
            this.btnChang = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 2,4 배열을 만들고\r\n1행과 2행을 바꾸어 새로운 배열에 담아 \r\n배열의 결과를 텍스트 박스에 표현하세요. \r\n\r\n[ 1 , 2,  3," +
    " 4         =>   [ 5, 6, 7, 8\r\n  5 , 6 , 7, 8 ]                 1, 2, 3, 4]";
            // 
            // btnChang
            // 
            this.btnChang.Location = new System.Drawing.Point(35, 214);
            this.btnChang.Name = "btnChang";
            this.btnChang.Size = new System.Drawing.Size(378, 66);
            this.btnChang.TabIndex = 1;
            this.btnChang.Text = "변경 하기";
            this.btnChang.UseVisualStyleBackColor = true;
            this.btnChang.Click += new System.EventHandler(this.btnChang_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(35, 286);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(378, 152);
            this.txtResult.TabIndex = 2;
            // 
            // Chap17_MatrixTest_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnChang);
            this.Controls.Add(this.label1);
            this.Name = "Chap17_MatrixTest_T";
            this.Text = "배열 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChang;
        private System.Windows.Forms.TextBox txtResult;
    }
}