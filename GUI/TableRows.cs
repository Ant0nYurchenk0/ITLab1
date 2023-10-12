namespace GUI
{
    public partial class TableRows : Form
    {
        public TableRows()
        {
            InitializeComponent();
            TableName.Text = Global.Table.Name;
            RowsList.ColumnCount = Global.Table.Columns.Count + 1;
            RowsList.Columns[0].HeaderCell.Value = "Id";
            RowsList.Columns[0].ReadOnly = true;
            for (var i = 0; i < Global.Table.Columns.Count; i++)
            {
                RowsList.Columns[i + 1].HeaderCell.Value = Global.Table.Columns.ElementAt(i).Name;
            }
            RowsList.RowCount = Global.Table.Rows.Count;
            for (var i = 0; i < RowsList.RowCount; i++)
            {
                RowsList.Rows[i].Cells[0].Value = Global.Table.Rows.ElementAt(i).Id;
                for (var j = 0; j < Global.Table.Columns.Count; j++)
                {
                    RowsList.Rows[i].Cells[j + 1].Value = Global.Table.Rows.ElementAt(i).Values[j];
                }
            }
        }

        private void ExitRows(object sender, EventArgs e)
        {
            Global.Table = null;
            var databaseWindow = new DatabaseWindow();
            databaseWindow.Location = Location;
            databaseWindow.Show();
            Hide();
        }

        private void DeleteSelectedRows(object sender, EventArgs e)
        {
            var rowIdObj = RowsList.CurrentRow?.Cells[0].Value;
            if (rowIdObj == null)
            {
                MessageBox.Show("Select row to delete", "Error");
                return;
            }
            try
            {
                var rowId = (int)rowIdObj;
                Global.Table.DeleteRow(rowId);
                Global.Database.Save();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            var tableRowsWindow = new TableRows();
            tableRowsWindow.Location = Location;
            tableRowsWindow.Show();
            Hide();
        }

        private void UpdateRow(object sender, DataGridViewCellEventArgs e)
        {
            var row = RowsList.CurrentRow;
            if (row == null) return;
            var values = new string[row.Cells.Count - 1];
            for (int i = 1; i < row.Cells.Count; i++)
            {
                var value = row.Cells[i]?.Value?.ToString();
                if (value == null) return;
                values[i - 1] = value;
            }
            try
            {
                Global.Table.AddRow((int)row.Cells[0].Value, values);
                Global.Database.Save();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            var tableRowsWindow = new TableRows();
            tableRowsWindow.Location = Location;
            tableRowsWindow.Show();
            Hide();
        }

        private void AddRow(object sender, EventArgs e)
        {

            RowsList.Rows.Add(-1, null);
        }
    }
}
