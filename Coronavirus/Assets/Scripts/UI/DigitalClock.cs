using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DigitalClock : MonoBehaviour
{

    public bool DebugTimeLog = false;

    public Text hourText, dayText, monthText, yearText; 
    public float hour, day, month, year; 

    float elapsedTime;
    public float Seconds_per_ingame_hour = 10f;

    // Start is called before the first frame update
    void Start()
    {

        hour = 0;
        day = 0;
        month = 1;
        year = 2006; 

        elapsedTime = 0; 

    }

    // Update is called once per frame
    void Update()
    {

        hourText.text = "Hour: " + hour.ToString();
        dayText.text = "Day: " + day.ToString();
        monthText.text = "Month: " + month.ToString();
        yearText.text = "Year: " + year.ToString(); 

        elapsedTime += Time.deltaTime;   

       
        if(elapsedTime >= Seconds_per_ingame_hour)
        {
            hour++;
            elapsedTime = 0; 
            
            
            if(hour == 24)
            {
                hour = 0;
                day++; 
            }
            if(day == 30 )
            {
                month++;
                day = 0; 
            }
            if(month == 12)
            {
                month = 0;
                year++; 
            }

        }
        

        
        Debug.Log("Hour: " + hour + " Day: " + day + " Month: " + month + " Year: " + year); 
        Debug.Log(elapsedTime); 

    }
}
