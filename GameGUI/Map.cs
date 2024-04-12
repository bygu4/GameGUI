namespace Game;

public class Map
{
    private Form form;
    private bool[,] hasWall;
    private int wallSize;

    public Map(Form form, string filePath, int wallSize)
    {
        string inputData = this.GetString(filePath);
        string[] rows = inputData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

        this.Height = rows.Length;
        this.Width = rows[0].Length;
        this.hasWall = new bool[this.Width, this.Height];
        for (int y = 0; y < this.Height; ++y)
        {
            for (int x = 0; x < this.Width; ++x)
            {
                if (rows[y][x] == '@')
                {
                    this.StartPosition = (x, y);
                    this.hasWall[x, y] = false;
                }
                else if (rows[y][x] == ' ')
                {
                    this.hasWall[x, y] = false;
                }
                else
                {
                    this.hasWall[x, y] = true;
                }
            }
        }

        this.wallSize = wallSize;
        this.form = form;
        form.Paint += this.DrawMapEvent;
    }

    public int Width { get; private set; }

    public int Height { get; private set; }

    public (int, int) StartPosition { get; private set; }

    public bool HasWall(int x, int y)
    {
        return this.hasWall[x, y];
    }

    private string GetString(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        return reader.ReadToEnd();
    }

    private void DrawWall(Graphics graphics, int x, int y)
    {
        using Pen pen = new Pen(Color.Black, 3);
        Rectangle wall = new Rectangle(x, y, this.wallSize, this.wallSize);
        graphics.DrawRectangle(pen, wall);
    }

    private void Draw(Graphics graphics)
    {
        for (int y = 0; y < this.Height; ++y)
        {
            for (int x = 0; x < this.Width; ++x)
            {
                if (hasWall[x, y])
                {
                    this.DrawWall(graphics, x * this.wallSize, y * this.wallSize);
                }
            }
        }
    }

    private void DrawMapEvent(object? sender, PaintEventArgs e)
    {
        this.Draw(e.Graphics);
    }
}
