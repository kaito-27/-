namespace WindowsFormsApp56
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
            this.hourly = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.going = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.Label();
            this.wage = new System.Windows.Forms.Label();
            this.hourlyText = new System.Windows.Forms.TextBox();
            this.wageText = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.goingPicker = new System.Windows.Forms.DateTimePicker();
            this.departurePicker = new System.Windows.Forms.DateTimePicker();
            this.calcuButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourly
            // 
            this.hourly.AutoSize = true;
            this.hourly.Location = new System.Drawing.Point(119, 111);
            this.hourly.Name = "hourly";
            this.hourly.Size = new System.Drawing.Size(37, 15);
            this.hourly.TabIndex = 0;
            this.hourly.Text = "時給";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(119, 139);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(37, 15);
            this.date.TabIndex = 1;
            this.date.Text = "日付";
            // 
            // going
            // 
            this.going.AutoSize = true;
            this.going.Location = new System.Drawing.Point(104, 167);
            this.going.Name = "going";
            this.going.Size = new System.Drawing.Size(67, 15);
            this.going.TabIndex = 2;
            this.going.Text = "出勤時刻";
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.Location = new System.Drawing.Point(104, 199);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(67, 15);
            this.departure.TabIndex = 3;
            this.departure.Text = "退勤時刻";
            // 
            // wage
            // 
            this.wage.AutoSize = true;
            this.wage.Location = new System.Drawing.Point(119, 298);
            this.wage.Name = "wage";
            this.wage.Size = new System.Drawing.Size(37, 15);
            this.wage.TabIndex = 4;
            this.wage.Text = "賃金";
            // 
            // hourlyText
            // 
            this.hourlyText.Location = new System.Drawing.Point(191, 108);
            this.hourlyText.Name = "hourlyText";
            this.hourlyText.Size = new System.Drawing.Size(243, 22);
            this.hourlyText.TabIndex = 5;
            // 
            // wageText
            // 
            this.wageText.Location = new System.Drawing.Point(191, 295);
            this.wageText.Name = "wageText";
            this.wageText.Size = new System.Drawing.Size(243, 22);
            this.wageText.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(191, 136);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(243, 22);
            this.datePicker.TabIndex = 7;
            // 
            // goingPicker
            // 
            this.goingPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goingPicker.Location = new System.Drawing.Point(191, 167);
            this.goingPicker.Name = "goingPicker";
            this.goingPicker.ShowUpDown = true;
            this.goingPicker.Size = new System.Drawing.Size(243, 22);
            this.goingPicker.TabIndex = 8;
            // 
            // departurePicker
            // 
            this.departurePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departurePicker.Location = new System.Drawing.Point(191, 199);
            this.departurePicker.Name = "departurePicker";
            this.departurePicker.ShowUpDown = true;
            this.departurePicker.Size = new System.Drawing.Size(243, 22);
            this.departurePicker.TabIndex = 9;
            // 
            // calcuButton
            // 
            this.calcuButton.Location = new System.Drawing.Point(232, 248);
            this.calcuButton.Name = "calcuButton";
            this.calcuButton.Size = new System.Drawing.Size(75, 23);
            this.calcuButton.TabIndex = 10;
            this.calcuButton.Text = "計算";
            this.calcuButton.UseVisualStyleBackColor = true;
            this.calcuButton.Click += new System.EventHandler(this.calcuButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(188, 365);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(81, 15);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "エラーを表示";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 454);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.calcuButton);
            this.Controls.Add(this.departurePicker);
            this.Controls.Add(this.goingPicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.wageText);
            this.Controls.Add(this.hourlyText);
            this.Controls.Add(this.wage);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.going);
            this.Controls.Add(this.date);
            this.Controls.Add(this.hourly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hourly;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label going;
        private System.Windows.Forms.Label departure;
        private System.Windows.Forms.Label wage;
        private System.Windows.Forms.TextBox hourlyText;
        private System.Windows.Forms.TextBox wageText;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker goingPicker;
        private System.Windows.Forms.DateTimePicker departurePicker;
        private System.Windows.Forms.Button calcuButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

