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
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnhashTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(26, 120);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(195, 103);
            this.btnArrayList.TabIndex = 2;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(26, 229);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(195, 103);
            this.btnQueue.TabIndex = 3;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(227, 229);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(195, 103);
            this.btnStack.TabIndex = 4;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDictionary.Location = new System.Drawing.Point(26, 338);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(195, 103);
            this.btnDictionary.TabIndex = 5;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnhashTable
            // 
            this.btnhashTable.Location = new System.Drawing.Point(227, 338);
            this.btnhashTable.Name = "btnhashTable";
            this.btnhashTable.Size = new System.Drawing.Size(195, 103);
            this.btnhashTable.TabIndex = 6;
            this.btnhashTable.Text = "HashTable";
            this.btnhashTable.UseVisualStyleBackColor = true;
            this.btnhashTable.Click += new System.EventHandler(this.btnhashTable_Click);
            // 
            // Chap21_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 476);
            this.Controls.Add(this.btnhashTable);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnListII);
            this.Controls.Add(this.btnList);
            this.Name = "Chap21_Collection";
            this.Text = "Chap21_Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnListII;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnhashTable;
    }
}