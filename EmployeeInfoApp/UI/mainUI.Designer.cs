namespace EmployeeInfoApp
{
    partial class mainUI
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
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.findEditButton = new System.Windows.Forms.Button();
            this.employeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Controls.Add(this.findEditButton);
            this.employeeGroupBox.Controls.Add(this.addButton);
            this.employeeGroupBox.Location = new System.Drawing.Point(31, 49);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(221, 157);
            this.employeeGroupBox.TabIndex = 0;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Employee";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 58);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 53);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // findEditButton
            // 
            this.findEditButton.Location = new System.Drawing.Point(115, 58);
            this.findEditButton.Name = "findEditButton";
            this.findEditButton.Size = new System.Drawing.Size(75, 53);
            this.findEditButton.TabIndex = 0;
            this.findEditButton.Text = "Find & Edit";
            this.findEditButton.UseVisualStyleBackColor = true;
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.employeeGroupBox);
            this.Name = "mainUI";
            this.Text = "Employee Information";
            this.employeeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.Button findEditButton;
        private System.Windows.Forms.Button addButton;
    }
}

