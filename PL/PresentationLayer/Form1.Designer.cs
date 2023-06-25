namespace PresentationLayer
{
    partial class Form1
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
            toPostButton = new Button();
            toPutButton = new Button();
            toReportButton = new Button();
            editDepartment = new Button();
            panel1 = new Panel();
            label1 = new Label();
            editDrivers = new Button();
            editEmployees = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toPostButton
            // 
            toPostButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toPostButton.Location = new Point(26, 33);
            toPostButton.Name = "toPostButton";
            toPostButton.Size = new Size(243, 63);
            toPostButton.TabIndex = 0;
            toPostButton.Text = "Выдать накопитель";
            toPostButton.UseVisualStyleBackColor = true;
            toPostButton.Click += toPostButton_Click;
            // 
            // toPutButton
            // 
            toPutButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toPutButton.Location = new Point(26, 115);
            toPutButton.Name = "toPutButton";
            toPutButton.Size = new Size(243, 62);
            toPutButton.TabIndex = 1;
            toPutButton.Text = "Принять накопитель";
            toPutButton.UseVisualStyleBackColor = true;
            toPutButton.Click += toPutButton_Click;
            // 
            // toReportButton
            // 
            toReportButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toReportButton.Location = new Point(26, 345);
            toReportButton.Name = "toReportButton";
            toReportButton.Size = new Size(243, 53);
            toReportButton.TabIndex = 2;
            toReportButton.Text = "Построить отчет";
            toReportButton.UseVisualStyleBackColor = true;
            toReportButton.Click += toReportButton_Click;
            // 
            // editDepartment
            // 
            editDepartment.Anchor = AnchorStyles.None;
            editDepartment.Location = new Point(363, 67);
            editDepartment.Name = "editDepartment";
            editDepartment.Size = new Size(147, 44);
            editDepartment.TabIndex = 3;
            editDepartment.Text = "Подразделения";
            editDepartment.UseVisualStyleBackColor = true;
            editDepartment.Click += editDepartment_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(toPostButton);
            panel1.Controls.Add(toReportButton);
            panel1.Controls.Add(toPutButton);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 411);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(363, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Изменить:";
            // 
            // editDrivers
            // 
            editDrivers.Location = new Point(363, 117);
            editDrivers.MaximumSize = new Size(147, 44);
            editDrivers.MinimumSize = new Size(147, 44);
            editDrivers.Name = "editDrivers";
            editDrivers.Size = new Size(147, 44);
            editDrivers.TabIndex = 6;
            editDrivers.Text = "Накопители";
            editDrivers.UseVisualStyleBackColor = true;
            editDrivers.Click += editDrivers_Click;
            // 
            // editEmployees
            // 
            editEmployees.Location = new Point(363, 167);
            editEmployees.Name = "editEmployees";
            editEmployees.Size = new Size(147, 44);
            editEmployees.TabIndex = 7;
            editEmployees.Text = "Сотрудники";
            editEmployees.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 463);
            Controls.Add(editEmployees);
            Controls.Add(editDrivers);
            Controls.Add(label1);
            Controls.Add(editDepartment);
            Controls.Add(panel1);
            MaximumSize = new Size(552, 502);
            MinimumSize = new Size(552, 502);
            Name = "Form1";
            Text = "Главное меню";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toPostButton;
        private Button toPutButton;
        private Button toReportButton;
        private Button editDepartment;
        private Panel panel1;
        private Label label1;
        private Button editDrivers;
        private Button editEmployees;
    }
}