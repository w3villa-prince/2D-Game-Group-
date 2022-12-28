using UnityEngine;

public class Demo : MonoBehaviour
{
    public InvertoryManager invertoryManager;
    public Item[] itemsToPick;

    public void PickupItem(int id)
    {
        invertoryManager.AddItem(itemsToPick[id]);
    }
}
