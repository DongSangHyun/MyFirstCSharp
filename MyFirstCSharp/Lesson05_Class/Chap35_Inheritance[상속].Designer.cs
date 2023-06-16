namespace MyFirstCSharp.Lesson05_Class
{
    partial class Chap35_Inheritance
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
            this.btnInheritance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInheritance
            // 
            this.btnInheritance.Location = new System.Drawing.Point(51, 40);
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(212, 93);
            this.btnInheritance.TabIndex = 0;
            this.btnInheritance.Text = "상속";
            this.btnInheritance.UseVisualStyleBackColor = true;
            this.btnInheritance.Click += new System.EventHandler(this.btnInheritance_Click);
            // 
            // Chap35_Inheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 187);
            this.Controls.Add(this.btnInheritance);
            this.Name = "Chap35_Inheritance";
            this.Text = "상속";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInheritance;
    }
}