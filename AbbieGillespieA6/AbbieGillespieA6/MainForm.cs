using System.Drawing;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Text;
using AbbieGillespieA6.Model;

namespace AbbieGillespieA6
{
    public partial class MainForm : Form
    {
        private List<Book>? dataObjects;
        public MainForm()
        {
            InitializeComponent();
            ObjectCountTxtBox.Text = $"Total Objects: 0";
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string jsonData = File.ReadAllText(file);
                dataObjects = JsonSerializer.Deserialize<List<Book>>(jsonData);
                if (dataObjects != null)
                {
                    ObjectCountTxtBox.Text = $"Total Objects: {dataObjects.Count}";
                    ExportDataAsCSVBtn.Enabled = true;
                    ExportDataAsJSONBtn.Enabled = true;
                }
            }
        }

        private void ExportDataAsCSVBtn_Click(object sender, EventArgs e)
        {
            if (dataObjects != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();
                    foreach (Book book in dataObjects)
                    {
                        csv.AppendLine($"{book.Title}, {book.Author}, {book.PageLength}, {book.Genre}, {book.YearPublished}, {book.MSRP},");
                    }

                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                }
            }
        }

        private void ExportDataAsJSONBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON file (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonData = JsonSerializer.Serialize(dataObjects);
                File.WriteAllText(saveFileDialog.FileName, jsonData);
            }
        }
    }
}
