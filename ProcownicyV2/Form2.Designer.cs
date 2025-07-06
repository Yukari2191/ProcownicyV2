namespace ProcownicyV2
{
    partial class AddEmployeeForm
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
            textFirstName = new TextBox();
            textLastName = new TextBox();
            textAge = new TextBox();
            comboBoxPosition = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(12, 12);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(191, 31);
            textFirstName.TabIndex = 0;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(11, 49);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(192, 31);
            textLastName.TabIndex = 1;
            // 
            // textAge
            // 
            textAge.Location = new Point(11, 86);
            textAge.Name = "textAge";
            textAge.Size = new Size(190, 31);
            textAge.TabIndex = 2;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Asystent", "Specjalista ds. marketingu", "Kierownik projektu", "Inżynier opragramowania", "Księgowy", "Kierowca", "Tester", "Sprzedawca" });
            comboBoxPosition.Location = new Point(11, 125);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(190, 33);
            comboBoxPosition.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 4;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 52);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 89);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 6;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 128);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Stanowisko";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(12, 178);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(158, 36);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Zatwierdż";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(179, 178);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(159, 36);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 225);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxPosition);
            Controls.Add(textAge);
            Controls.Add(textLastName);
            Controls.Add(textFirstName);
            Name = "AddEmployeeForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFirstName;
        private TextBox textLastName;
        private TextBox textAge;
        private ComboBox comboBoxPosition;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}