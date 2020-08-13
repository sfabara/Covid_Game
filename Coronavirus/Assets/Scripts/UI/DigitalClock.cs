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

        // TODO: should dynamically create Text displays, instead on relying on references. 

        hour = 0;
        day = 0;
        month = 1;
        year = 2006; // ehhhh ? laffy taffy 

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
        
        // Will display updating variables in debug log. 
        if(DebugTimeLog)
        {
            Debug.Log("Hour: " + hour + " Day: " + day + " Month: " + month + " Year: " + year); 
            Debug.Log(elapsedTime); 
        }

    }


    public float getHour()
    {
        return hour; 
    }

    public float getDay()
    {
        return day; 
    }

    public float getMonth()
    {
        return month;
    }

    public float getyear()
    {
        return year;
    }



}
