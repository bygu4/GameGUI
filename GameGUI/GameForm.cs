namespace GameGUI
{
    public partial class GameForm : Form
    {
        private Game.Game game;

        public GameForm(string filePath)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.game = new Game.Game(this, filePath);
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            game.MovePlayerLeft();
        }

        private void RIghtButton_Click(object sender, EventArgs e)
        {
            game.MovePlayerRight();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            game.MovePlayerUp();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            game.MovePlayerDown();
        }
    }
}
