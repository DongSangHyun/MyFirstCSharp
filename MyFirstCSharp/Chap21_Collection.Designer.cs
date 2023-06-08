namespace MyFirstCSharp
{
    partial class Chap21_Collection
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnListII = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(26, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(195, 102);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnListII
            // 
            this.btnListII.Location = new System.Drawing.Point(227, 12);
            this.btnListII.Name = "btnListII";
            this.btnListII.Size = new System.Drawing.Size(195, 102);
            this.btnListII.TabIndex = 1;
            this.btnListII.Text = "ListII";
            this.btnListII.UseVisualStyleBackColor = true;
            this.btnListII.Click += new System.EventHandler(this.btnListII_Click);
            // 
            // Chap21_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 519);
            this.Controls.Add(this.btnListII);
            this.Controls.Add(this.btnList);
            this.Name = "Chap21_Collection";
            this.Text = "Chap21_Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnListII;
    }
}