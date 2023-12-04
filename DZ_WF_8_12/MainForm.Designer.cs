namespace DZ_WF_8_12
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mapSelectionComboBox = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            startButton = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            mapPictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mapPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mapSelectionComboBox
            // 
            mapSelectionComboBox.BackColor = Color.Chartreuse;
            mapSelectionComboBox.Dock = DockStyle.Bottom;
            mapSelectionComboBox.FlatStyle = FlatStyle.Flat;
            mapSelectionComboBox.ForeColor = Color.Gray;
            mapSelectionComboBox.FormattingEnabled = true;
            mapSelectionComboBox.Location = new Point(0, 67);
            mapSelectionComboBox.Name = "mapSelectionComboBox";
            mapSelectionComboBox.RightToLeft = RightToLeft.No;
            mapSelectionComboBox.Size = new Size(370, 28);
            mapSelectionComboBox.TabIndex = 1;
            mapSelectionComboBox.Text = "Оберіть карту";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 150);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(mapSelectionComboBox);
            panel2.Location = new Point(25, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 95);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(startButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 80);
            panel3.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Bottom;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.ForeColor = Color.Gold;
            startButton.Location = new Point(0, 0);
            startButton.Name = "startButton";
            startButton.Size = new Size(425, 80);
            startButton.TabIndex = 0;
            startButton.Text = "Старт гри";
            startButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 211);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(mapPictureBox);
            panel5.Location = new Point(112, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 200);
            panel5.TabIndex = 0;
            // 
            // mapPictureBox
            // 
            mapPictureBox.Dock = DockStyle.Fill;
            mapPictureBox.Location = new Point(0, 0);
            mapPictureBox.Name = "mapPictureBox";
            mapPictureBox.Size = new Size(200, 200);
            mapPictureBox.TabIndex = 0;
            mapPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(425, 441);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Chartreuse;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            Opacity = 0.98D;
            Text = "The Maze Game";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mapPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox mapSelectionComboBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button startButton;
        private Panel panel4;
        private Panel panel5;
        private PictureBox mapPictureBox;
    }
}
