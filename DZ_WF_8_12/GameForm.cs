using Microsoft.VisualBasic.Devices;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DZ_WF_8_12
{
    public partial class GameForm : Form
    {
        private int[,] map2d;
        private int rows;
        private int cols;
        private int playerPosX;
        private int playerPosY;
        public GameForm(int[,] map2d)
        {
            this.map2d = map2d;
            rows = map2d.GetLength(0);
            cols = map2d.GetLength(1);
            playerPosX = rows / 2;
            playerPosY = cols / 2;

            Load += (s, e) =>
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                MaximizeBox = false;

                Paint += GameForm_Paint;
                KeyDown += GameForm_KeyDown;

                DoubleBuffered = true;
            };

            InitializeComponent();
        }
        private void GameForm_KeyDown(object? sender, KeyEventArgs e)
        {
            int x = playerPosX, y = playerPosY;

            if (e.KeyCode == Keys.Up)
            {
                y = playerPosY - 1;
            }
            else if (e.KeyCode == Keys.Down)
            {
                y = playerPosY + 1;
            }
            else if (e.KeyCode == Keys.Left)
            {
                x = playerPosX - 1;
            }
            else if (e.KeyCode == Keys.Right)
            {
                x = playerPosX + 1;
            }

            if (x != playerPosX || y != playerPosY)
            {
                if (x < cols && y < rows && map2d[y, x] == 0)
                {
                    playerPosX = x; playerPosY = y;
                    Invalidate();

                    if (playerPosX == cols - 1 || playerPosY == rows - 1 || playerPosX == 0 || playerPosY == 0)
                    {
                        MessageBox.Show("Перемога!");
                        Close();
                    }
                }
            }
        }
        private void GameForm_Paint(object? sender, PaintEventArgs e)
        {
            ClientSize = new Size(rows * cols, rows * cols);

            Graphics g = e.Graphics;

            for (int i = 0; i < map2d.GetLength(0); ++i)
            {
                for (int j = 0; j < map2d.GetLength(1); j++)
                {
                    Brush brush = map2d[i, j] == 1 ? Brushes.Gray : Brushes.Chartreuse;
                    g.FillRectangle(brush, j * cols, i * rows, rows, cols);
                }
            }
            g.FillEllipse(Brushes.Crimson, playerPosX * rows, playerPosY * cols, rows, cols);
        }
    }
}