using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = " Scritable Object/Item")]
public class Item : ScriptableObject
{
    [Header("Only GamePlay")]
    public TileBase tile;

    public ItemType Type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
    BuildingBlock, Tool
}

public enum ActionType
{
    Dig, Mine
}
