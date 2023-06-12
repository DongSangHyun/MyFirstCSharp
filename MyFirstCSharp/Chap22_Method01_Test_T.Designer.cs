namespace MyFirstCSharp
{
    partial class Chap22_Method01_Test_T
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTwo_M = new System.Windows.Forms.Button();
            this.btnFiv_M = new System.Windows.Forms.Button();
            this.btnTen_M = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1013, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "반복문을 (For, While) 한번만 코딩하여 (소스내에서 반복문이 한번만 보이도록)\r\n범위 안의 수 중 2 , 5,  10 의 배수의 합을 각" +
    " 버튼 클릭하여 메세지박스로 표현하세요\r\n   * 텍스트 박스의 문자는 숫자만 입력 \r\n    * 음수는 입력 받을수 없다. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력 받을 범위";
            // 
            // btnTwo_M
            // 
            this.btnTwo_M.Location = new System.Drawing.Point(132, 234);
            this.btnTwo_M.Name = "btnTwo_M";
            this.btnTwo_M.Size = new System.Drawing.Size(198, 70);
            this.btnTwo_M.TabIndex = 2;
            this.btnTwo_M.Text = "2의 배수 표현";
            this.btnTwo_M.UseVisualStyleBackColor = true;
            this.btnTwo_M.Click += new System.EventHandler(this.btnTwo_M_Click);
            // 
            // btnFiv_M
            // 
            this.btnFiv_M.Location = new System.Drawing.Point(336, 234);
            this.btnFiv_M.Name = "btnFiv_M";
            this.btnFiv_M.Size = new System.Drawing.Size(198, 70);
            this.btnFiv_M.TabIndex = 3;
            this.btnFiv_M.Text = "5의 배수 표현";
            this.btnFiv_M.UseVisualStyleBackColor = true;
            this.btnFiv_M.Click += new System.EventHandler(this.btnFiv_M_Click);
            // 
            // btnTen_M
            // 
            this.btnTen_M.Location = new System.Drawing.Point(540, 234);
            this.btnTen_M.Name = "btnTen_M";
            this.btnTen_M.Size = new System.Drawing.Size(198, 70);
            this.btnTen_M.TabIndex = 4;
            this.btnTen_M.Text = "10 의 배수 표현";
            this.btnTen_M.UseVisualStyleBackColor = true;
            this.btnTen_M.Click += new System.EventHandler(this.btnTen_M_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(249, 186);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(161, 28);
            this.txtStart.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(444, 186);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(161, 28);
            this.txtEnd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "~";
            // 
            // Chap22_Method01_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnTen_M);
            this.Controls.Add(this.btnFiv_M);
            this.Controls.Add(this.btnTwo_M);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap22_Method01_Test_T";
            this.Text = "메서드 응용하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTwo_M;
        private System.Windows.Forms.Button btnFiv_M;
        private System.Windows.Forms.Button btnTen_M;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label3;
    }
}