namespace Game;

public class Game
{
    private Map map;
    private Player player;

    private int objectSize = 30;

    public Game(Form form, string filePath)
    {
        this.map = new Map(form, filePath, this.objectSize);
        this.player = new Player(form, this.map.StartPosition, this.objectSize);
    }

    public void MovePlayerLeft()
    {
        (int x, int y) = this.player.Position;
        if (x != 0 && !this.map.HasWall(x - 1, y))
        {
            this.player.Move((x - 1, y));
        }
    }

    public void MovePlayerRight()
    {
        (int x, int y) = this.player.Position;
        if (x != this.map.Width && !this.map.HasWall(x + 1, y))
        {
            this.player.Move((x + 1, y));
        }
    }

    public void MovePlayerDown()
    {
        (int x, int y) = this.player.Position;
        if (y != this.map.Height && !this.map.HasWall(x, y + 1))
        {
            this.player.Move((x, y + 1));
        }
    }

    public void MovePlayerUp()
    {
        (int x, int y) = this.player.Position;
        if (y != 0 && !this.map.HasWall(x, y - 1))
        {
            this.player.Move((x, y - 1));
        }
    }
}
