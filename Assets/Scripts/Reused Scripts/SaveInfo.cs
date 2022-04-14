using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo 
{
	public static void SaveAllInfo()
	{
		//PlayerPrefs.SetString("CHARACTERFORM", GameInfo.CharacterName);
		PlayerPrefs.SetInt("COMBAT", GameInfo.info.Combat);
		PlayerPrefs.SetInt("MIND", GameInfo.info.Mind);
		PlayerPrefs.SetInt("RESISTANCE", GameInfo.info.Resistance);
		PlayerPrefs.SetInt("LUCK", GameInfo.info.Luck);
		PlayerPrefs.SetInt("AGILITY", GameInfo.info.Agility);
		PlayerPrefs.SetFloat("INITIALHEALTH", GameInfo.info.InitialHealth);
		PlayerPrefs.SetFloat("INITIALWILLPOWER", GameInfo.info.InitialWillpower);
		PlayerPrefs.SetInt("ADDCOMBAT", CreateCharacter.AddCombat);
		PlayerPrefs.SetInt("ADDMIND", CreateCharacter.AddMind);
		PlayerPrefs.SetInt("ADDRESISTANCE", CreateCharacter.AddResistance);
		PlayerPrefs.SetInt("ADDLUCK", CreateCharacter.AddLuck);
		PlayerPrefs.SetInt("ADDAGILITY", CreateCharacter.AddAgility);
		PlayerPrefs.SetInt("ADDINITIALHEALTH", CreateCharacter.AddInitialHealth);
		PlayerPrefs.SetInt("ADDINITIALWILLPOWER", CreateCharacter.AddInitialWillpower);
	}
}
