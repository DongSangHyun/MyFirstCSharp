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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(296, 12);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(170, 79);
            this.btnAbstract.TabIndex = 0;
            this.btnAbstract.Text = "추상화(abstract)";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnItemSearch);
            this.groupBox1.Controls.Add(this.btnCustSearch);
            this.groupBox1.Controls.Add(this.btnUserSearch);
            this.groupBox1.Location = new System.Drawing.Point(82, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Location = new System.Drawing.Point(395, 17);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(173, 79);
            this.btnItemSearch.TabIndex = 2;
            this.btnItemSearch.Tag = "ItemMaster";
            this.btnItemSearch.Text = "품목 정보 조회";
            this.btnItemSearch.UseVisualStyleBackColor = true;
            this.btnItemSearch.Click += new System.EventHandler(this.MenuSearch);
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Location = new System.Drawing.Point(200, 17);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(173, 79);
            this.btnCustSearch.TabIndex = 1;
            this.btnCustSearch.Tag = "CustMaster";
            this.btnCustSearch.Text = "고객 정보 조회";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            this.btnCustSearch.Click += new System.EventHandler(this.MenuSearch);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(6, 19);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(173, 79);
            this.btnUserSearch.TabIndex = 0;
            this.btnUserSearch.Tag = "UserMaster";
            this.btnUserSearch.Text = "사용자 정보 조회";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.MenuSearch);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 79);
            this.button1.TabIndex = 3;
            this.button1.Tag = "CustMaster2";
            this.button1.Text = "고객 정보 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MenuSearch);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 79);
            this.button2.TabIndex = 4;
            this.button2.Tag = "CustMaster3";
            this.button2.Text = "고객 정보 조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MenuSearch);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 79);
            this.button3.TabIndex = 5;
            this.button3.Tag = "CustMaster4";
            this.button3.Text = "고객 정보 조회";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MenuSearch);
            // 
            // Chap36_abstract_Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbstract);
            this.Name = "Chap36_abstract_Polymorphism";
            this.Text = "추상화와 다형성";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbstract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}