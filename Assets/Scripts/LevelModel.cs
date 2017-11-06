public class LevelModel
{
    public enum SquareType
    {
        EMPTY,
        ONE_TALL,
        TWO_TALL,
        THREE_TALL
    };

    private int[,] map;
   // private Vector2 playerPosition;
   // private Direction pla
    private int mapSize;
     

    public LevelModel(int mapSize)
    {
        this.mapSize = mapSize;
        this.map = new int[this.mapSize, this.mapSize];
    }

    public int[,] GetMap()
    {
        return this.map;
    }

    public int GetMapSize()
    {
        return mapSize;
    }

}
