using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHolos : MonoBehaviour
{

    void Update()
    {
        // Toggle Inventory
        if (Input.GetButtonDown("Toggle Inventory"))
        {
            if (gameObject.transform.GetChild(0).gameObject.activeSelf == true)
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
            else
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

        
    }
}
