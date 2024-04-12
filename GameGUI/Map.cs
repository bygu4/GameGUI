namespace Game;

public class Map
{
    private bool[,] hasWall;
    private int width;
    private int height;
    private int wallSize = 20;

    public Map(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string inputData = reader.ReadToEnd();
        string[] rows = inputData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        this.height = rows.Length;
        this.width = rows[0].Length;
        this.hasWall = new bool[this.width, this.height];
        for (int y = 0; y < this.height; ++y)
        {
            for (int x = 0; x < this.width; ++x)
            {
                if (rows[y][x] == '@')
                {
                    this.StartPosition = (x, y);
                    this.hasWall[x, y] = false;
                }
                if (rows[y][x] == ' ')
                {
                    this.hasWall[x, y] = false;
                }
                else
                {
                    this.hasWall[x, y] = true;
                }
            }
        }
    }

    public (int, int) StartPosition { get; private set; }

    public bool HasWall(int x, int y)
    {
        return this.hasWall[x, y];
    }

    public void Draw(Graphics graphics)
    {
        Brush wallBrush = new SolidBrush(Color.Black);
        for (int y = 0; y < this.height; ++y)
        {
            for (int x = 0; x < this.width; ++x)
            {
                if (hasWall[x, y])
                {
                    this.DrawWall(
                        graphics, x * this.wallSize, y * this.wallSize, wallBrush);
                }
            }
        }
    }

    private void DrawWall(Graphics graphics, int x, int y, Brush wallBrush)
    {
        Rectangle wall = new Rectangle(x, y, this.wallSize, this.wallSize);
        graphics.FillRectangle(wallBrush, wall);
    }
}
