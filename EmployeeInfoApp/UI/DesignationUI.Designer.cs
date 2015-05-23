namespace EmployeeInfoApp.UI
{
    partial class DesignationUI
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
            this.designationGroupBox = new System.Windows.Forms.GroupBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.designationSaveButton = new System.Windows.Forms.Button();
            this.designationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // designationGroupBox
            // 
            this.designationGroupBox.Controls.Add(this.designationSaveButton);
            this.designationGroupBox.Controls.Add(this.titleTextBox);
            this.designationGroupBox.Controls.Add(this.codeTextBox);
            this.designationGroupBox.Controls.Add(this.titleLabel);
            this.designationGroupBox.Controls.Add(this.codeLabel);
            this.designationGroupBox.Location = new System.Drawing.Point(12, 24);
            this.designationGroupBox.Name = "designationGroupBox";
            this.designationGroupBox.Size = new System.Drawing.Size(247, 129);
            this.designationGroupBox.TabIndex = 0;
            this.designationGroupBox.TabStop = false;
            this.designationGroupBox.Text = "Designation";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(18, 33);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(68, 30);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(112, 20);
            this.codeTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(23, 59);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(67, 56);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(162, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // designationSaveButton
            // 
            this.designationSaveButton.Location = new System.Drawing.Point(154, 82);
            this.designationSaveButton.Name = "designationSaveButton";
            this.designationSaveButton.Size = new System.Drawing.Size(75, 23);
            this.designationSaveButton.TabIndex = 2;
            this.designationSaveButton.Text = "Save";
            this.designationSaveButton.UseVisualStyleBackColor = true;
            // 
            // DesignationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 173);
            this.Controls.Add(this.designationGroupBox);
            this.Name = "DesignationUI";
            this.Text = "Add Designation";
            this.designationGroupBox.ResumeLayout(false);
            this.designationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox designationGroupBox;
        private System.Windows.Forms.Button designationSaveButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label codeLabel;
    }
}