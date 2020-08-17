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
                Image imageChild = InventoryButtons[i].transform.GetChild(0).GetComponent<Image>();
                imageChild.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                InventoryButtons[i].transform.GetChild(0).gameObject.SetActive(true);

                Debug.Log(item.name + " was added.");
                itemAdded = true;

                // Do something with the object
                item.SetActive(false);
                break;
            }
        }

        // Inventory full
        if (!itemAdded)
        {
            Debug.Log("Inventory full.");
        }
    }

    public void RemoveItem(GameObject item, int index)
    {
        Debug.Log(inventory[index].name + " was removed from the inventory.");

        // Bring back object into world and remove from inventory
        inventory[index].transform.position = transform.position;
        inventory[index].SetActive(true);
        inventory[index] = null;

        // Update UI
        InventoryButtons[index].transform.GetChild(0).gameObject.SetActive(false);
    }
}
