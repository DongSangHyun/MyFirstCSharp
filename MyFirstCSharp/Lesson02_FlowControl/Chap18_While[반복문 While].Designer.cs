namespace MyFirstCSharp
{
    partial class Chap18_While
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnWhileNoExit = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(31, 52);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(179, 87);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnWhileNoExit
            // 
            this.btnWhileNoExit.Location = new System.Drawing.Point(237, 52);
            this.btnWhileNoExit.Name = "btnWhileNoExit";
            this.btnWhileNoExit.Size = new System.Drawing.Size(191, 86);
            this.btnWhileNoExit.TabIndex = 1;
            this.btnWhileNoExit.Text = "무한 루프";
            this.btnWhileNoExit.UseVisualStyleBackColor = true;
            this.btnWhileNoExit.Click += new System.EventHandler(this.btnWhileNoExit_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(457, 47);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(183, 91);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // Chap18_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 193);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhileNoExit);
            this.Controls.Add(this.btnWhile);
            this.Name = "Chap18_While";
            this.Text = "반복문 While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnWhileNoExit;
        private System.Windows.Forms.Button btnDoWhile;
    }
}