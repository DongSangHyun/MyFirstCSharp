namespace MyFirstCSharp
{
    partial class Chap25_RecursiveFunction_T
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOutValue = new System.Windows.Forms.Button();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.btnMemoization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(902, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력한 숫자 의 피보나치 수열의 값을 구하는 로직을 구현하세요.\r\n\r\n*피보나치 수열 : 0 과 1 로 시작 하는 n 번째 피보나치 수는 바로 직" +
    "전 두 수 의 합을 나타내는 수열\r\n\r\n0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 .....";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(59, 219);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(126, 28);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "번째 피보나치 수열 값";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(498, 177);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(329, 43);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List 를 사용하여 확인하기";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnOutValue
            // 
            this.btnOutValue.Location = new System.Drawing.Point(498, 226);
            this.btnOutValue.Name = "btnOutValue";
            this.btnOutValue.Size = new System.Drawing.Size(329, 43);
            this.btnOutValue.TabIndex = 4;
            this.btnOutValue.Text = "외부 변수를 이용하여 확인하기";
            this.btnOutValue.UseVisualStyleBackColor = true;
            this.btnOutValue.Click += new System.EventHandler(this.btnOutValue_Click);
            // 
            // btnRecursive
            // 
            this.btnRecursive.Location = new System.Drawing.Point(498, 275);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(329, 37);
            this.btnRecursive.TabIndex = 5;
            this.btnRecursive.Text = "재귀 함수 를 통하여 구하기";
            this.btnRecursive.UseVisualStyleBackColor = true;
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // btnMemoization
            // 
            this.btnMemoization.Location = new System.Drawing.Point(498, 318);
            this.btnMemoization.Name = "btnMemoization";
            this.btnMemoization.Size = new System.Drawing.Size(329, 37);
            this.btnMemoization.TabIndex = 6;
            this.btnMemoization.Text = "메모화 기법을 통한 재귀호출 보완하기";
            this.btnMemoization.UseVisualStyleBackColor = true;
            this.btnMemoization.Click += new System.EventHandler(this.btnMemoization_Click);
            // 
            // Chap25_RecursiveFunction_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 434);
            this.Controls.Add(this.btnMemoization);
            this.Controls.Add(this.btnRecursive);
            this.Controls.Add(this.btnOutValue);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Chap25_RecursiveFunction_T";
            this.Text = "피보나치 수열";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOutValue;
        private System.Windows.Forms.Button btnRecursive;
        private System.Windows.Forms.Button btnMemoization;
    }
}