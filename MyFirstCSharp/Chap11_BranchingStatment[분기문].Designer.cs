namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatment
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
            this.btnIF = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btnInIf = new System.Windows.Forms.Button();
            this.btnElseIf = new System.Windows.Forms.Button();
            this.btnAndIf = new System.Windows.Forms.Button();
            this.btnORIf = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnDO = new System.Windows.Forms.Button();
            this.btnTernaryOperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 56);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(131, 61);
            this.btnIF.TabIndex = 0;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(12, 22);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(131, 28);
            this.txtBS.TabIndex = 1;
            this.txtBS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInIf
            // 
            this.btnInIf.Location = new System.Drawing.Point(149, 56);
            this.btnInIf.Name = "btnInIf";
            this.btnInIf.Size = new System.Drawing.Size(131, 61);
            this.btnInIf.TabIndex = 2;
            this.btnInIf.Text = "In IF";
            this.btnInIf.UseVisualStyleBackColor = true;
            this.btnInIf.Click += new System.EventHandler(this.btnInIf_Click);
            // 
            // btnElseIf
            // 
            this.btnElseIf.Location = new System.Drawing.Point(286, 56);
            this.btnElseIf.Name = "btnElseIf";
            this.btnElseIf.Size = new System.Drawing.Size(131, 61);
            this.btnElseIf.TabIndex = 3;
            this.btnElseIf.Text = "else IF";
            this.btnElseIf.UseVisualStyleBackColor = true;
            this.btnElseIf.Click += new System.EventHandler(this.btnElseIf_Click);
            // 
            // btnAndIf
            // 
            this.btnAndIf.Location = new System.Drawing.Point(12, 123);
            this.btnAndIf.Name = "btnAndIf";
            this.btnAndIf.Size = new System.Drawing.Size(131, 61);
            this.btnAndIf.TabIndex = 4;
            this.btnAndIf.Text = "And If";
            this.btnAndIf.UseVisualStyleBackColor = true;
            this.btnAndIf.Click += new System.EventHandler(this.btnAndIf_Click);
            // 
            // btnORIf
            // 
            this.btnORIf.Location = new System.Drawing.Point(149, 123);
            this.btnORIf.Name = "btnORIf";
            this.btnORIf.Size = new System.Drawing.Size(131, 61);
            this.btnORIf.TabIndex = 5;
            this.btnORIf.Text = "OR IF";
            this.btnORIf.UseVisualStyleBackColor = true;
            this.btnORIf.Click += new System.EventHandler(this.btnORIf_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(286, 123);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(131, 61);
            this.btnBoolIf.TabIndex = 6;
            this.btnBoolIf.Text = "Bool IF";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(12, 190);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(131, 58);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnDO
            // 
            this.btnDO.Location = new System.Drawing.Point(149, 190);
            this.btnDO.Name = "btnDO";
            this.btnDO.Size = new System.Drawing.Size(131, 58);
            this.btnDO.TabIndex = 8;
            this.btnDO.Text = "홀수/짝수판단";
            this.btnDO.UseVisualStyleBackColor = true;
            this.btnDO.Click += new System.EventHandler(this.btnDO_Click);
            // 
            // btnTernaryOperator
            // 
            this.btnTernaryOperator.Location = new System.Drawing.Point(286, 190);
            this.btnTernaryOperator.Name = "btnTernaryOperator";
            this.btnTernaryOperator.Size = new System.Drawing.Size(131, 58);
            this.btnTernaryOperator.TabIndex = 9;
            this.btnTernaryOperator.Text = "삼항 연산자";
            this.btnTernaryOperator.UseVisualStyleBackColor = true;
            this.btnTernaryOperator.Click += new System.EventHandler(this.btnTernaryOperator_Click);
            // 
            // Chap11_BranchingStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 274);
            this.Controls.Add(this.btnTernaryOperator);
            this.Controls.Add(this.btnDO);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnORIf);
            this.Controls.Add(this.btnAndIf);
            this.Controls.Add(this.btnElseIf);
            this.Controls.Add(this.btnInIf);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnIF);
            this.Name = "Chap11_BranchingStatment";
            this.Text = "분기문 학습하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btnInIf;
        private System.Windows.Forms.Button btnElseIf;
        private System.Windows.Forms.Button btnAndIf;
        private System.Windows.Forms.Button btnORIf;
        private System.Windows.Forms.Button btnBoolIf;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnDO;
        private System.Windows.Forms.Button btnTernaryOperator;
    }
}