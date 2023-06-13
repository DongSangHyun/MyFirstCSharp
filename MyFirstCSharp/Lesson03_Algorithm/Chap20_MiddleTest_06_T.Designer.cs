namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_06_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap20_MiddleTest_06_T));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1119, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "N 번 이용하면 원래 이용료의 N 배를 받는 놀이기구가있다고 할때\r\n가진 금액, 놀이기구 반복횟수, 놀이기구 최초 가격 을 랜덤난수로 함수에 전달" +
    "하고\r\n\" AA 원이 있을때 이용요금 BB 인 놀이기구를 CC 번 타면 DD 원이 (모자랍니다. 또는 남습니다.) \" 를 메세지로 표현하세요";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(851, 183);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(241, 175);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "부족 금액 계산";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Chap20_MiddleTest_06_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 424);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chap20_MiddleTest_06_T";
            this.Text = "부족 금액 계산하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResult;
    }
}