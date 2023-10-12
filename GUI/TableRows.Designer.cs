namespace GUI
{
    partial class TableRows
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
            RowsList = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            TableName = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)RowsList).BeginInit();
            SuspendLayout();
            // 
            // RowsList
            // 
            RowsList.AllowUserToAddRows = false;
            RowsList.AllowUserToDeleteRows = false;
            RowsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RowsList.Location = new Point(12, 49);
            RowsList.Name = "RowsList";
            RowsList.RowTemplate.Height = 25;
            RowsList.Size = new Size(642, 389);
            RowsList.TabIndex = 0;
            RowsList.CellValueChanged += UpdateRow;
            // 
            // button1
            // 
            button1.Location = new Point(713, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ExitRows;
            // 
            // button2
            // 
            button2.Location = new Point(660, 49);
            button2.Name = "button2";
            button2.Size = new Size(97, 40);
            button2.TabIndex = 3;
            button2.Text = "Delete Selected Row";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DeleteSelectedRows;
            // 
            // TableName
            // 
            TableName.AutoSize = true;
            TableName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TableName.Location = new Point(12, 9);
            TableName.Name = "TableName";
            TableName.Size = new Size(63, 25);
            TableName.TabIndex = 4;
            TableName.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(660, 95);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 5;
            button3.Text = "Add row";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddRow;
            // 
            // TableRows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(TableName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RowsList);
            Name = "TableRows";
            StartPosition = FormStartPosition.Manual;
            Text = "TableRows";
            ((System.ComponentModel.ISupportInitialize)RowsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RowsList;
        private Button button1;
        private Button button2;
        private Label TableName;
        private Button button3;
    }
}