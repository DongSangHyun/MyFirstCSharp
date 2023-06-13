namespace MyFirstCSharp
{
    partial class Chap24_Method02
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
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.btnOverLoding = new System.Windows.Forms.Button();
            this.btnparams = new System.Windows.Forms.Button();
            this.btnGenericMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(12, 12);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(115, 105);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(133, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(117, 105);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(256, 12);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(108, 105);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "in";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(370, 12);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(113, 105);
            this.btnTryParse.TabIndex = 3;
            this.btnTryParse.Text = "TryParse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // btnOverLoding
            // 
            this.btnOverLoding.Location = new System.Drawing.Point(12, 123);
            this.btnOverLoding.Name = "btnOverLoding";
            this.btnOverLoding.Size = new System.Drawing.Size(115, 89);
            this.btnOverLoding.TabIndex = 4;
            this.btnOverLoding.Text = "OverLoding";
            this.btnOverLoding.UseVisualStyleBackColor = true;
            this.btnOverLoding.Click += new System.EventHandler(this.btnOverLoding_Click);
            // 
            // btnparams
            // 
            this.btnparams.Location = new System.Drawing.Point(133, 123);
            this.btnparams.Name = "btnparams";
            this.btnparams.Size = new System.Drawing.Size(117, 89);
            this.btnparams.TabIndex = 5;
            this.btnparams.Text = "params";
            this.btnparams.UseVisualStyleBackColor = true;
            this.btnparams.Click += new System.EventHandler(this.btnparams_Click);
            // 
            // btnGenericMethod
            // 
            this.btnGenericMethod.Location = new System.Drawing.Point(256, 123);
            this.btnGenericMethod.Name = "btnGenericMethod";
            this.btnGenericMethod.Size = new System.Drawing.Size(108, 89);
            this.btnGenericMethod.TabIndex = 6;
            this.btnGenericMethod.Text = "Generic Method";
            this.btnGenericMethod.UseVisualStyleBackColor = true;
            this.btnGenericMethod.Click += new System.EventHandler(this.btnGenericMethod_Click);
            // 
            // Chap24_Method02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 263);
            this.Controls.Add(this.btnGenericMethod);
            this.Controls.Add(this.btnparams);
            this.Controls.Add(this.btnOverLoding);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
            this.Name = "Chap24_Method02";
            this.Text = "메서드";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnTryParse;
        private System.Windows.Forms.Button btnOverLoding;
        private System.Windows.Forms.Button btnparams;
        private System.Windows.Forms.Button btnGenericMethod;
    }
}