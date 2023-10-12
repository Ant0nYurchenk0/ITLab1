using ITLab1;

namespace GUI
{
    public partial class DatabaseWindow : Form
    {
        public DatabaseWindow()
        {
            InitializeComponent();
            DbName.Text = Global.Database.Name;
            TablesList.ColumnCount = 1;
            TablesList.Columns[0].HeaderText = "Table name";
            TablesList.RowCount = Global.Database.Tables.Count;
            for (var i = 0; i < TablesList.RowCount; i++)
            {
                TablesList.Rows[i].Cells[0].Value = Global.Database.Tables.ElementAt(i).Name;
            }
            Table1.DataSource = Global.Database.Tables.Select(t=>t.Name).ToList();
            Table2.DataSource = Global.Database.Tables.Select(t=>t.Name).ToList();
        }

        private void CreateTable(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TableName.Text.Trim()))
            {
                MessageBox.Show("You must specify the name first", "Error");
                return;
            }
            try
            {
                Global.Database.AddTable(TableName.Text.Trim());
                Global.Database.Save();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            var newDbWindow = new DatabaseWindow();
            newDbWindow.Location = Location;
            newDbWindow.Show();
            Hide();
        }

        private void DisconnectDb(object sender, EventArgs e)
        {
            Global.Database.Save();
            Global.Database = null;
            Global.Table = null;
            var startWindow = new Form1();
            startWindow.Location = Location;
            startWindow.Show();
            Hide();
        }

        private void TablesList_DoubleClick(object sender, EventArgs e)
        {
            var table = Global.Database.Tables.SingleOrDefault(t => t.Name == (string)TablesList.CurrentCell.Value);
            if (table != null)
            {
                Global.Table = table;
                var tableColumnsWindow = new TableColumns();
                tableColumnsWindow.Location = Location;
                tableColumnsWindow.Show();
                Hide();
            }
        }
        private void DeleteTable(object sender, EventArgs e)
        {
            var tableName = TablesList.CurrentCell?.Value.ToString();
            if (tableName == null)
            {
                MessageBox.Show("Select table to delete", "Error");
                return;
            }
            try
            {
                Global.Database.DeleteTable(tableName);
                Global.Table = null;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            var databaseWindow = new DatabaseWindow();
            databaseWindow.Location = Location;
            databaseWindow.Show();
            Hide();
        }

        private void Intersect(object sender, EventArgs e)
        {
            var table1 = Global.Database.Tables.SingleOrDefault(t=>t.Name == Table1.Text);
            var table2 = Global.Database.Tables.SingleOrDefault(t=>t.Name == Table2.Text);
            Global.Table = Table.Intersect(table1, table2);
            var tableRows = new TableRows();
            tableRows.Location = Location;
            tableRows.Show();
            Hide();
        }
    }
}
