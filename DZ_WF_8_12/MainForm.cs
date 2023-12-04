using System.Windows.Forms;

namespace DZ_WF_8_12
{
    public partial class MainForm : Form
    {
        private string mapPath;
        private readonly string fileExtension = ".txt";
        private List<string> maps;
        private int[,] map2d;

        public MainForm()
        {
            InitializeComponent();
            maps = new List<string>();
            LoadMaps();
            InitializeUI();
        }

        private void InitializeUI()
        {
            Load += (s, e) =>
            {
                startButton.Enabled = false;
                InitMapSelection();
                mapSelectionComboBox.SelectedIndexChanged += MapSelectionComboBox_SelectedIndexChanged;
                startButton.Click += (s, e) =>
                {
                    GameForm gameForm = new GameForm(map2d);
                    gameForm.ShowDialog(this);
                };
            };
        }

        private void MapSelectionComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (mapSelectionComboBox.SelectedItem != null)
            {
                string selectedMapName = mapSelectionComboBox.SelectedItem.ToString();
                string filePath = Path.Combine(mapPath, selectedMapName + fileExtension);

                try
                {
                    LoadMapFromFile(filePath);
                    DisplayMap();
                    EnableStartButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadMapFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            map2d = new int[lines.Length, lines[0].Length];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    map2d[i, j] = lines[i][j] == '█' ? 1 : 0;
                }
            }
        }

        private void DisplayMap()
        {
            int rows = map2d.GetLength(0);
            int cols = map2d.GetLength(1);
            int cellWidth = mapPictureBox.Width / cols;
            int cellHeight = mapPictureBox.Height / rows;

            Bitmap mapImage = new Bitmap(mapPictureBox.Width, mapPictureBox.Height);

            using (Graphics g = Graphics.FromImage(mapImage))
            {
                g.Clear(Color.Gray);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Brush brush = map2d[i, j] == 1 ? Brushes.Gray : Brushes.Chartreuse;
                        g.FillRectangle(brush, j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    }
                }
            }
            mapPictureBox.Image = mapImage;
        }

        private void InitMapSelection()
        {
            foreach (string map in maps)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(map);
                mapSelectionComboBox.Items.Add(fileNameWithoutExtension);
            }
        }

        private void EnableStartButton()
        {
            startButton.Enabled = true;
            startButton.Text = "Старт гри";
        }

        private void LoadMaps()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Оберіть папку розташування карт";
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    mapPath = folderBrowserDialog.SelectedPath;
                    string[] files = Directory.GetFiles(mapPath, "*.txt");

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        maps.Add(fileName);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid folder selection. The application will close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
