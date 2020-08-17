using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    public GameObject currentInteractableObject = null;
    public Interactable currentInteractableScript = null;
    public Inventory inventory;

    void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInteractableObject)
        {
            // Check to see if obj is to be stored in inventory
            if (currentInteractableScript.inventory)
            {
                inventory.AddItem(currentInteractableObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            Debug.Log(other.name);
            currentInteractableObject = other.gameObject;
            currentInteractableScript = currentInteractableObject.GetComponent<Interactable>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            if (other.gameObject == currentInteractableObject)
            {
                currentInteractableObject = null;
            }
        }
    }
}
