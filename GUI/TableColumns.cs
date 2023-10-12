using ITLab1;

namespace GUI
{
    public partial class TableColumns : Form
    {
        public TableColumns()
        {
            InitializeComponent();
            TableName.Text = Global.Table.Name;
            ColumnsList.ColumnCount = 2;
            ColumnsList.Columns[0].HeaderText = "Column name";
            ColumnsList.Columns[1].HeaderText = "Data Type";
            ColumnsList.RowCount = Global.Table.Columns.Count;
            for (var i = 0; i < ColumnsList.RowCount; i++)
            {
                ColumnsList.Rows[i].Cells[0].Value = Global.Table.Columns.ElementAt(i).Name;
                ColumnsList.Rows[i].Cells[1].Value = Global.Table.Columns.ElementAt(i).Type;
            }
            DatatypeSelector.DataSource = Enum.GetValues(typeof(Types));
        }

        private void CreateColumn(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ColumnNameTBox.Text.Trim()) || DatatypeSelector.SelectedIndex < 0)
            {
                MessageBox.Show("You must specify the name and select a data type first", "Error");
                return;
            }
            try
            {
                Global.Table.AddColumn(ColumnNameTBox.Text.Trim(), (Types)DatatypeSelector.SelectedIndex);
                Global.Database.Save();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            var tableWindow = new TableColumns();
            tableWindow.Location = Location;
            tableWindow.Show();
            Hide();
        }

        private void DeleteColumn(object sender, EventArgs e)
        {
            var columnName = ColumnsList.CurrentRow?.Cells[0].Value.ToString();
            if (columnName == null)
            {
                MessageBox.Show("Select column to delete", "Error");
                return;
            }
            try
            {
                Global.Table.DeleteColumn(columnName);
                Global.Database.Save();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            var tableColumnsWindow = new TableColumns();
            tableColumnsWindow.Location = Location;
            tableColumnsWindow.Show();
            Hide();
        }

        private void ExitEditor_Click(object sender, EventArgs e)
        {
            Global.Table = null;
            var databaseWindow = new DatabaseWindow();
            databaseWindow.Location = Location;
            databaseWindow.Show();
            Hide();
        }

        private void ShowRows(object sender, EventArgs e)
        {
            var rowsWindow = new TableRows();
            rowsWindow.Location = Location;
            rowsWindow.Show();
            Hide();
        }


    }
}
