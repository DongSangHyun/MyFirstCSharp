namespace MyFirstCSharp
{
    partial class Chap19_Foreach
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
            this.btnStringForeach = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArrayForeach = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStringForeach
            // 
            this.btnStringForeach.Location = new System.Drawing.Point(30, 51);
            this.btnStringForeach.Name = "btnStringForeach";
            this.btnStringForeach.Size = new System.Drawing.Size(163, 116);
            this.btnStringForeach.TabIndex = 0;
            this.btnStringForeach.Text = "string Foreach";
            this.btnStringForeach.UseVisualStyleBackColor = true;
            this.btnStringForeach.Click += new System.EventHandler(this.btnStringForeach_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(199, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ABCDEFGHIJHLMNOPQRSTUVWXYZ";
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(202, 106);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(84, 28);
            this.txtInputWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. 문자 포함 여부 판단하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. 배열 에서 데이터 추출하기";
            // 
            // btnArrayForeach
            // 
            this.btnArrayForeach.Location = new System.Drawing.Point(531, 51);
            this.btnArrayForeach.Name = "btnArrayForeach";
            this.btnArrayForeach.Size = new System.Drawing.Size(163, 116);
            this.btnArrayForeach.TabIndex = 5;
            this.btnArrayForeach.Text = "Array Foreach";
            this.btnArrayForeach.UseVisualStyleBackColor = true;
            this.btnArrayForeach.Click += new System.EventHandler(this.btnArrayForeach_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.textBox25);
            this.grpControls.Controls.Add(this.textBox4);
            this.grpControls.Controls.Add(this.textBox7);
            this.grpControls.Controls.Add(this.textBox8);
            this.grpControls.Controls.Add(this.textBox5);
            this.grpControls.Controls.Add(this.textBox6);
            this.grpControls.Controls.Add(this.textBox3);
            this.grpControls.Controls.Add(this.textBox1);
            this.grpControls.Controls.Add(this.label3);
            this.grpControls.Controls.Add(this.btnAllClear);
            this.grpControls.Location = new System.Drawing.Point(30, 195);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1404, 418);
            this.grpControls.TabIndex = 6;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "컨테이너 도구 모음";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(15, 329);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(440, 28);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "안녕하세요";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(15, 295);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(440, 28);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "안녕하세요";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(440, 28);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "안녕하세요";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 227);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(440, 28);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "안녕하세요";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(440, 28);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "안녕하세요";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 28);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "안녕하세요";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "컨테이너에 포함된 도구(Control)  중에 텍스트박스를 일괄 초기화 하기.\r\n";
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(15, 27);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(163, 43);
            this.btnAllClear.TabIndex = 7;
            this.btnAllClear.Text = "일괄 초기화";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(787, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 22);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(440, 28);
            this.textBox4.TabIndex = 35;
            this.textBox4.Text = "안녕하세요";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(15, 159);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(440, 28);
            this.textBox25.TabIndex = 36;
            this.textBox25.Text = "안녕하세요";
            // 
            // Chap19_Foreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 636);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.btnArrayForeach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStringForeach);
            this.Name = "Chap19_Foreach";
            this.Text = "반복문 Foreach";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStringForeach;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArrayForeach;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox4;
        //System.Windows.Forms.Button button1;
    }
}