namespace PresentationLayer
{
    partial class Post
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
            dataIssueLabel = new Label();
            dataIssueField = new TextBox();
            EmployeeLabel = new Label();
            employeeField = new TextBox();
            numberLabel = new Label();
            numberField = new TextBox();
            dateReturnField = new TextBox();
            dateReturnLabel = new Label();
            phoneField = new TextBox();
            phoneLabel = new Label();
            postBtn = new Button();
            employeeNameLabel = new Label();
            employeeNameField = new TextBox();
            SuspendLayout();
            // 
            // dataIssueLabel
            // 
            dataIssueLabel.AutoSize = true;
            dataIssueLabel.Location = new Point(33, 24);
            dataIssueLabel.Name = "dataIssueLabel";
            dataIssueLabel.Size = new Size(202, 15);
            dataIssueLabel.TabIndex = 0;
            dataIssueLabel.Text = "Дата выдачи (гггг-мм-чч чч:мм:сс)";
            // 
            // dataIssueField
            // 
            dataIssueField.Location = new Point(33, 42);
            dataIssueField.Name = "dataIssueField";
            dataIssueField.Size = new Size(202, 23);
            dataIssueField.TabIndex = 1;
            // 
            // EmployeeLabel
            // 
            EmployeeLabel.AutoSize = true;
            EmployeeLabel.Location = new Point(33, 91);
            EmployeeLabel.Name = "EmployeeLabel";
            EmployeeLabel.Size = new Size(58, 15);
            EmployeeLabel.TabIndex = 2;
            EmployeeLabel.Text = "Фамилия";
            // 
            // employeeField
            // 
            employeeField.Location = new Point(33, 109);
            employeeField.Name = "employeeField";
            employeeField.Size = new Size(202, 23);
            employeeField.TabIndex = 3;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(33, 229);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(171, 15);
            numberLabel.TabIndex = 6;
            numberLabel.Text = "Серийный номер накопителя";
            // 
            // numberField
            // 
            numberField.Location = new Point(33, 247);
            numberField.Name = "numberField";
            numberField.Size = new Size(202, 23);
            numberField.TabIndex = 7;
            // 
            // dateReturnField
            // 
            dateReturnField.Location = new Point(33, 313);
            dateReturnField.Name = "dateReturnField";
            dateReturnField.Size = new Size(202, 23);
            dateReturnField.TabIndex = 9;
            // 
            // dateReturnLabel
            // 
            dateReturnLabel.AutoSize = true;
            dateReturnLabel.Location = new Point(33, 295);
            dateReturnLabel.Name = "dateReturnLabel";
            dateReturnLabel.Size = new Size(193, 15);
            dateReturnLabel.TabIndex = 8;
            dateReturnLabel.Text = "Вернуть до (гггг-мм-чч чч:мм:сс)";
            // 
            // phoneField
            // 
            phoneField.Location = new Point(33, 382);
            phoneField.Name = "phoneField";
            phoneField.Size = new Size(202, 23);
            phoneField.TabIndex = 11;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(33, 364);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(101, 15);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Номер телефона";
            // 
            // postBtn
            // 
            postBtn.Location = new Point(91, 455);
            postBtn.Name = "postBtn";
            postBtn.Size = new Size(75, 23);
            postBtn.TabIndex = 12;
            postBtn.Text = "Отправить";
            postBtn.UseVisualStyleBackColor = true;
            postBtn.Click += postBtn_Click;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(33, 159);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(31, 15);
            employeeNameLabel.TabIndex = 13;
            employeeNameLabel.Text = "Имя";
            // 
            // employeeNameField
            // 
            employeeNameField.Location = new Point(33, 177);
            employeeNameField.Name = "employeeNameField";
            employeeNameField.Size = new Size(202, 23);
            employeeNameField.TabIndex = 14;
            // 
            // Post
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 511);
            Controls.Add(employeeNameField);
            Controls.Add(employeeNameLabel);
            Controls.Add(postBtn);
            Controls.Add(phoneField);
            Controls.Add(phoneLabel);
            Controls.Add(dateReturnField);
            Controls.Add(dateReturnLabel);
            Controls.Add(numberField);
            Controls.Add(numberLabel);
            Controls.Add(employeeField);
            Controls.Add(EmployeeLabel);
            Controls.Add(dataIssueField);
            Controls.Add(dataIssueLabel);
            Name = "Post";
            Text = "Post";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataIssueLabel;
        private TextBox dataIssueField;
        private Label EmployeeLabel;
        private TextBox employeeField;
        private Label numberLabel;
        private TextBox numberField;
        private TextBox dateReturnField;
        private Label dateReturnLabel;
        private TextBox phoneField;
        private Label phoneLabel;
        private Button postBtn;
        private Label employeeNameLabel;
        private TextBox employeeNameField;
    }
}