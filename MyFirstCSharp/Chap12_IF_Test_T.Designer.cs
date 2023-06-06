namespace MyFirstCSharp
{
    partial class Chap12_IF_Test_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF_Test_T));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.btnJudge = new System.Windows.Forms.Button();
            this.txtEMultiValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBtnClickCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력 받을값";
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(267, 35);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(223, 28);
            this.txtInputValue.TabIndex = 1;
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(496, 30);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(276, 35);
            this.btnJudge.TabIndex = 2;
            this.btnJudge.Text = "2 , 5 의 공배수 인지 판단";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // txtEMultiValue
            // 
            this.txtEMultiValue.Location = new System.Drawing.Point(267, 82);
            this.txtEMultiValue.Name = "txtEMultiValue";
            this.txtEMultiValue.Size = new System.Drawing.Size(223, 28);
            this.txtEMultiValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "8의 배수 일 경우 값과의 곱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // txtBtnClickCount
            // 
            this.txtBtnClickCount.Location = new System.Drawing.Point(267, 129);
            this.txtBtnClickCount.Name = "txtBtnClickCount";
            this.txtBtnClickCount.Size = new System.Drawing.Size(223, 28);
            this.txtBtnClickCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(629, 216);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Chap12_IF_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBtnClickCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEMultiValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.txtInputValue);
            this.Controls.Add(this.label1);
            this.Name = "Chap12_IF_Test_T";
            this.Text = "분기문 IF 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.TextBox txtEMultiValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBtnClickCount;
        private System.Windows.Forms.Label label4;
    }
}