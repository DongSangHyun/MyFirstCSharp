namespace MyFirstCSharp
{
    partial class Chap30_Class_F
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
            this.btnCalssCall = new System.Windows.Forms.Button();
            this.btnClass2 = new System.Windows.Forms.Button();
            this.btnFieldsCall = new System.Windows.Forms.Button();
            this.btnFieldsCall2 = new System.Windows.Forms.Button();
            this.btnClassMathodCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalssCall
            // 
            this.btnCalssCall.Location = new System.Drawing.Point(12, 12);
            this.btnCalssCall.Name = "btnCalssCall";
            this.btnCalssCall.Size = new System.Drawing.Size(494, 76);
            this.btnCalssCall.TabIndex = 0;
            this.btnCalssCall.Text = "클래스 객체 생성 및 호출";
            this.btnCalssCall.UseVisualStyleBackColor = true;
            this.btnCalssCall.Click += new System.EventHandler(this.btnCalssCall_Click);
            // 
            // btnClass2
            // 
            this.btnClass2.Location = new System.Drawing.Point(12, 94);
            this.btnClass2.Name = "btnClass2";
            this.btnClass2.Size = new System.Drawing.Size(494, 76);
            this.btnClass2.TabIndex = 1;
            this.btnClass2.Text = "클래스 객체 생성 및 호출2";
            this.btnClass2.UseVisualStyleBackColor = true;
            this.btnClass2.Click += new System.EventHandler(this.btnClass2_Click);
            // 
            // btnFieldsCall
            // 
            this.btnFieldsCall.Location = new System.Drawing.Point(18, 176);
            this.btnFieldsCall.Name = "btnFieldsCall";
            this.btnFieldsCall.Size = new System.Drawing.Size(494, 76);
            this.btnFieldsCall.TabIndex = 2;
            this.btnFieldsCall.Text = "필드 멤버 객체 전역변수 호출1";
            this.btnFieldsCall.UseVisualStyleBackColor = true;
            this.btnFieldsCall.Click += new System.EventHandler(this.btnFieldsCall_Click);
            // 
            // btnFieldsCall2
            // 
            this.btnFieldsCall2.Location = new System.Drawing.Point(12, 258);
            this.btnFieldsCall2.Name = "btnFieldsCall2";
            this.btnFieldsCall2.Size = new System.Drawing.Size(494, 76);
            this.btnFieldsCall2.TabIndex = 3;
            this.btnFieldsCall2.Text = "필드 멤버 객체 전역변수 호출2";
            this.btnFieldsCall2.UseVisualStyleBackColor = true;
            this.btnFieldsCall2.Click += new System.EventHandler(this.btnFieldsCall2_Click);
            // 
            // btnClassMathodCall
            // 
            this.btnClassMathodCall.Location = new System.Drawing.Point(12, 340);
            this.btnClassMathodCall.Name = "btnClassMathodCall";
            this.btnClassMathodCall.Size = new System.Drawing.Size(494, 76);
            this.btnClassMathodCall.TabIndex = 4;
            this.btnClassMathodCall.Text = "다른 클래스의 메서드 호출하기";
            this.btnClassMathodCall.UseVisualStyleBackColor = true;
            this.btnClassMathodCall.Click += new System.EventHandler(this.btnClassMathodCall_Click);
            // 
            // Chap30_Class_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 449);
            this.Controls.Add(this.btnClassMathodCall);
            this.Controls.Add(this.btnFieldsCall2);
            this.Controls.Add(this.btnFieldsCall);
            this.Controls.Add(this.btnClass2);
            this.Controls.Add(this.btnCalssCall);
            this.Name = "Chap30_Class_F";
            this.Text = "클래스";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalssCall;
        private System.Windows.Forms.Button btnClass2;
        private System.Windows.Forms.Button btnFieldsCall;
        private System.Windows.Forms.Button btnFieldsCall2;
        private System.Windows.Forms.Button btnClassMathodCall;
    }
}