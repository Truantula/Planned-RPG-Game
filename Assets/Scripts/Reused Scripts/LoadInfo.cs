using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo 
{
	public static void LoadAllInfo()
	{
		//GameInfo.CharacterName = PlayerPrefs.GetString("FORMNAME");
		//GameInfo.CharacterDescription = PlayerPrefs.GetString("FORMDESCRIPTION");
		GameInfo.info.Combat = PlayerPrefs.GetInt("COMBAT");
		GameInfo.info.Mind = PlayerPrefs.GetInt("MIND");
		GameInfo.info.Resistance = PlayerPrefs.GetInt("RESISTANCE");
		GameInfo.info.Luck = PlayerPrefs.GetInt("LUCK");
		GameInfo.info.Agility = PlayerPrefs.GetInt("AGILITY");
		GameInfo.info.InitialHealth = PlayerPrefs.GetFloat("INITIALHEALTH");
		GameInfo.info.InitialWillpower = PlayerPrefs.GetFloat("INITIALWILLPOWER");
		CreateCharacter.AddCombat = PlayerPrefs.GetInt("ADDCOMBAT");
		CreateCharacter.AddMind = PlayerPrefs.GetInt("ADDMIND");
		CreateCharacter.AddResistance = PlayerPrefs.GetInt("ADDRESISTANCE");
		CreateCharacter.AddLuck = PlayerPrefs.GetInt("ADDLUCK");
		CreateCharacter.AddAgility = PlayerPrefs.GetInt("ADDAGILITY");
		CreateCharacter.AddInitialHealth = PlayerPrefs.GetInt("ADDINITIALHEALTH");
		CreateCharacter.AddInitialWillpower = PlayerPrefs.GetInt("ADDINITIALWILLPOWER");

	}
}
