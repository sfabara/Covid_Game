using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[6];
    public Button[] InventoryButtons = new Button[6];
    
    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        // Find 1st open slot in inventory
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;

                // Update UI
                InventoryButtons[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;

                Debug.Log(item.name + " was added.");
                itemAdded = true;
                // Do something with the object
                item.SendMessage("DoInteraction");
                break;
            }
        }

        // Inventory full
        if (!itemAdded)
        {
            Debug.Log("Inventory full.");
        }
    }

    public void RemoveItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == item)
            {
                // Found the item - remove it
                inventory[i] = null;
                Debug.Log(item.name + " was removed from the inventory.");

                // Update UI
                InventoryButtons[i].image.overrideSprite = null;
                break;
            }
        }
    }
}
