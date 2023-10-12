using ITLab1;
using Newtonsoft.Json.Linq;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Table(object sender, EventArgs e)
        {
            var createForm = new CreateDb();
            createForm.Location = Location;
            createForm.Show();
            Hide();
        }

        private void OpenDatabase(object sender, EventArgs e)
        {
            var path = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Browse Json Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Global.Database = Database.Open(openFileDialog.FileName);
                var databaseWindow = new DatabaseWindow();
                databaseWindow.Location = Location;
                databaseWindow.Show();
                Hide();
            }
        }
    }
}