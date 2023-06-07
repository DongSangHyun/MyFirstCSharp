namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_02_T
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
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 324);
            this.label1.TabIndex = 1;
            this.label1.Text = "다음 2차원 배열에 나열된 정수 중\r\n2개 의 데이터를 추출하여 \r\n합한 값이 20 이 되는 쌍을 모두 구하세요\r\n\r\n{ 1,  4,   5,  " +
    " 9,   10,   12,   16}\r\n{ 2,  7,  11,  13,   14,   15,   18}\r\n\r\n* 중복 되는 데이터 혀용하지 " +
    "않음.\r\n   - (4,12)  , (12,4)";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(37, 363);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(483, 46);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "중복 미허용 합 20 쌍 구하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Chap20_MiddleTest_02_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_02_T";
            this.Text = "2차원 배열 합 쌍 구하기.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
    }
}