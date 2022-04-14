using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AllyInfo : MonoBehaviour
{
    public static AllyInfo info;
	
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
	
	public string AllyName { get; set;}
	public string AllyFormName { get; set;}
	public string AllyDescription { get; set;}
	public static BaseAlly Ally { get; set;}
	public static List<BaseAbility> unlearnedAllyAbilities = new List<BaseAbility>();
	public static List<BaseStatusEffect> allyImmunities = new List<BaseStatusEffect>();
	
	public int Combat { get; set;}
	public int Mind { get; set;}
	public int Resistance { get; set;}
	public int Luck { get; set;}
	public int Agility { get; set;}
	//public int Level;
	public float InitialHealth { get; set;}
	public float InitialWillpower { get; set;}
	
	public TMP_Text combatText;
	public TMP_Text mindText;
	public TMP_Text resistanceText;
	public TMP_Text luckText;
	public TMP_Text agilityText;
	//public TMP_Text levelText;
	public TMP_Text nameText;
	//public TMP_Text descriptionText;
	
	public void UpdateUI()
	{
		combatText.text = AllyInfo.info.Combat.ToString();
		mindText.text = AllyInfo.info.Mind.ToString();
		resistanceText.text = AllyInfo.info.Resistance.ToString();
		agilityText.text = AllyInfo.info.Agility.ToString();
		luckText.text = AllyInfo.info.Luck.ToString();
		//experienceText.text = GameInfo.info.Experience.ToString() + " / 100";
		//nameText.text = AllyInfo.info.AllyName.ToString();
		//descriptionText.text = GameInfo.info.CharacterFormDescription.ToString();
		//levelText.text = GameInfo.info.Level.ToString();
		
		
	}
}
