namespace EmployeeInfoApp.UI
{
    partial class EmployeeInformationUI
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
            this.employeeInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.designationLabel = new System.Windows.Forms.Label();
            this.employeeListComboBox = new System.Windows.Forms.ComboBox();
            this.addMoreButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.employeeInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeInformationGroupBox
            // 
            this.employeeInformationGroupBox.Controls.Add(this.saveButton);
            this.employeeInformationGroupBox.Controls.Add(this.addMoreButton);
            this.employeeInformationGroupBox.Controls.Add(this.employeeListComboBox);
            this.employeeInformationGroupBox.Controls.Add(this.addressTextBox);
            this.employeeInformationGroupBox.Controls.Add(this.emailTextBox);
            this.employeeInformationGroupBox.Controls.Add(this.nameTextBox);
            this.employeeInformationGroupBox.Controls.Add(this.designationLabel);
            this.employeeInformationGroupBox.Controls.Add(this.addressLabel);
            this.employeeInformationGroupBox.Controls.Add(this.emailLabel);
            this.employeeInformationGroupBox.Controls.Add(this.nameLabel);
            this.employeeInformationGroupBox.Location = new System.Drawing.Point(25, 24);
            this.employeeInformationGroupBox.Name = "employeeInformationGroupBox";
            this.employeeInformationGroupBox.Size = new System.Drawing.Size(376, 319);
            this.employeeInformationGroupBox.TabIndex = 0;
            this.employeeInformationGroupBox.TabStop = false;
            this.employeeInformationGroupBox.Text = "Employee Information";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(67, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(126, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(216, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(70, 74);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(126, 67);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(216, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(57, 129);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(126, 103);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(216, 58);
            this.addressTextBox.TabIndex = 1;
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.Location = new System.Drawing.Point(39, 194);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(63, 13);
            this.designationLabel.TabIndex = 0;
            this.designationLabel.Text = "Designation";
            // 
            // employeeListComboBox
            // 
            this.employeeListComboBox.FormattingEnabled = true;
            this.employeeListComboBox.Location = new System.Drawing.Point(126, 191);
            this.employeeListComboBox.Name = "employeeListComboBox";
            this.employeeListComboBox.Size = new System.Drawing.Size(135, 21);
            this.employeeListComboBox.TabIndex = 2;
            // 
            // addMoreButton
            // 
            this.addMoreButton.Location = new System.Drawing.Point(267, 189);
            this.addMoreButton.Name = "addMoreButton";
            this.addMoreButton.Size = new System.Drawing.Size(75, 23);
            this.addMoreButton.TabIndex = 3;
            this.addMoreButton.Text = "Add More..";
            this.addMoreButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(267, 238);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 355);
            this.Controls.Add(this.employeeInformationGroupBox);
            this.Name = "EmployeeInformationUI";
            this.Text = "Employee Information";
            this.employeeInformationGroupBox.ResumeLayout(false);
            this.employeeInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeInformationGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addMoreButton;
        private System.Windows.Forms.ComboBox employeeListComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}