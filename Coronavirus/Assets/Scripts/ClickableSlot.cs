using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableSlot : MonoBehaviour, IPointerClickHandler
{
    public Inventory inventory;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left Click");
        }

        else if (eventData.button == PointerEventData.InputButton.Middle)
        {
            Debug.Log("Middle Click");
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            int index = transform.parent.transform.GetSiblingIndex();
            if (inventory.inventory[index] != null)
            {
                inventory.RemoveItem(inventory.inventory[index], index);
                Debug.Log("Right Click");
            }
            else
                Debug.Log("There is nothing to remove here.");
        }
    }
}
