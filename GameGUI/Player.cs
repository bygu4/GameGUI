namespace Game;

public class Player
{
    private Form form;
    private int playerSize;

    public Player(Form form, (int, int) position, int playerSize)
    {
        this.Position = position;
        this.playerSize = playerSize;
        this.form = form;
        this.form.Paint += this.DrawPlayerEvent;
    }

    public (int, int) Position { get; private set; }

    public void Move((int, int) position)
    {
        this.Position = position;
        this.form.Refresh();
    }

    private void Draw(Graphics graphics)
    {
        using Brush brush = new SolidBrush(Color.Red);
        (int x, int y) = this.Position;
        Rectangle bounds = new Rectangle(
            x * this.playerSize, y * this.playerSize, this.playerSize, this.playerSize);
        graphics.FillEllipse(brush, bounds);
    }

    private void DrawPlayerEvent(object? sender, PaintEventArgs e)
    {
        this.Draw(e.Graphics);
    }
}
