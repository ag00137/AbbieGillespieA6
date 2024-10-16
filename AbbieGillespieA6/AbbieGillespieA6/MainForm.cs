using System.Drawing;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;

namespace AbbieGillespieA6
{
    public partial class MainForm : Form
    {
        private List<Object>? dataObjects;
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
                dataObjects = JsonSerializer.Deserialize<List<Object>>(jsonData);
                if (dataObjects != null)
                {
                    ObjectCountTxtBox.Text = $"Total Objects: {dataObjects.Count}";
                }                
            }
        }
    }
}
