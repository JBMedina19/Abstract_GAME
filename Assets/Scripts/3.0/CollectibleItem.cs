using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    Inventory playerInventory;
    public string itemName;
    public int itemID;
    public int quantity = 1;


    private void Start()
    {
        playerInventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
    }

    public void CollectItem()
    {
        if (playerInventory != null)
        {
            // Create an item struct and add it to the player's inventory
            Item itemToAdd = new Item(itemName, itemID, quantity);
            playerInventory.AddItem(itemToAdd);

            // Optionally, destroy the item GameObject after collecting
            Destroy(gameObject);
        }
    }
}