using UnityEngine;

public struct Cell
{
    public enum Type {
        Empty,
        Mine,
        Number
    }

    public Vector3Int position { get; set; }
    public Type type { get; set; }
    public int number { get; set; }
    public bool revealed { get; set; }
    public bool flagged { get; set; }
    public bool exploded { get; set; }
}
