namespace MyFirstCSharp
{
    partial class Chap31_ClassTest_Stop
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
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(62, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(267, 155);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "비가동 등록";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Chap31_ClassTest_Stop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 199);
            this.Controls.Add(this.btnStop);
            this.Name = "Chap31_ClassTest_Stop";
            this.Text = "설비 비가동 등록";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
    }
}