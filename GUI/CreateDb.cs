using ITLab1;

namespace GUI
{
    public partial class CreateDb : Form
    {
        public CreateDb()
        {
            InitializeComponent();
        }

        private void SaveDatabase(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DbNameTBox.Text.Trim()))
            {
                MessageBox.Show("You must specify the name first", "Error");
                return;
            }
            var saveFileDialog = new SaveFileDialog()
            {
                Title = "Save database",
                CheckPathExists = true,
                DefaultExt = "json",
                Filter = "Json files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                FileName = DbNameTBox.Text.Trim()

            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Global.Database = new Database(DbNameTBox.Text, saveFileDialog.FileName);
                var databaseWindow = new DatabaseWindow();
                databaseWindow.Location = Location;
                databaseWindow.Show();
                Hide();
            }
        }
    }
}
