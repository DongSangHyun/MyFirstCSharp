namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test_Teacher
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNameChange = new System.Windows.Forms.Button();
            this.btnFindSwIndex = new System.Windows.Forms.Button();
            this.btnFLWord = new System.Windows.Forms.Button();
            this.btnIsertDT = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnRemoveSpace = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1717, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btnNameChange
            // 
            this.btnNameChange.Location = new System.Drawing.Point(28, 94);
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Size = new System.Drawing.Size(334, 65);
            this.btnNameChange.TabIndex = 1;
            this.btnNameChange.Text = "OOO -> 본인 이름으로 변경\r\n * 라벨 TEXT 에 직접 변경해서 표현";
            this.btnNameChange.UseVisualStyleBackColor = true;
            this.btnNameChange.Click += new System.EventHandler(this.btnNameChange_Click);
            // 
            // btnFindSwIndex
            // 
            this.btnFindSwIndex.Location = new System.Drawing.Point(422, 94);
            this.btnFindSwIndex.Name = "btnFindSwIndex";
            this.btnFindSwIndex.Size = new System.Drawing.Size(332, 65);
            this.btnFindSwIndex.TabIndex = 2;
            this.btnFindSwIndex.Text = "\"S/W\" 의 위치 찾고 메세지박스\r\n * 구현은 In Line 으로 ";
            this.btnFindSwIndex.UseVisualStyleBackColor = true;
            this.btnFindSwIndex.Click += new System.EventHandler(this.btnFindSwIndex_Click);
            // 
            // btnFLWord
            // 
            this.btnFLWord.Location = new System.Drawing.Point(28, 165);
            this.btnFLWord.Name = "btnFLWord";
            this.btnFLWord.Size = new System.Drawing.Size(334, 65);
            this.btnFLWord.TabIndex = 3;
            this.btnFLWord.Text = "시작 단어 와 마지막 단어 각각 1자씩\r\n메세지 로 표현";
            this.btnFLWord.UseVisualStyleBackColor = true;
            this.btnFLWord.Click += new System.EventHandler(this.btnFLWord_Click);
            // 
            // btnIsertDT
            // 
            this.btnIsertDT.Location = new System.Drawing.Point(422, 165);
            this.btnIsertDT.Name = "btnIsertDT";
            this.btnIsertDT.Size = new System.Drawing.Size(332, 65);
            this.btnIsertDT.TabIndex = 4;
            this.btnIsertDT.Text = "타이틀 문자열 의 앞, 뒤 에 \r\n\"-DT-\" 문자열 삽입\r\n * 라벨 TEXT 에 직접 표현";
            this.btnIsertDT.UseVisualStyleBackColor = true;
            this.btnIsertDT.Click += new System.EventHandler(this.btnIsertDT_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(28, 236);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(334, 65);
            this.btnLower.TabIndex = 5;
            this.btnLower.Text = "DIGITALTRANING 만 소문자로 변경\r\n * DIGITALTRANING 문자는 고정\r\n * 라벨 TEXT 에 직접 표현";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnRemoveSpace
            // 
            this.btnRemoveSpace.Location = new System.Drawing.Point(422, 236);
            this.btnRemoveSpace.Name = "btnRemoveSpace";
            this.btnRemoveSpace.Size = new System.Drawing.Size(332, 65);
            this.btnRemoveSpace.TabIndex = 6;
            this.btnRemoveSpace.Text = "타이틀의 문자열의 모든 공백 없애기\r\n * 라벨 TEXT 에 직접 표현";
            this.btnRemoveSpace.UseVisualStyleBackColor = true;
            this.btnRemoveSpace.Click += new System.EventHandler(this.btnRemoveSpace_Click);
            // 
            // btnRollback
            // 
            this.btnRollback.Location = new System.Drawing.Point(30, 307);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(724, 65);
            this.btnRollback.TabIndex = 7;
            this.btnRollback.Text = "원본 문자열 되돌리기";
            this.btnRollback.UseVisualStyleBackColor = true;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // Chap09_StringManage_Test_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 450);
            this.Controls.Add(this.btnRollback);
            this.Controls.Add(this.btnRemoveSpace);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnIsertDT);
            this.Controls.Add(this.btnFLWord);
            this.Controls.Add(this.btnFindSwIndex);
            this.Controls.Add(this.btnNameChange);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap09_StringManage_Test_Teacher";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         System.Windows.Forms.Label lblTitle;
         System.Windows.Forms.Button btnNameChange;
         System.Windows.Forms.Button btnFindSwIndex;
         System.Windows.Forms.Button btnFLWord;
         System.Windows.Forms.Button btnIsertDT;
         System.Windows.Forms.Button btnLower;
         System.Windows.Forms.Button btnRemoveSpace;
         System.Windows.Forms.Button btnRollback;
    }
}