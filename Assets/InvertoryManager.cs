using UnityEngine;

public class InvertoryManager : MonoBehaviour
{
    public InventorySlot[] InvertorySlots;
    public GameObject InventoryItemPrefab;

    public void AddItem(Item item)
    {
        for (int i = 0; i < InvertorySlots.Length; i++)
        {
            InventorySlot slot = InvertorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }

    private void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(InventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }
}
