namespace MyFirstCSharp
{
    partial class Chap26_2sComplement
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
            this.btnInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(86, 30);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(185, 67);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "int 값 확인";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // Chap26_2sComplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 132);
            this.Controls.Add(this.btnInt);
            this.Name = "Chap26_2sComplement";
            this.Text = "2의 보수법 알아보기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
    }
}