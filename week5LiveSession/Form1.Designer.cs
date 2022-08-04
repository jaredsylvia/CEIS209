namespace week5
{
    partial class mainForm
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
            this.messageBoxMessageText = new System.Windows.Forms.TextBox();
            this.messageBoxTextLabel = new System.Windows.Forms.Label();
            this.showMessageBox = new System.Windows.Forms.Button();
            this.messageBoxTitleLabel = new System.Windows.Forms.Label();
            this.messageBoxTitleText = new System.Windows.Forms.TextBox();
            this.messageBoxButtonLabel = new System.Windows.Forms.Label();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // messageBoxMessageText
            // 
            this.messageBoxMessageText.Location = new System.Drawing.Point(166, 54);
            this.messageBoxMessageText.Name = "messageBoxMessageText";
            this.messageBoxMessageText.Size = new System.Drawing.Size(199, 20);
            this.messageBoxMessageText.TabIndex = 2;
            // 
            // messageBoxTextLabel
            // 
            this.messageBoxTextLabel.AutoSize = true;
            this.messageBoxTextLabel.Location = new System.Drawing.Point(12, 57);
            this.messageBoxTextLabel.Name = "messageBoxTextLabel";
            this.messageBoxTextLabel.Size = new System.Drawing.Size(98, 13);
            this.messageBoxTextLabel.TabIndex = 1;
            this.messageBoxTextLabel.Text = "Message Box Text:";
            // 
            // showMessageBox
            // 
            this.showMessageBox.Location = new System.Drawing.Point(145, 130);
            this.showMessageBox.Name = "showMessageBox";
            this.showMessageBox.Size = new System.Drawing.Size(85, 41);
            this.showMessageBox.TabIndex = 5;
            this.showMessageBox.Text = "Show Message Box";
            this.showMessageBox.UseVisualStyleBackColor = true;
            this.showMessageBox.Click += new System.EventHandler(this.showMessageBox_Click);
            // 
            // messageBoxTitleLabel
            // 
            this.messageBoxTitleLabel.AutoSize = true;
            this.messageBoxTitleLabel.Location = new System.Drawing.Point(12, 31);
            this.messageBoxTitleLabel.Name = "messageBoxTitleLabel";
            this.messageBoxTitleLabel.Size = new System.Drawing.Size(97, 13);
            this.messageBoxTitleLabel.TabIndex = 4;
            this.messageBoxTitleLabel.Text = "Message Box Title:";
            // 
            // messageBoxTitleText
            // 
            this.messageBoxTitleText.Location = new System.Drawing.Point(166, 28);
            this.messageBoxTitleText.Name = "messageBoxTitleText";
            this.messageBoxTitleText.Size = new System.Drawing.Size(199, 20);
            this.messageBoxTitleText.TabIndex = 1;
            // 
            // messageBoxButtonLabel
            // 
            this.messageBoxButtonLabel.AutoSize = true;
            this.messageBoxButtonLabel.Location = new System.Drawing.Point(12, 83);
            this.messageBoxButtonLabel.Name = "messageBoxButtonLabel";
            this.messageBoxButtonLabel.Size = new System.Drawing.Size(84, 13);
            this.messageBoxButtonLabel.TabIndex = 6;
            this.messageBoxButtonLabel.Text = "Okay or Yes/No";
            this.messageBoxButtonLabel.Click += new System.EventHandler(this.messageBoxButtonLabel_Click);
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Checked = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(166, 83);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(50, 17);
            this.radioButtonTrue.TabIndex = 3;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "Okay";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(303, 83);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(62, 17);
            this.radioButtonFalse.TabIndex = 4;
            this.radioButtonFalse.Text = "Yes/No";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 188);
            this.Controls.Add(this.radioButtonFalse);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.messageBoxButtonLabel);
            this.Controls.Add(this.messageBoxTitleLabel);
            this.Controls.Add(this.messageBoxTitleText);
            this.Controls.Add(this.showMessageBox);
            this.Controls.Add(this.messageBoxTextLabel);
            this.Controls.Add(this.messageBoxMessageText);
            this.Name = "mainForm";
            this.Text = "Week 5 Live Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBoxMessageText;
        private System.Windows.Forms.Label messageBoxTextLabel;
        private System.Windows.Forms.Button showMessageBox;
        private System.Windows.Forms.Label messageBoxTitleLabel;
        private System.Windows.Forms.TextBox messageBoxTitleText;
        private System.Windows.Forms.Label messageBoxButtonLabel;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
    }
}

