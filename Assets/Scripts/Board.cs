using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }

    public Tile tileUnknown;
    public Tile tileEmpty;
    public Tile tileMine;
    public Tile tileExploded;
    public Tile tileFlag;
    public Tile tileNum1;
    public Tile tileNum2;
    public Tile tileNum3;
    public Tile tileNum4;
    public Tile tileNum5;
    public Tile tileNum6;
    public Tile tileNum7;
    public Tile tileNum8;
    
    private void Awake()
    {
        tilemap = GetComponent<Tilemap>();
    }

    private Tile GetTile(Cell cell)
    {
        if (cell.revealed)
            return GetRevealedTile(cell);
        else if (cell.flagged)
            return tileFlag;
        else
            return tileUnknown;
    }

    private Tile GetRevealedTile(Cell cell)
    {
        switch (cell.type)
        {
            case Cell.Type.Empty: return tileEmpty;
            case Cell.Type.Mine: return tileMine;
            case Cell.Type.Number: return GetNumberTile(cell);
        }
        return null;
    }

    private Tile GetNumberTile(Cell cell)
    {
        switch (cell.number)
        {
            case 1: return tileNum1;
            case 2: return tileNum1;
            case 3: return tileNum1;
            case 4: return tileNum1;
            case 5: return tileNum1;
            case 6: return tileNum1;
            case 7: return tileNum1;
            case 8: return tileNum1;
            default: return null;
        }
    }

    public void Draw(Cell[,] state)
    {
        int width = state.GetLength(0);
        int height = state.GetLength(1);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Cell cell = state[x, y];
                tilemap.SetTile(cell.position, GetTile(cell));
            }
        }
    }
}