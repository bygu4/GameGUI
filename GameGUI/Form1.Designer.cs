namespace GameGUI
{
    partial class Form1
    {
        private const int WallSize = 20;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        private void DrawWall(
            int x, int y, int size, System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle wall = new Rectangle(x, y, WallSize, WallSize);
            
        }

        private void DrawMap(
            string fileName, System.Windows.Forms.PaintEventArgs e)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                int x = 0;
                int y = 0;
                while (!reader.EndOfStream)
                {
                    char next = (char)reader.Read();
                    if (next == '\n')
                    {
                        x = 0;
                        y += WallSize
;
                    }
                    else if (next != ' ')
                    {
                        DrawWall(x, y, WallSize, e);
                    }
                    x += WallSize;
                }
            }
        }

        #endregion
    }
}
