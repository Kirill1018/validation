namespace Validation
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
            components = new System.ComponentModel.Container();
            dateOfWorkStart = new Label();
            dateOfWorkEnd = new Label();
            dayCost = new Label();
            workCost = new Label();
            startDate = new TextBox();
            endDate = new TextBox();
            cost = new TextBox();
            value = new Label();
            tipOfDateOfWorkStart = new ToolTip(components);
            tipOfDateOfWorkEnd = new ToolTip(components);
            tipOfDayCost = new ToolTip(components);
            calculation = new Button();
            mail = new Label();
            mailBox = new TextBox();
            entrance = new Button();
            SuspendLayout();
            // 
            // dateOfWorkStart
            // 
            dateOfWorkStart.AutoSize = true;
            dateOfWorkStart.Location = new Point(12, 9);
            dateOfWorkStart.Name = "dateOfWorkStart";
            dateOfWorkStart.Size = new Size(107, 15);
            dateOfWorkStart.TabIndex = 0;
            dateOfWorkStart.Text = "дата начала работ";
            // 
            // dateOfWorkEnd
            // 
            dateOfWorkEnd.AutoSize = true;
            dateOfWorkEnd.Location = new Point(12, 38);
            dateOfWorkEnd.Name = "dateOfWorkEnd";
            dateOfWorkEnd.Size = new Size(128, 15);
            dateOfWorkEnd.TabIndex = 1;
            dateOfWorkEnd.Text = "дата окончания работ";
            // 
            // dayCost
            // 
            dayCost.AutoSize = true;
            dayCost.Location = new Point(11, 67);
            dayCost.Name = "dayCost";
            dayCost.Size = new Size(129, 15);
            dayCost.TabIndex = 2;
            dayCost.Text = "стоимость одного дня";
            // 
            // workCost
            // 
            workCost.AutoSize = true;
            workCost.Location = new Point(12, 144);
            workCost.Name = "workCost";
            workCost.Size = new Size(100, 15);
            workCost.TabIndex = 3;
            workCost.Text = "стоимость работ";
            // 
            // startDate
            // 
            startDate.Location = new Point(146, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(100, 23);
            startDate.TabIndex = 4;
            // 
            // endDate
            // 
            endDate.Location = new Point(146, 30);
            endDate.Name = "endDate";
            endDate.Size = new Size(100, 23);
            endDate.TabIndex = 5;
            // 
            // cost
            // 
            cost.Location = new Point(146, 59);
            cost.Name = "cost";
            cost.Size = new Size(100, 23);
            cost.TabIndex = 6;
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(146, 144);
            value.Name = "value";
            value.Size = new Size(0, 15);
            value.TabIndex = 7;
            // 
            // calculation
            // 
            calculation.Location = new Point(12, 162);
            calculation.Name = "calculation";
            calculation.Size = new Size(75, 23);
            calculation.TabIndex = 8;
            calculation.Text = "расчёт";
            calculation.UseVisualStyleBackColor = true;
            calculation.Click += calculation_Click;
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Location = new Point(12, 198);
            mail.Name = "mail";
            mail.Size = new Size(151, 15);
            mail.TabIndex = 9;
            mail.Text = "адрес электронной почты";
            // 
            // mailBox
            // 
            mailBox.Location = new Point(169, 190);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(100, 23);
            mailBox.TabIndex = 10;
            // 
            // entrance
            // 
            entrance.Location = new Point(12, 216);
            entrance.Name = "entrance";
            entrance.Size = new Size(75, 23);
            entrance.TabIndex = 11;
            entrance.Text = "вход";
            entrance.UseVisualStyleBackColor = true;
            entrance.Click += entrance_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(entrance);
            Controls.Add(mailBox);
            Controls.Add(mail);
            Controls.Add(calculation);
            Controls.Add(value);
            Controls.Add(cost);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(workCost);
            Controls.Add(dayCost);
            Controls.Add(dateOfWorkEnd);
            Controls.Add(dateOfWorkStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateOfWorkStart;
        private Label dateOfWorkEnd;
        private Label dayCost;
        private Label workCost;
        private TextBox startDate;
        private TextBox endDate;
        private TextBox cost;
        private Label value;
        private ToolTip tipOfDateOfWorkStart;
        private ToolTip tipOfDateOfWorkEnd;
        private ToolTip tipOfDayCost;
        private Button calculation;
        private Label mail;
        private TextBox mailBox;
        private Button entrance;
    }
}
