namespace MyFirstCSharp
{
    partial class Chap31_ClassTest_Run
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
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(35, 45);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(250, 134);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "가동 등록";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // Chap31_ClassTest_Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 231);
            this.Controls.Add(this.btnRun);
            this.Name = "Chap31_ClassTest_Run";
            this.Text = "가동 등록 하기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
    }
}