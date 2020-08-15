using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool inventory; // If true, item can be stored in inventory
    

    public void DoInteraction()
    {
        // Pick up and put in inventory
        gameObject.SetActive(false);
    }
}
