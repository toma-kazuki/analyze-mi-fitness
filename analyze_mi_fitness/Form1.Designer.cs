namespace analyze_mi_fitness
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FilePassTextBox = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePassTextBox
            // 
            this.FilePassTextBox.Location = new System.Drawing.Point(38, 23);
            this.FilePassTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilePassTextBox.Name = "FilePassTextBox";
            this.FilePassTextBox.Size = new System.Drawing.Size(831, 32);
            this.FilePassTextBox.TabIndex = 0;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(380, 65);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(161, 59);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "ファイル選択";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 415);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.FilePassTextBox);
            this.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePassTextBox;
        private System.Windows.Forms.Button SelectFileButton;
    }
}

