
namespace lab4
{
    partial class formContactTracer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.headerContacted = new System.Windows.Forms.ColumnHeader();
            this.headerFirst = new System.Windows.Forms.ColumnHeader();
            this.headerLast = new System.Windows.Forms.ColumnHeader();
            this.headerDate = new System.Windows.Forms.ColumnHeader();
            this.headerEmail = new System.Windows.Forms.ColumnHeader();
            this.headerPhone = new System.Windows.Forms.ColumnHeader();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelContacted = new System.Windows.Forms.Label();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listViewEntries
            // 
            this.listViewEntries.CheckBoxes = true;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerContacted,
            this.headerFirst,
            this.headerLast,
            this.headerDate,
            this.headerEmail,
            this.headerPhone});
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntries.HideSelection = false;
            this.listViewEntries.Location = new System.Drawing.Point(12, 164);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(484, 169);
            this.listViewEntries.TabIndex = 0;
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewEntries.SelectedIndexChanged += new System.EventHandler(this.ContactSelected);
            // 
            // headerContacted
            // 
            this.headerContacted.Text = "Contacted";
            // 
            // headerFirst
            // 
            this.headerFirst.Text = "First Name";
            this.headerFirst.Width = 85;
            // 
            // headerLast
            // 
            this.headerLast.Text = "Last Name";
            this.headerLast.Width = 85;
            // 
            // headerDate
            // 
            this.headerDate.Text = "Date";
            this.headerDate.Width = 80;
            // 
            // headerEmail
            // 
            this.headerEmail.Text = "Email Address";
            this.headerEmail.Width = 80;
            // 
            // headerPhone
            // 
            this.headerPhone.Text = "Phone #";
            this.headerPhone.Width = 75;
            // 
            // labelFirst
            // 
            this.labelFirst.Location = new System.Drawing.Point(104, 12);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(83, 20);
            this.labelFirst.TabIndex = 1;
            this.labelFirst.Text = "&First Name:";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLast
            // 
            this.labelLast.Location = new System.Drawing.Point(104, 45);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(82, 20);
            this.labelLast.TabIndex = 2;
            this.labelLast.Text = "&Last Name:";
            this.labelLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(81, 78);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(106, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email &Address:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(76, 111);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(111, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "&Phone Number:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelContacted
            // 
            this.labelContacted.Location = new System.Drawing.Point(100, 141);
            this.labelContacted.Name = "labelContacted";
            this.labelContacted.Size = new System.Drawing.Size(87, 20);
            this.labelContacted.TabIndex = 5;
            this.labelContacted.Text = "&Contacted?:";
            this.labelContacted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.AutoSize = true;
            this.checkBoxContacted.Location = new System.Drawing.Point(193, 141);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxContacted.TabIndex = 11;
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Check if the customer has been contacted");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(193, 9);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(184, 27);
            this.textBoxFirst.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxFirst, "Enter the customers first name");
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(193, 42);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(184, 27);
            this.textBoxLast.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxLast, "Enter the customers last name");
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(193, 75);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(184, 27);
            this.textBoxEmail.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxEmail, "Enter the customers email address");
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(193, 108);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(184, 27);
            this.textBoxPhone.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxPhone, "Enter the customers phone number");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(202, 459);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Enters all data in the form");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(302, 459);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Resets all the entry textboxes in the form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(402, 459);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Closes the form");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 339);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(484, 114);
            this.textBoxOutput.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBoxOutput, "Displays errors, successful additions and modifications to the list");
            // 
            // formContactTracer
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(508, 500);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.labelContacted);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.listViewEntries);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.ColumnHeader headerContacted;
        private System.Windows.Forms.ColumnHeader headerFirst;
        private System.Windows.Forms.ColumnHeader headerLast;
        private System.Windows.Forms.ColumnHeader headerDate;
        private System.Windows.Forms.ColumnHeader headerEmail;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelContacted;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ColumnHeader headerPhone;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

