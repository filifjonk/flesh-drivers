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
            SuspendLayout();
            // 
            // toPostButton
            // 
            toPostButton.Location = new Point(307, 94);
            toPostButton.Name = "toPostButton";
            toPostButton.Size = new Size(150, 42);
            toPostButton.TabIndex = 0;
            toPostButton.Text = "Выдать накопитель";
            toPostButton.UseVisualStyleBackColor = true;
            toPostButton.Click += toPostButton_Click;
            // 
            // toPutButton
            // 
            toPutButton.Location = new Point(307, 160);
            toPutButton.Name = "toPutButton";
            toPutButton.Size = new Size(150, 42);
            toPutButton.TabIndex = 1;
            toPutButton.Text = "Принять накопитель";
            toPutButton.UseVisualStyleBackColor = true;
            toPutButton.Click += toPutButton_Click;
            // 
            // toReportButton
            // 
            toReportButton.Location = new Point(307, 307);
            toReportButton.Name = "toReportButton";
            toReportButton.Size = new Size(150, 42);
            toReportButton.TabIndex = 2;
            toReportButton.Text = "Построить отчет";
            toReportButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toReportButton);
            Controls.Add(toPutButton);
            Controls.Add(toPostButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button toPostButton;
        private Button toPutButton;
        private Button toReportButton;
    }
}