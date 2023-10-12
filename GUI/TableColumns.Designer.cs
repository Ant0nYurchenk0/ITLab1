namespace GUI
{
    partial class TableColumns
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
            Delete = new Button();
            ColumnNameTBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ColumnsList = new DataGridView();
            DatatypeSelector = new ComboBox();
            TableName = new Label();
            ExitEditor = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ColumnsList).BeginInit();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new Point(336, 51);
            Delete.Name = "Delete";
            Delete.Size = new Size(107, 44);
            Delete.TabIndex = 11;
            Delete.Text = "Delete selected column";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += DeleteColumn;
            // 
            // ColumnNameTBox
            // 
            ColumnNameTBox.Location = new Point(456, 157);
            ColumnNameTBox.Name = "ColumnNameTBox";
            ColumnNameTBox.Size = new Size(100, 23);
            ColumnNameTBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(456, 115);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 9;
            label1.Text = "Create column";
            // 
            // button1
            // 
            button1.Location = new Point(456, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateColumn;
            // 
            // ColumnsList
            // 
            ColumnsList.AllowUserToAddRows = false;
            ColumnsList.AllowUserToDeleteRows = false;
            ColumnsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColumnsList.Location = new Point(31, 51);
            ColumnsList.Name = "ColumnsList";
            ColumnsList.ReadOnly = true;
            ColumnsList.RowTemplate.Height = 25;
            ColumnsList.Size = new Size(299, 382);
            ColumnsList.TabIndex = 7;
            // 
            // DatatypeSelector
            // 
            DatatypeSelector.FormattingEnabled = true;
            DatatypeSelector.Location = new Point(456, 205);
            DatatypeSelector.Name = "DatatypeSelector";
            DatatypeSelector.Size = new Size(100, 23);
            DatatypeSelector.TabIndex = 12;
            // 
            // TableName
            // 
            TableName.AutoSize = true;
            TableName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TableName.Location = new Point(31, 16);
            TableName.Name = "TableName";
            TableName.Size = new Size(63, 25);
            TableName.TabIndex = 13;
            TableName.Text = "label2";
            // 
            // ExitEditor
            // 
            ExitEditor.Location = new Point(713, 18);
            ExitEditor.Name = "ExitEditor";
            ExitEditor.Size = new Size(75, 23);
            ExitEditor.TabIndex = 14;
            ExitEditor.Text = "Exit";
            ExitEditor.UseVisualStyleBackColor = true;
            ExitEditor.Click += ExitEditor_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 18);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Show Rows";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ShowRows;
            // 
            // TableColumns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(ExitEditor);
            Controls.Add(TableName);
            Controls.Add(DatatypeSelector);
            Controls.Add(Delete);
            Controls.Add(ColumnNameTBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ColumnsList);
            Name = "TableColumns";
            StartPosition = FormStartPosition.Manual;
            Text = "TableColumns";
            ((System.ComponentModel.ISupportInitialize)ColumnsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete;
        private TextBox ColumnNameTBox;
        private Label label1;
        private Button button1;
        private DataGridView ColumnsList;
        private ComboBox DatatypeSelector;
        private Label TableName;
        private Button ExitEditor;
        private Button button2;
    }
}