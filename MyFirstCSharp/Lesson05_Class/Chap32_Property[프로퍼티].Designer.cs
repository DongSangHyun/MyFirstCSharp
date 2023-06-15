namespace MyFirstCSharp.Lesson05_Class
{
    partial class Chap32_Property
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
            this.txtInQyt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInQyt
            // 
            this.txtInQyt.Location = new System.Drawing.Point(37, 28);
            this.txtInQyt.Name = "txtInQyt";
            this.txtInQyt.Size = new System.Drawing.Size(247, 28);
            this.txtInQyt.TabIndex = 0;
            this.txtInQyt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "개";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "현재 재고량";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Location = new System.Drawing.Point(482, 38);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(18, 18);
            this.lblStockQty.TabIndex = 3;
            this.lblStockQty.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "개";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(78, 114);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(190, 51);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "입고";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(370, 114);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(190, 51);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = "만화책 판매";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // Chap32_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 202);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInQyt);
            this.Name = "Chap32_Property";
            this.Text = "프로퍼티";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInQyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSale;
    }
}