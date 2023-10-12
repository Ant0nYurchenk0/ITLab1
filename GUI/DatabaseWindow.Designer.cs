namespace GUI
{
    partial class DatabaseWindow
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
            DbName = new Label();
            TablesList = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            TableName = new TextBox();
            Disconnect = new Button();
            button2 = new Button();
            Table1 = new ComboBox();
            Table2 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)TablesList).BeginInit();
            SuspendLayout();
            // 
            // DbName
            // 
            DbName.AutoSize = true;
            DbName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DbName.Location = new Point(24, 23);
            DbName.Name = "DbName";
            DbName.Size = new Size(63, 25);
            DbName.TabIndex = 0;
            DbName.Text = "label1";
            // 
            // TablesList
            // 
            TablesList.AllowUserToAddRows = false;
            TablesList.AllowUserToDeleteRows = false;
            TablesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablesList.Location = new Point(24, 56);
            TablesList.Name = "TablesList";
            TablesList.ReadOnly = true;
            TablesList.RowTemplate.Height = 25;
            TablesList.Size = new Size(209, 382);
            TablesList.TabIndex = 1;
            TablesList.DoubleClick += TablesList_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(449, 210);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateTable;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 120);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Create table";
            // 
            // TableName
            // 
            TableName.Location = new Point(449, 162);
            TableName.Name = "TableName";
            TableName.Size = new Size(100, 23);
            TableName.TabIndex = 4;
            // 
            // Disconnect
            // 
            Disconnect.Location = new Point(687, 27);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(75, 23);
            Disconnect.TabIndex = 5;
            Disconnect.Text = "Disconnect";
            Disconnect.UseVisualStyleBackColor = true;
            Disconnect.Click += DisconnectDb;
            // 
            // button2
            // 
            button2.Location = new Point(239, 56);
            button2.Name = "button2";
            button2.Size = new Size(101, 44);
            button2.TabIndex = 6;
            button2.Text = "Delete Selected Table";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DeleteTable;
            // 
            // Table1
            // 
            Table1.FormattingEnabled = true;
            Table1.Location = new Point(300, 367);
            Table1.Name = "Table1";
            Table1.Size = new Size(121, 23);
            Table1.TabIndex = 7;
            // 
            // Table2
            // 
            Table2.FormattingEnabled = true;
            Table2.Location = new Point(449, 367);
            Table2.Name = "Table2";
            Table2.Size = new Size(121, 23);
            Table2.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(613, 366);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Intersect";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Intersect;
            // 
            // DatabaseWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(Table2);
            Controls.Add(Table1);
            Controls.Add(button2);
            Controls.Add(Disconnect);
            Controls.Add(TableName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(TablesList);
            Controls.Add(DbName);
            Name = "DatabaseWindow";
            StartPosition = FormStartPosition.Manual;
            Text = "DatabaseWindow";
            ((System.ComponentModel.ISupportInitialize)TablesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DbName;
        private DataGridView TablesList;
        private Button button1;
        private Label label1;
        private TextBox TableName;
        private Button Disconnect;
        private Button button2;
        private ComboBox Table1;
        private ComboBox Table2;
        private Button button3;
    }
}