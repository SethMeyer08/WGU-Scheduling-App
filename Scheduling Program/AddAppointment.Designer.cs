
namespace C969___Seth_Meyer___Scheduling_Software
{
    partial class AddAppointment
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.startFormatLabel = new System.Windows.Forms.Label();
            this.endFormatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(267, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(88, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add Appointment";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(69, 104);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.customerIDLabel.TabIndex = 1;
            this.customerIDLabel.Text = "Customer ID";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(458, 121);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(72, 188);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(81, 13);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start Date Time";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(461, 198);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(78, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End Date Time";
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.Location = new System.Drawing.Point(72, 121);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.custIDTextBox.TabIndex = 5;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(461, 138);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 6;
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(75, 221);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTextBox.TabIndex = 7;
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(464, 238);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(86, 344);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(488, 344);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            
            // 
            // startFormatLabel
            // 
            this.startFormatLabel.AutoSize = true;
            this.startFormatLabel.Location = new System.Drawing.Point(72, 205);
            this.startFormatLabel.Name = "startFormatLabel";
            this.startFormatLabel.Size = new System.Drawing.Size(99, 13);
            this.startFormatLabel.TabIndex = 12;
            this.startFormatLabel.Text = "mm/dd/yyyy hh:mm";
            // 
            // endFormatLabel
            // 
            this.endFormatLabel.AutoSize = true;
            this.endFormatLabel.Location = new System.Drawing.Point(464, 215);
            this.endFormatLabel.Name = "endFormatLabel";
            this.endFormatLabel.Size = new System.Drawing.Size(99, 13);
            this.endFormatLabel.TabIndex = 13;
            this.endFormatLabel.Text = "mm/dd/yyyy hh:mm";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 463);
            this.Controls.Add(this.endFormatLabel);
            this.Controls.Add(this.startFormatLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.custIDTextBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label startFormatLabel;
        private System.Windows.Forms.Label endFormatLabel;
    }
}