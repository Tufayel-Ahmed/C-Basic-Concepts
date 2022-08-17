namespace HelloWorldApp
{
    partial class HelloAppUI
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
            this.showFullNameBtn = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showFullNameBtn
            // 
            this.showFullNameBtn.Location = new System.Drawing.Point(202, 200);
            this.showFullNameBtn.Name = "showFullNameBtn";
            this.showFullNameBtn.Size = new System.Drawing.Size(75, 23);
            this.showFullNameBtn.TabIndex = 3;
            this.showFullNameBtn.Text = "Show Full Name";
            this.showFullNameBtn.UseVisualStyleBackColor = true;
            this.showFullNameBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(186, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(56, 68);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Enter Your First Name:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(55, 115);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(125, 13);
            this.middleNameLabel.TabIndex = 4;
            this.middleNameLabel.Text = "Enter Your Middle Name:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(186, 112);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(55, 160);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(114, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Enter Your Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(186, 153);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(55, 261);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 8;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(186, 254);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // HelloAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.showFullNameBtn);
            this.Name = "HelloAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showFullNameBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}

