
namespace C969___Seth_Meyer___Scheduling_Software
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.createCustButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteApptButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.createApptButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loginReportButton = new System.Windows.Forms.Button();
            this.consultantSchedButton = new System.Windows.Forms.Button();
            this.apptMonthButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.weeklyRadio = new System.Windows.Forms.RadioButton();
            this.monthlyRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 305);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(506, 574);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(212, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(662, 29);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Customer and Appointment Scheduling Management System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteCustButton);
            this.groupBox1.Controls.Add(this.updateCustButton);
            this.groupBox1.Controls.Add(this.createCustButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.Location = new System.Drawing.Point(344, 23);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(125, 30);
            this.deleteCustButton.TabIndex = 2;
            this.deleteCustButton.Text = "Delete Customer";
            this.deleteCustButton.UseVisualStyleBackColor = true;
            this.deleteCustButton.Click += new System.EventHandler(this.deleteCustButton_Click);
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(178, 23);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(125, 30);
            this.updateCustButton.TabIndex = 1;
            this.updateCustButton.Text = "Update Customer";
            this.updateCustButton.UseVisualStyleBackColor = true;
            this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
            // 
            // createCustButton
            // 
            this.createCustButton.Location = new System.Drawing.Point(6, 23);
            this.createCustButton.Name = "createCustButton";
            this.createCustButton.Size = new System.Drawing.Size(125, 30);
            this.createCustButton.TabIndex = 0;
            this.createCustButton.Text = "Create Customer";
            this.createCustButton.UseVisualStyleBackColor = true;
            this.createCustButton.Click += new System.EventHandler(this.createCustButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteApptButton);
            this.groupBox2.Controls.Add(this.updateApptButton);
            this.groupBox2.Controls.Add(this.createApptButton);
            this.groupBox2.Location = new System.Drawing.Point(616, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointments";
            // 
            // deleteApptButton
            // 
            this.deleteApptButton.Location = new System.Drawing.Point(344, 23);
            this.deleteApptButton.Name = "deleteApptButton";
            this.deleteApptButton.Size = new System.Drawing.Size(125, 30);
            this.deleteApptButton.TabIndex = 2;
            this.deleteApptButton.Text = "Delete Appointment";
            this.deleteApptButton.UseVisualStyleBackColor = true;
            this.deleteApptButton.Click += new System.EventHandler(this.deleteApptButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.Location = new System.Drawing.Point(184, 23);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(125, 30);
            this.updateApptButton.TabIndex = 1;
            this.updateApptButton.Text = "Update Appointment";
            this.updateApptButton.UseVisualStyleBackColor = true;
            this.updateApptButton.Click += new System.EventHandler(this.updateApptButton_Click);
            // 
            // createApptButton
            // 
            this.createApptButton.Location = new System.Drawing.Point(6, 23);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(125, 30);
            this.createApptButton.TabIndex = 0;
            this.createApptButton.Text = "Create Appointment";
            this.createApptButton.UseVisualStyleBackColor = true;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loginReportButton);
            this.groupBox3.Controls.Add(this.consultantSchedButton);
            this.groupBox3.Controls.Add(this.apptMonthButton);
            this.groupBox3.Location = new System.Drawing.Point(33, 496);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1028, 62);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // loginReportButton
            // 
            this.loginReportButton.Location = new System.Drawing.Point(822, 19);
            this.loginReportButton.Name = "loginReportButton";
            this.loginReportButton.Size = new System.Drawing.Size(200, 30);
            this.loginReportButton.TabIndex = 2;
            this.loginReportButton.Text = "Login Reports";
            this.loginReportButton.UseVisualStyleBackColor = true;
            this.loginReportButton.Click += new System.EventHandler(this.loginReportButton_Click);
            // 
            // consultantSchedButton
            // 
            this.consultantSchedButton.Location = new System.Drawing.Point(419, 19);
            this.consultantSchedButton.Name = "consultantSchedButton";
            this.consultantSchedButton.Size = new System.Drawing.Size(200, 30);
            this.consultantSchedButton.TabIndex = 1;
            this.consultantSchedButton.Text = "Consultant Schedule";
            this.consultantSchedButton.UseVisualStyleBackColor = true;
            this.consultantSchedButton.Click += new System.EventHandler(this.consultantSchedButton_Click);
            // 
            // apptMonthButton
            // 
            this.apptMonthButton.Location = new System.Drawing.Point(6, 19);
            this.apptMonthButton.Name = "apptMonthButton";
            this.apptMonthButton.Size = new System.Drawing.Size(200, 30);
            this.apptMonthButton.TabIndex = 0;
            this.apptMonthButton.Text = "Appointments by Month";
            this.apptMonthButton.UseVisualStyleBackColor = true;
            this.apptMonthButton.Click += new System.EventHandler(this.apptMonthButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Appointment Calendar";
            // 
            // weeklyRadio
            // 
            this.weeklyRadio.AutoSize = true;
            this.weeklyRadio.Location = new System.Drawing.Point(349, 162);
            this.weeklyRadio.Name = "weeklyRadio";
            this.weeklyRadio.Size = new System.Drawing.Size(132, 17);
            this.weeklyRadio.TabIndex = 7;
            this.weeklyRadio.TabStop = true;
            this.weeklyRadio.Text = "Weekly Calendar View";
            this.weeklyRadio.UseVisualStyleBackColor = true;
            this.weeklyRadio.CheckedChanged += new System.EventHandler(this.weeklyRadio_CheckedChanged);
            // 
            // monthlyRadio
            // 
            this.monthlyRadio.AutoSize = true;
            this.monthlyRadio.Location = new System.Drawing.Point(622, 162);
            this.monthlyRadio.Name = "monthlyRadio";
            this.monthlyRadio.Size = new System.Drawing.Size(133, 17);
            this.monthlyRadio.TabIndex = 8;
            this.monthlyRadio.TabStop = true;
            this.monthlyRadio.Text = "Monthly Calendar View";
            this.monthlyRadio.UseVisualStyleBackColor = true;
            this.monthlyRadio.CheckedChanged += new System.EventHandler(this.monthlyRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 609);
            this.Controls.Add(this.monthlyRadio);
            this.Controls.Add(this.weeklyRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button createCustButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteApptButton;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.Button createApptButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button loginReportButton;
        private System.Windows.Forms.Button consultantSchedButton;
        private System.Windows.Forms.Button apptMonthButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton weeklyRadio;
        private System.Windows.Forms.RadioButton monthlyRadio;
    }
}