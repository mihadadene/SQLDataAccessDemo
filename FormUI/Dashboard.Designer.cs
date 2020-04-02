namespace FormUI
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailAddressInsLabel = new System.Windows.Forms.Label();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.selectAllPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 29;
            this.peopleFoundListBox.Location = new System.Drawing.Point(14, 84);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(530, 236);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(160, 26);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(184, 34);
            this.lastNameText.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(23, 26);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(385, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(158, 36);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(12, 340);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(137, 29);
            this.firstNameInsLabel.TabIndex = 7;
            this.firstNameInsLabel.Text = "First Name:";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(191, 335);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(183, 34);
            this.firstNameInsText.TabIndex = 6;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(12, 379);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(134, 29);
            this.lastNameInsLabel.TabIndex = 9;
            this.lastNameInsLabel.Text = "Last Name:";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(191, 373);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(183, 34);
            this.lastNameInsText.TabIndex = 8;
            // 
            // emailAddressInsLabel
            // 
            this.emailAddressInsLabel.AutoSize = true;
            this.emailAddressInsLabel.Location = new System.Drawing.Point(12, 417);
            this.emailAddressInsLabel.Name = "emailAddressInsLabel";
            this.emailAddressInsLabel.Size = new System.Drawing.Size(169, 29);
            this.emailAddressInsLabel.TabIndex = 11;
            this.emailAddressInsLabel.Text = "EmailAddress:";
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Location = new System.Drawing.Point(191, 412);
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(183, 34);
            this.emailAddressInsText.TabIndex = 10;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(9, 458);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(176, 29);
            this.phoneNumberInsLabel.TabIndex = 13;
            this.phoneNumberInsLabel.Text = "PhoneNumber:";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(191, 458);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(183, 34);
            this.phoneNumberInsText.TabIndex = 12;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(385, 371);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(159, 36);
            this.insertRecordButton.TabIndex = 14;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Location = new System.Drawing.Point(385, 413);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(159, 36);
            this.deleteRecordButton.TabIndex = 15;
            this.deleteRecordButton.Text = "Delete";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // selectAllPerson
            // 
            this.selectAllPerson.Location = new System.Drawing.Point(385, 458);
            this.selectAllPerson.Name = "selectAllPerson";
            this.selectAllPerson.Size = new System.Drawing.Size(159, 36);
            this.selectAllPerson.TabIndex = 17;
            this.selectAllPerson.Text = "Get All";
            this.selectAllPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectAllPerson.UseVisualStyleBackColor = true;
            this.selectAllPerson.Click += new System.EventHandler(this.selectAllPerson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 524);
            this.Controls.Add(this.selectAllPerson);
            this.Controls.Add(this.deleteRecordButton);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.emailAddressInsLabel);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label emailAddressInsLabel;
        private System.Windows.Forms.TextBox emailAddressInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button selectAllPerson;
    }
}

