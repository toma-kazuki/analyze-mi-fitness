namespace analyze_mi_fitness
{
    partial class AnalyzeMiFitnessExerciseData
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.MinDistanceRangeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxDistanceRangeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilePassTextBox
            // 
            this.FilePassTextBox.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FilePassTextBox.Location = new System.Drawing.Point(52, 54);
            this.FilePassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilePassTextBox.Name = "FilePassTextBox";
            this.FilePassTextBox.ReadOnly = true;
            this.FilePassTextBox.Size = new System.Drawing.Size(364, 23);
            this.FilePassTextBox.TabIndex = 100;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SelectFileButton.Location = new System.Drawing.Point(424, 49);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(48, 34);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ランニングデータを選択";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(159, 252);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(161, 43);
            this.ExportButton.TabIndex = 101;
            this.ExportButton.Text = "エクスポート実行";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // MinDistanceRangeComboBox
            // 
            this.MinDistanceRangeComboBox.FormattingEnabled = true;
            this.MinDistanceRangeComboBox.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30",
            "30.5",
            "31",
            "31.5",
            "32",
            "32.5",
            "33",
            "33.5",
            "34",
            "34.5",
            "35",
            "35.5",
            "36",
            "36.5",
            "37",
            "37.5",
            "38",
            "38.5",
            "39",
            "39.5",
            "40",
            "40.5",
            "41",
            "41.5",
            "42",
            "42.5",
            "43"});
            this.MinDistanceRangeComboBox.Location = new System.Drawing.Point(53, 143);
            this.MinDistanceRangeComboBox.Name = "MinDistanceRangeComboBox";
            this.MinDistanceRangeComboBox.Size = new System.Drawing.Size(73, 25);
            this.MinDistanceRangeComboBox.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "ー";
            // 
            // MaxDistanceRangeComboBox
            // 
            this.MaxDistanceRangeComboBox.FormattingEnabled = true;
            this.MaxDistanceRangeComboBox.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30",
            "30.5",
            "31",
            "31.5",
            "32",
            "32.5",
            "33",
            "33.5",
            "34",
            "34.5",
            "35",
            "35.5",
            "36",
            "36.5",
            "37",
            "37.5",
            "38",
            "38.5",
            "39",
            "39.5",
            "40",
            "40.5",
            "41",
            "41.5",
            "42",
            "42.5",
            "43"});
            this.MaxDistanceRangeComboBox.Location = new System.Drawing.Point(159, 143);
            this.MaxDistanceRangeComboBox.Name = "MaxDistanceRangeComboBox";
            this.MaxDistanceRangeComboBox.Size = new System.Drawing.Size(73, 25);
            this.MaxDistanceRangeComboBox.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 111;
            this.label5.Text = "km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "出力する範囲を選択";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "進捗：";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(239, 301);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 17);
            this.ProgressLabel.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 17);
            this.label7.TabIndex = 115;
            this.label7.Text = "平均ペース、平均心拍数、走行距離、タイムを出力します。";
            // 
            // AnalyzeMiFitnessExerciseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 343);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxDistanceRangeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinDistanceRangeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.FilePassTextBox);
            this.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AnalyzeMiFitnessExerciseData";
            this.Text = "AnalyzeMiFitnessExerciseData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePassTextBox;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.ComboBox MinDistanceRangeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MaxDistanceRangeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label label7;
    }
}

