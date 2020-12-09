namespace StopList
{
    partial class SettingsForm_StopList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_StopList));
            this.OKButton = new System.Windows.Forms.Button();
            this.ClearStopListButton = new System.Windows.Forms.Button();
            this.LoadStopListButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.StopListLanguageSelector = new System.Windows.Forms.ComboBox();
            this.StopListTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CaseSensitiveCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WordWindowRightTextbox = new System.Windows.Forms.TextBox();
            this.WordWindowLeftTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(272, 502);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ClearStopListButton
            // 
            this.ClearStopListButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearStopListButton.Location = new System.Drawing.Point(447, 177);
            this.ClearStopListButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearStopListButton.Name = "ClearStopListButton";
            this.ClearStopListButton.Size = new System.Drawing.Size(106, 23);
            this.ClearStopListButton.TabIndex = 13;
            this.ClearStopListButton.Text = "Clear Stop List";
            this.ClearStopListButton.UseVisualStyleBackColor = true;
            this.ClearStopListButton.Click += new System.EventHandler(this.ClearStopListButton_Click);
            // 
            // LoadStopListButton
            // 
            this.LoadStopListButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadStopListButton.Location = new System.Drawing.Point(447, 132);
            this.LoadStopListButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadStopListButton.Name = "LoadStopListButton";
            this.LoadStopListButton.Size = new System.Drawing.Size(106, 23);
            this.LoadStopListButton.TabIndex = 12;
            this.LoadStopListButton.Text = "Load Stop List";
            this.LoadStopListButton.UseVisualStyleBackColor = true;
            this.LoadStopListButton.Click += new System.EventHandler(this.LoadStopListButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(365, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Language:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Load Default Stop List:";
            // 
            // StopListLanguageSelector
            // 
            this.StopListLanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopListLanguageSelector.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopListLanguageSelector.FormattingEnabled = true;
            this.StopListLanguageSelector.Location = new System.Drawing.Point(369, 88);
            this.StopListLanguageSelector.Margin = new System.Windows.Forms.Padding(2);
            this.StopListLanguageSelector.MaxDropDownItems = 20;
            this.StopListLanguageSelector.Name = "StopListLanguageSelector";
            this.StopListLanguageSelector.Size = new System.Drawing.Size(266, 25);
            this.StopListLanguageSelector.TabIndex = 9;
            // 
            // StopListTextbox
            // 
            this.StopListTextbox.AcceptsReturn = true;
            this.StopListTextbox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopListTextbox.Location = new System.Drawing.Point(11, 37);
            this.StopListTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.StopListTextbox.MaxLength = 2147483647;
            this.StopListTextbox.Multiline = true;
            this.StopListTextbox.Name = "StopListTextbox";
            this.StopListTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StopListTextbox.Size = new System.Drawing.Size(316, 394);
            this.StopListTextbox.TabIndex = 8;
            this.StopListTextbox.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stop List";
            // 
            // CaseSensitiveCheckbox
            // 
            this.CaseSensitiveCheckbox.AutoSize = true;
            this.CaseSensitiveCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseSensitiveCheckbox.Location = new System.Drawing.Point(60, 439);
            this.CaseSensitiveCheckbox.Name = "CaseSensitiveCheckbox";
            this.CaseSensitiveCheckbox.Size = new System.Drawing.Size(203, 20);
            this.CaseSensitiveCheckbox.TabIndex = 14;
            this.CaseSensitiveCheckbox.Text = "Stop List is Case Sensitive";
            this.CaseSensitiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WordWindowRightTextbox);
            this.groupBox1.Controls.Add(this.WordWindowLeftTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(368, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 225);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove \"Stop Context\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word Window (Left)";
            // 
            // WordWindowRightTextbox
            // 
            this.WordWindowRightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordWindowRightTextbox.Location = new System.Drawing.Point(182, 68);
            this.WordWindowRightTextbox.Name = "WordWindowRightTextbox";
            this.WordWindowRightTextbox.Size = new System.Drawing.Size(53, 22);
            this.WordWindowRightTextbox.TabIndex = 15;
            this.WordWindowRightTextbox.Text = "0";
            this.WordWindowRightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WordWindowLeftTextbox
            // 
            this.WordWindowLeftTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordWindowLeftTextbox.Location = new System.Drawing.Point(182, 33);
            this.WordWindowLeftTextbox.Name = "WordWindowLeftTextbox";
            this.WordWindowLeftTextbox.Size = new System.Drawing.Size(53, 22);
            this.WordWindowLeftTextbox.TabIndex = 0;
            this.WordWindowLeftTextbox.Text = "0";
            this.WordWindowLeftTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "N = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "N = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Word Window (Right)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 90);
            this.label3.TabIndex = 18;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // SettingsForm_StopList
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CaseSensitiveCheckbox);
            this.Controls.Add(this.ClearStopListButton);
            this.Controls.Add(this.LoadStopListButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StopListLanguageSelector);
            this.Controls.Add(this.StopListTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OKButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_StopList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ClearStopListButton;
        private System.Windows.Forms.Button LoadStopListButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox StopListLanguageSelector;
        private System.Windows.Forms.TextBox StopListTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WordWindowRightTextbox;
        private System.Windows.Forms.TextBox WordWindowLeftTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}