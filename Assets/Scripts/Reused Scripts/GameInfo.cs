using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameInfo : MonoBehaviour {

	public static GameInfo info;

	// Use this for initialization
	void Awake() 
	{
		
		if(info == null)
		{
			DontDestroyOnLoad(this.gameObject);
			info = this;
		}
		else if(info != this)
		{
			Destroy(gameObject);
		}
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,30), "Combat: " + Combat);
		GUI.Label(new Rect(20,20,100,30), "InitialHealth: " + InitialHealth);
	}
	
	public string CharacterFormName { get; set;}
	public string CharacterFormDescription { get; set;}
	public static BaseForm CharacterForm { get; set;}
	public static List<BaseAbility> unlearnedFormAbilities = new List<BaseAbility>();
	public static List<BaseStatusEffect> characterImmunities = new List<BaseStatusEffect>();
	
	public int Combat { get; set;}
	public int Mind { get; set;}
	public int Resistance { get; set;}
	public int Luck { get; set;}
	public int Agility { get; set;}
	public int Level;
	public float Experience;
	public float Aura;
	public float InitialHealth { get; set;}
	//RemainingHealth
	public float InitialWillpower { get; set;}
	//RemainingWillpower
	public int Coins;
	
	public static BaseAbility characterMoveOne;
	public static BaseAbility characterMoveTwo;
	public static BaseAbility characterMoveThree;
	public static BaseAbility characterMoveFour;
	public static BaseAbility characterMoveFive;
	public static BaseAbility characterMoveSix;
	public static BaseAbility characterMoveSeven;
	public static BaseAbility characterMoveEight;
	public static BaseAbility characterMoveNine;
	public static BaseAbility characterMoveTen;
	
	//find better way to deal with attacks
	
	public TMP_Text combatText;
	public TMP_Text mindText;
	public TMP_Text resistanceText;
	public TMP_Text luckText;
	public TMP_Text agilityText;
	public TMP_Text levelText;
	//public TMP_Text auraKnob;
	public TMP_Text nameText;
	public TMP_Text descriptionText;
	public TMP_Text coinsText;
	public TMP_Text experienceText;
	
	public void UpdateUI()
	{
		combatText.text = GameInfo.info.Combat.ToString();
		mindText.text = GameInfo.info.Mind.ToString();
		resistanceText.text = GameInfo.info.Resistance.ToString();
		agilityText.text = GameInfo.info.Agility.ToString();
		luckText.text = GameInfo.info.Luck.ToString();
		experienceText.text = GameInfo.info.Experience.ToString() + " / 100";
		//auro.text = GameInfo.info.Aura.ToString();
		nameText.text = GameInfo.info.CharacterFormName.ToString();
		//descriptionText.text = GameInfo.info.CharacterFormDescription.ToString();
		//coinsText.text = GameInfo.info.Coins.ToString();
		levelText.text = GameInfo.info.Level.ToString();
		
		
	}

}

