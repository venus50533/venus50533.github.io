namespace Farmer_crossing_the_river02
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Right_listBox = new System.Windows.Forms.ListBox();
            this.Left_listBox = new System.Windows.Forms.ListBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = " 農夫要帶著狼、羊、菜過河。";
            // 
            // Right_listBox
            // 
            this.Right_listBox.FormattingEnabled = true;
            this.Right_listBox.ItemHeight = 18;
            this.Right_listBox.Location = new System.Drawing.Point(496, 78);
            this.Right_listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Right_listBox.Name = "Right_listBox";
            this.Right_listBox.Size = new System.Drawing.Size(193, 328);
            this.Right_listBox.TabIndex = 10;
            // 
            // Left_listBox
            // 
            this.Left_listBox.FormattingEnabled = true;
            this.Left_listBox.ItemHeight = 18;
            this.Left_listBox.Location = new System.Drawing.Point(12, 79);
            this.Left_listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Left_listBox.Name = "Left_listBox";
            this.Left_listBox.Size = new System.Drawing.Size(193, 328);
            this.Left_listBox.TabIndex = 7;
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GoButton.Location = new System.Drawing.Point(251, 159);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(199, 98);
            this.GoButton.TabIndex = 8;
            this.GoButton.Text = "←→";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButtonClick);
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("ROG Fonts", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(262, 321);
            this.Reset_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(174, 67);
            this.Reset_button.TabIndex = 13;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.ResetButtonClick_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 437);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Right_listBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.Left_listBox);
            this.Name = "Form2";
            this.Text = "農夫過河-版本二";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Right_listBox;
        private System.Windows.Forms.ListBox Left_listBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button Reset_button;
    }
}

