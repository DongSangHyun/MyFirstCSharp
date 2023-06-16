namespace MyFirstCSharp
{
    partial class Chap36_abstract_Polymorphism
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
            this.btnAbstract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(31, 40);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(237, 79);
            this.btnAbstract.TabIndex = 0;
            this.btnAbstract.Text = "추상화(abstract)";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // Chap36_abstract_Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbstract);
            this.Name = "Chap36_abstract_Polymorphism";
            this.Text = "추상화와 다형성";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbstract;
    }
}