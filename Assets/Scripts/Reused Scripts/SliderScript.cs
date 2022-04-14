using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	[SerializeField]
	public Slider actionGuide;
	public Text sliderVal;
	private bool sliderUpCount;
	private bool sliderDirection;
	public int minBound;
	public int maxBound;

	void Start () {
		actionGuide.value = Random.Range(2,159);
		if (actionGuide.value % 2 == 0)
		{
			sliderDirection = true;
		}
		sliderUpCount = true;
		StartCoroutine(ActionTrack());
		minBound = 70;
		maxBound = 90;
	}
	
	// Update is called once per frame
	void Update () 
	{
		sliderVal.text = actionGuide.value.ToString();
		if (sliderUpCount)
		{
			if(sliderDirection)
			{
				actionGuide.value = actionGuide.value + 1;
				if(actionGuide.value == actionGuide.maxValue)
				{
					sliderDirection = false;
				}
			}
			else
			{
				actionGuide.value = actionGuide.value - 1;
				if(actionGuide.value == actionGuide.minValue)
				{
					sliderDirection = true;
				}
			}
		}
	}
	
	private IEnumerator ActionTrack() 
	{
		yield return waitForKeyPress(KeyCode.Space); // wait for this function to return
		sliderUpCount = false;
		if (actionGuide.value > minBound && actionGuide.value < maxBound)
		{
			Debug.Log("Action success");
		}
		else 
		{
			Debug.Log("Action failure");
		}
	}	
	
	private IEnumerator waitForKeyPress(KeyCode key)
	{
    bool done = false;
    while(!done) // essentially a "while true", but with a bool to break out naturally
    {
        if(Input.GetKeyDown(key))
        {
            done = true; // breaks the loop
        }
        yield return null; // wait until next frame, then continue execution from here (loop continues)
    }
	}
}
