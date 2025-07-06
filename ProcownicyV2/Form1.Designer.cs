namespace ProcownicyV2
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSaveCSV = new Button();
            buttonLoadCSV = new Button();
            buttonExportJson = new Button();
            buttonImportJson = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(601, 363);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(616, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 54);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(616, 77);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 59);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Usuń";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSaveCSV
            // 
            buttonSaveCSV.Location = new Point(12, 381);
            buttonSaveCSV.Name = "buttonSaveCSV";
            buttonSaveCSV.Size = new Size(140, 41);
            buttonSaveCSV.TabIndex = 3;
            buttonSaveCSV.Text = "Zapis do .csv";
            buttonSaveCSV.UseVisualStyleBackColor = true;
            buttonSaveCSV.Click += buttonSaveCSV_Click;
            // 
            // buttonLoadCSV
            // 
            buttonLoadCSV.Location = new Point(158, 381);
            buttonLoadCSV.Name = "buttonLoadCSV";
            buttonLoadCSV.Size = new Size(140, 41);
            buttonLoadCSV.TabIndex = 4;
            buttonLoadCSV.Text = "Odczyt z .csv";
            buttonLoadCSV.UseVisualStyleBackColor = true;
            // 
            // buttonExportJson
            // 
            buttonExportJson.Location = new Point(327, 381);
            buttonExportJson.Name = "buttonExportJson";
            buttonExportJson.Size = new Size(140, 42);
            buttonExportJson.TabIndex = 5;
            buttonExportJson.Text = "Zapis do .json";
            buttonExportJson.UseVisualStyleBackColor = true;
            // 
            // buttonImportJson
            // 
            buttonImportJson.Location = new Point(473, 381);
            buttonImportJson.Name = "buttonImportJson";
            buttonImportJson.Size = new Size(140, 42);
            buttonImportJson.TabIndex = 6;
            buttonImportJson.Text = "Odczyt z .json";
            buttonImportJson.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 426);
            Controls.Add(buttonImportJson);
            Controls.Add(buttonExportJson);
            Controls.Add(buttonLoadCSV);
            Controls.Add(buttonSaveCSV);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSaveCSV;
        private Button buttonLoadCSV;
        private Button buttonExportJson;
        private Button buttonImportJson;
    }
}
