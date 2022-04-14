using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
	private Text textClock;
	public float timeSum;
	public int speed;
	private int hour;
	private int minute;
	private int dayNumber;
	//private bool dayLerp;
	
    void Start()
    {
        textClock = GetComponent<Text>();
		//timeSum += 15000;
    }

    void Update()
    {
		timeSum += Time.deltaTime * speed;
		int minute = 10 * Mathf.FloorToInt(timeSum / 90F) % 60;
		int hour = Mathf.FloorToInt(timeSum / 540F) % 24;
		if(timeSum >= 12960)
		{
			dayNumber ++;
			Debug.Log(dayNumber +" Day Passed");
			timeSum = 0;
		}
		textClock.text = string.Format("{0:0}:{1:00}", hour, minute);
		if (timeSum < 3240 || timeSum >= 10800)
		{
			//time of day = night
		}
		else if (timeSum >= 3240 && timeSum < 4320)
		{
			//dayLerp = true;
			DayCycleChange();
			//time of day = dawn
		}
		else if (timeSum >= 4320 && timeSum < 9720)
		{
			//time of day = day
		}
		else if (timeSum >= 9720 && timeSum < 10800)
		{
			//time of day = dusk
		}
		else
		{
			Debug.Log("Timeless");
		}
    }
	public void DayCycleChange()
	{
		
	}
}
