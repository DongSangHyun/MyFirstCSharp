namespace MyFirstCSharp
{
    partial class Chap22_Method
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
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.btnPaAr = new System.Windows.Forms.Button();
            this.btnVoidReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnIntReturn = new System.Windows.Forms.Button();
            this.btnDefaultParameter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnArrayArgument = new System.Windows.Forms.Button();
            this.btnArrayReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(12, 70);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(148, 66);
            this.btnMethodCall.TabIndex = 0;
            this.btnMethodCall.Text = "메서드 호출";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // btnPaAr
            // 
            this.btnPaAr.Location = new System.Drawing.Point(166, 70);
            this.btnPaAr.Name = "btnPaAr";
            this.btnPaAr.Size = new System.Drawing.Size(145, 66);
            this.btnPaAr.TabIndex = 1;
            this.btnPaAr.Text = "인수 인자";
            this.btnPaAr.UseVisualStyleBackColor = true;
            this.btnPaAr.Click += new System.EventHandler(this.btnPaAr_Click);
            // 
            // btnVoidReturn
            // 
            this.btnVoidReturn.Location = new System.Drawing.Point(12, 157);
            this.btnVoidReturn.Name = "btnVoidReturn";
            this.btnVoidReturn.Size = new System.Drawing.Size(148, 66);
            this.btnVoidReturn.TabIndex = 2;
            this.btnVoidReturn.Text = "Void Return";
            this.btnVoidReturn.UseVisualStyleBackColor = true;
            this.btnVoidReturn.Click += new System.EventHandler(this.btnVoidReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 18);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(98, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(205, 28);
            this.txtTitle.TabIndex = 4;
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(166, 157);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(148, 66);
            this.btnStringReturn.TabIndex = 5;
            this.btnStringReturn.Text = "String return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnIntReturn
            // 
            this.btnIntReturn.Location = new System.Drawing.Point(320, 157);
            this.btnIntReturn.Name = "btnIntReturn";
            this.btnIntReturn.Size = new System.Drawing.Size(165, 66);
            this.btnIntReturn.TabIndex = 6;
            this.btnIntReturn.Text = "int Return";
            this.btnIntReturn.UseVisualStyleBackColor = true;
            this.btnIntReturn.Click += new System.EventHandler(this.btnIntReturn_Click);
            // 
            // btnDefaultParameter
            // 
            this.btnDefaultParameter.Location = new System.Drawing.Point(491, 157);
            this.btnDefaultParameter.Name = "btnDefaultParameter";
            this.btnDefaultParameter.Size = new System.Drawing.Size(165, 66);
            this.btnDefaultParameter.TabIndex = 7;
            this.btnDefaultParameter.Text = "Default Parameter";
            this.btnDefaultParameter.UseVisualStyleBackColor = true;
            this.btnDefaultParameter.Click += new System.EventHandler(this.btnDefaultParameter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클래스를 인수 로 전달 하는 경우";
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(310, 37);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(181, 57);
            this.btnCatch2.TabIndex = 1;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(44, 37);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(196, 58);
            this.btnCatch1.TabIndex = 0;
            this.btnCatch1.Text = "나잡아 봐라~";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnArrayArgument
            // 
            this.btnArrayArgument.Location = new System.Drawing.Point(12, 384);
            this.btnArrayArgument.Name = "btnArrayArgument";
            this.btnArrayArgument.Size = new System.Drawing.Size(189, 68);
            this.btnArrayArgument.TabIndex = 9;
            this.btnArrayArgument.Text = "Array Argument";
            this.btnArrayArgument.UseVisualStyleBackColor = true;
            this.btnArrayArgument.Click += new System.EventHandler(this.btnArrayArgument_Click);
            // 
            // btnArrayReturn
            // 
            this.btnArrayReturn.Location = new System.Drawing.Point(216, 384);
            this.btnArrayReturn.Name = "btnArrayReturn";
            this.btnArrayReturn.Size = new System.Drawing.Size(189, 68);
            this.btnArrayReturn.TabIndex = 10;
            this.btnArrayReturn.Text = "ArrayReturn";
            this.btnArrayReturn.UseVisualStyleBackColor = true;
            this.btnArrayReturn.Click += new System.EventHandler(this.btnArrayReturn_Click);
            // 
            // Chap22_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 507);
            this.Controls.Add(this.btnArrayReturn);
            this.Controls.Add(this.btnArrayArgument);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDefaultParameter);
            this.Controls.Add(this.btnIntReturn);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnVoidReturn);
            this.Controls.Add(this.btnPaAr);
            this.Controls.Add(this.btnMethodCall);
            this.Name = "Chap22_Method";
            this.Text = "메서드";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethodCall;
        private System.Windows.Forms.Button btnPaAr;
        private System.Windows.Forms.Button btnVoidReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnStringReturn;
        private System.Windows.Forms.Button btnIntReturn;
        private System.Windows.Forms.Button btnDefaultParameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCatch1;
        private System.Windows.Forms.Button btnCatch2;
        private System.Windows.Forms.Button btnArrayArgument;
        private System.Windows.Forms.Button btnArrayReturn;
    }
}