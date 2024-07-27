namespace TA_Farmer_crossing_the_river03
{
    partial class TAForm3
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rightlistBox = new System.Windows.Forms.ListBox();
            this.leftlistBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GoRight_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ROG Fonts", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 56);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = " 農夫要帶著狼、羊、菜過河。";
            // 
            // rightlistBox
            // 
            this.rightlistBox.FormattingEnabled = true;
            this.rightlistBox.ItemHeight = 15;
            this.rightlistBox.Location = new System.Drawing.Point(513, 98);
            this.rightlistBox.Name = "rightlistBox";
            this.rightlistBox.Size = new System.Drawing.Size(172, 319);
            this.rightlistBox.TabIndex = 21;
            // 
            // leftlistBox
            // 
            this.leftlistBox.FormattingEnabled = true;
            this.leftlistBox.ItemHeight = 15;
            this.leftlistBox.Location = new System.Drawing.Point(76, 98);
            this.leftlistBox.Name = "leftlistBox";
            this.leftlistBox.Size = new System.Drawing.Size(172, 319);
            this.leftlistBox.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("ROG Fonts", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 56);
            this.button2.TabIndex = 24;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RestorebuttonClick);
            // 
            // GoRight_button
            // 
            this.GoRight_button.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GoRight_button.Location = new System.Drawing.Point(286, 111);
            this.GoRight_button.Name = "GoRight_button";
            this.GoRight_button.Size = new System.Drawing.Size(177, 82);
            this.GoRight_button.TabIndex = 25;
            this.GoRight_button.Text = "←→";
            this.GoRight_button.UseVisualStyleBackColor = true;
            this.GoRight_button.Click += new System.EventHandler(this.CrossRiverBtnClick);
            // 
            // TAForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoRight_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightlistBox);
            this.Controls.Add(this.leftlistBox);
            this.Name = "TAForm3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox rightlistBox;
        private System.Windows.Forms.ListBox leftlistBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GoRight_button;
    }
}

