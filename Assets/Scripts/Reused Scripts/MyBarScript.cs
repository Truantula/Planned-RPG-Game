using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyBarScript : MonoBehaviour {


	private float fillAmount;
	
	[SerializeField]
	private float lerpSpeed;
	
	[SerializeField]
	private Image content;
	
	[SerializeField]
	private TMP_Text valueText;
	
	[SerializeField]
	private Color fullColor;
	
	[SerializeField]
	private Color lowColor;
	
	[SerializeField]
	private bool lerpColors;
	
	public GameObject pauseMenu;
	
	public float MaxValue { get; set; }
	
	public float Value
	{
		set
		{
			string[] tmp = valueText.text.Split(':');
			valueText.text = tmp[0] + ": " + value + " / " + MaxValue;
			fillAmount = Map(value, 0, MaxValue, 0,  1);
		}
	}
	
	void Start ()
	{
		if (lerpColors)
		{
			content.color = fullColor; 
		}
	}
	
	void Update () 
	{

		HandleBar();

	}
	
	private void HandleBar()
	{
		if (fillAmount != content.fillAmount)
		{
		content.fillAmount = Mathf.Lerp(content.fillAmount,fillAmount,Time.fixedDeltaTime * lerpSpeed);
		}
		if (lerpColors)
		{
		content.color = Color.Lerp(lowColor, fullColor, fillAmount);
		}
	}
	
	private float Map(float value, float inMin, float inMax, float outMin, float outMax)
	{
		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
